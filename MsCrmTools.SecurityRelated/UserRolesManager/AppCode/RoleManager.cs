using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Management.Instrumentation;
using System.Runtime.CompilerServices;
using System.Windows.Navigation;

namespace MsCrmTools.UserRolesManager.AppCode
{
    internal class RoleManager
    {
        // set batch size for the exec multi
        // make this editable later
        public int BatchSize { get; set; } = 50;

        private readonly IOrganizationService service;

        public RoleManager(IOrganizationService service)
        {
            this.service = service;
        }

        public void AddRolesToPrincipals(List<Entity> roles, List<Entity> principals, List<Entity> allRoles, BackgroundWorker worker = null)
        {
            int total = principals.Count * roles.Count;
            int current = 0;

            var execMulti = new ExecuteMultipleRequest() {
                Requests = new OrganizationRequestCollection(),
                Settings = new ExecuteMultipleSettings() {
                    ContinueOnError = true,
                    ReturnResponses = true
                }
            };

            foreach (var principal in principals)
            {
                foreach (var role in roles)
                {
                    // allow the user to cancel
                    if (worker.CancellationPending && worker.WorkerSupportsCancellation)
                        return;

                    if (worker != null && worker.WorkerReportsProgress)
                    {
                        worker.ReportProgress(current * 100 / total, "Adding roles to principals ({0} %)...");
                    }
                    var roleToUse = role;
                    if (allRoles != null)
                    {
                        var currentPrincipalBuId = principal.GetAttributeValue<EntityReference>("businessunitid").Id;
                        if (role.GetAttributeValue<EntityReference>("businessunitid").Id != currentPrincipalBuId)
                        {
                            roleToUse = GetRoleRecursive(currentPrincipalBuId, new List<Entity> { role }, allRoles);
                        }
                    }

                    try
                    {
                        // batch the requests across users and roles
                        execMulti.Requests.Add(new AssociateRequest() {
                            Target = principal.ToEntityReference(),
                            Relationship = new Relationship(principal.LogicalName + "roles_association"),
                            RelatedEntities = new EntityReferenceCollection { roleToUse.ToEntityReference() }
                        });
                    }
                    catch
                    {
                        // ignored
                    }

                    current++;

                    // execute the batch once we either meet the batch size or we hit the total
                    if ((current % BatchSize == 0) || (current == total)) {
                        var resp = service.Execute(execMulti);
                        execMulti.Requests.Clear();
                    }
                }
            }
        }

        /// <summary>
        /// Remove all roles from users
        /// </summary>
        /// <param name="principals"></param>
        /// <param name="worker"></param>
        public void RemoveExistingRolesFromPrincipals(List<Entity> principals, BackgroundWorker worker = null)
        {
            if (worker.CancellationPending && worker.WorkerSupportsCancellation)
                return;

            var entityname = principals.First().LogicalName;
            var links = service.RetrieveMultiple(new QueryExpression($"{entityname}roles")
            {
                ColumnSet = new ColumnSet(true),
                Criteria = new FilterExpression
                {
                    Conditions = {
                        new ConditionExpression($"{entityname}id", ConditionOperator.In, principals.Select(p => p.Id).ToArray())
                    }
                },
            });

            int total = links.Entities.Count;
            int current = 0;

            foreach (var link in links.Entities)
            {
                // allow the user to cancel after roles for principal finished
                if (worker.CancellationPending && worker.WorkerSupportsCancellation)
                    return;

                if (worker != null && worker.WorkerReportsProgress) {
                    worker.ReportProgress(current * 100 / total, "Removing roles from principals ({0} %)...");
                }

                RemoveRolesFromPrincipals(new List<Entity> {
                        new Entity("role") {Id = link.GetAttributeValue<Guid>("roleid")}
                    },
                    new List<Entity> {
                            new Entity(entityname) {Id = link.GetAttributeValue<Guid>($"{entityname}id")}
                    },
                    null,
                    worker);

                current++;
            }
        }
        /// <summary>
        /// Remove all listed roles from the list of Principals
        /// </summary>
        /// <param name="roles"></param>
        /// <param name="principals"></param>
        /// <param name="allRoles"></param>
        /// <param name="worker"></param>
        public void RemoveRolesFromPrincipals(List<Entity> roles, List<Entity> principals, List<Entity> allRoles, BackgroundWorker worker = null)
        {
            int total = principals.Count * roles.Count;
            int current = 0;

            var execMulti = new ExecuteMultipleRequest() {
                Requests = new OrganizationRequestCollection(),
                Settings = new ExecuteMultipleSettings()
                {
                    ContinueOnError = true,
                    ReturnResponses = true
                }
            };

            foreach (var principal in principals)
            {
                foreach (var role in roles)
                {
                    // allow the user to cancel 
                    if (worker.CancellationPending && worker.WorkerSupportsCancellation)
                        return;

                    if (worker != null && worker.WorkerReportsProgress)
                    {
                        worker.ReportProgress(current * 100 / total, "Removing roles from principals ({0} %)...");
                    }

                    var roleToUse = role;

                    if (allRoles != null)
                    {
                        var currentPrincipalBuId = principal.GetAttributeValue<EntityReference>("businessunitid").Id;
                        if (role.GetAttributeValue<EntityReference>("businessunitid").Id != currentPrincipalBuId)
                        {
                            roleToUse = GetRoleRecursive(currentPrincipalBuId, new List<Entity> { role }, allRoles);
                        }
                    }

                    execMulti.Requests.Add(new DisassociateRequest {
                        Target = principal.ToEntityReference(),
                        Relationship= new Relationship(principal.LogicalName + "roles_association"),
                        RelatedEntities = new EntityReferenceCollection { roleToUse.ToEntityReference() }
                    });
                    current++;

                    // execute the batch once we either meet the batch size or we hit the total
                    if ((current % BatchSize == 0) || (current == total))
                    {
                        var resp = service.Execute(execMulti);
                        execMulti.Requests.Clear();
                    }
                }
            }
        }

        public List<Entity> GetRoles()
        {
            OrganizationServiceContext org = new OrganizationServiceContext(service);
            return (from role in org.CreateQuery("role")
                    select new Entity("role")
                    {
                        Id = role.Id
                    }).ToList();
        }

        public Guid GetRootBusinessUnitId()
        {
            return service.RetrieveMultiple(new QueryExpression("businessunit")
            {
                Criteria = new FilterExpression
                {
                    Conditions =
                {
                    new ConditionExpression("parentbusinessunitid", ConditionOperator.Null)
                }
                }
            }).Entities.First().Id;
        }

        private Entity GetRoleRecursive(Guid buId, List<Entity> roles, List<Entity> allRoles)
        {
            if (roles == null || allRoles == null)
            {
                return null;
            }

            foreach (var role in roles)
            {
                if (role.GetAttributeValue<EntityReference>("businessunitid").Id == buId)
                {
                    return role;
                }

                var childRole = GetRoleRecursive(buId,
                       allRoles.Where(a => a.GetAttributeValue<EntityReference>("parentroleid") != null && a.GetAttributeValue<EntityReference>("parentroleid").Id == role.Id).ToList(),
                       allRoles);

                if (childRole != null)
                {
                    return childRole;
                }
            }

            return null;
        }
    }
}
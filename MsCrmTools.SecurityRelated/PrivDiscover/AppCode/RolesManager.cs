using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MsCrmTools.PrivDiscover.AppCode
{
    internal class RolesManager
    {
        private readonly IOrganizationService service;

        public RolesManager(IOrganizationService service)
        {
            this.service = service;
        }

        public DataCollection<Entity> GetPrivileges()
        {
            EntityCollection ec = null;

            var qe = new QueryExpression("privilege")
            {
                Criteria = new FilterExpression(),
                ColumnSet = new ColumnSet("name", "canbebasic", "canbelocal", "canbedeep", "canbeglobal", "accessright"),
                PageInfo = new PagingInfo
                {
                    Count = 5000,
                    PageNumber = 1
                }
            };

            EntityCollection records;
            do
            {
                records = service.RetrieveMultiple(qe);
                if (ec == null) ec = records;
                else ec.Entities.AddRange(records.Entities);
                qe.PageInfo.PageNumber++;
                qe.PageInfo.PagingCookie = records.PagingCookie;
            }
            while (records.MoreRecords);

            return ec.Entities;
        }

        public List<SecurityRole> GetRoles()
        {
            var list = new List<SecurityRole>();

            var qe = new QueryExpression("roleprivileges")
            {
                ColumnSet = new ColumnSet("privilegedepthmask", "privilegeid"),
                LinkEntities =
                {
                    new LinkEntity
                    {
                         EntityAlias = "role",
                        LinkFromEntityName = "roleprivileges",
                        LinkFromAttributeName = "roleid",
                        LinkToAttributeName = "roleid",
                        LinkToEntityName = "role",
                        Columns = new ColumnSet("name","roleid"),
                    }
                },
                PageInfo = new PagingInfo
                {
                    Count = 5000,
                    PageNumber = 1
                }
            };

            //var qe = new QueryExpression("role") { Criteria = new FilterExpression(), ColumnSet = new ColumnSet("name") };
            //qe.Criteria.AddCondition("parentroleid", ConditionOperator.Null);
            //qe.Criteria.AddCondition("name", ConditionOperator.Equal, "Administrateur système");
            //qe.PageInfo = new PagingInfo
            //{
            //    Count = 5000,
            //    PageNumber = 1
            //};
            //qe.LinkEntities.Add(new LinkEntity
            //{
            //    //LinkFromEntityName = "systemuserroles",
            //    //LinkFromAttributeName = "roleid",
            //    //LinkToAttributeName = "roleid",
            //    //LinkToEntityName = "role",

            //    //LinkEntities =
            //    //            {
            //    //                new LinkEntity
            //    //                {
            //    EntityAlias = "priv",
            //    LinkFromEntityName = "role",
            //    LinkFromAttributeName = "roleid",
            //    LinkToAttributeName = "roleid",
            //    LinkToEntityName = "roleprivileges",
            //    Columns = new ColumnSet("privilegedepthmask", "privilegeid"),
            //    //LinkEntities =
            //    //{
            //    //    new LinkEntity
            //    //    {
            //    //        EntityAlias = "privDef",
            //    //        LinkFromEntityName = "roleprivileges",
            //    //        LinkFromAttributeName = "privilegeid",
            //    //        LinkToAttributeName = "privilegeid",
            //    //        LinkToEntityName = "privilege",
            //    //        Columns = new ColumnSet("privilegeid")
            //    //    }
            //    //}
            //    //}
            //    //}
            //});

            var list2 = new List<Entity>();
            EntityCollection ec;

            do
            {
                ec = service.RetrieveMultiple(qe);

                qe.PageInfo.PagingCookie = ec.PagingCookie;
                qe.PageInfo.PageNumber++;

                list2.AddRange(ec.Entities);
            }
            while (ec.MoreRecords);

            var roles = list2.GroupBy(l => (Guid)l.GetAttributeValue<AliasedValue>("role.roleid").Value);

            foreach (var role in roles)
            {
                var sr = new SecurityRole
                {
                    Id = role.Key,
                    Name = role.First().GetAttributeValue<AliasedValue>("role.name").Value.ToString(),
                    Privileges = new List<Privilege>()
                };

                foreach (var roleprivilege in role)
                {
                    PrivilegeDepth depth = 0;
                    switch (roleprivilege.GetAttributeValue<int>("privilegedepthmask"))
                    {
                        case 1:
                            depth = PrivilegeDepth.Basic;
                            break;

                        case 2:
                            depth = PrivilegeDepth.Local;
                            break;

                        case 4:
                            depth = PrivilegeDepth.Deep;
                            break;

                        case 8:
                            depth = PrivilegeDepth.Global;
                            break;
                    }

                    sr.Privileges.Add(new Privilege
                    {
                        Id = roleprivilege.GetAttributeValue<Guid>("privilegeid"),
                        Depth = depth
                    });
                }

                list.Add(sr);
            }

            return list;
        }
    }
}
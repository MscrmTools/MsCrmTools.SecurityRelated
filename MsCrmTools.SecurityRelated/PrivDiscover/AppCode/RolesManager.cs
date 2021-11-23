﻿using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System.Collections.Generic;

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
                    Count = 500,
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

            var qe = new QueryExpression("role") { Criteria = new FilterExpression(), ColumnSet = new ColumnSet("name") };
            qe.Criteria.AddCondition("parentroleid", ConditionOperator.Null);

            var roles = service.RetrieveMultiple(qe).Entities;

            foreach (var role in roles)
            {
                var sr = new SecurityRole
                {
                    Id = role.Id,
                    Name = role["name"].ToString(),
                    Privileges = new List<Privilege>()
                };

                var request = new RetrieveRolePrivilegesRoleRequest
                {
                    RoleId = role.Id
                };

                var response = (RetrieveRolePrivilegesRoleResponse)service.Execute(request);

                foreach (var roleprivilege in response.RolePrivileges)
                {
                    sr.Privileges.Add(new Privilege
                    {
                        Id = roleprivilege.PrivilegeId,
                        Depth = roleprivilege.Depth
                    });
                }

                list.Add(sr);
            }

            return list;
        }
    }
}
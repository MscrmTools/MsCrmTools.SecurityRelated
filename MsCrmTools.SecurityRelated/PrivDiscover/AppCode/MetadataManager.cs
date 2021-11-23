using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Metadata.Query;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MsCrmTools.PrivDiscover.AppCode
{
    internal class MetadataManager
    {
        private readonly IOrganizationService service;

        public MetadataManager(IOrganizationService service)
        {
            this.service = service;
        }

        public List<EntityMetadata> GetEntitiesWithPrivileges()
        {
            var request = new RetrieveAllEntitiesRequest
            {
                EntityFilters =
                                      EntityFilters.Entity | EntityFilters.Privileges
            };
            var response = (RetrieveAllEntitiesResponse)service.Execute(request);

            return response.EntityMetadata.ToList();
        }

        public List<EntityMetadata> GetEntitiesWithPrivileges(List<Entity> solutions)
        {
            if (solutions?.Count > 0)
            {
                var components = service.RetrieveMultiple(new QueryExpression("solutioncomponent")
                {
                    ColumnSet = new ColumnSet("objectid"),
                    NoLock = true,
                    Criteria = new FilterExpression
                    {
                        Conditions =
                        {
                            new ConditionExpression("solutionid", ConditionOperator.In, solutions.Select(s => s.Id).ToArray()),
                            new ConditionExpression("componenttype", ConditionOperator.Equal, 1)
                        }
                    }
                }).Entities;

                var list = components.Select(component => component.GetAttributeValue<Guid>("objectid"))
                    .ToList();

                if (list.Count > 0)
                {
                    EntityQueryExpression entityQueryExpression = new EntityQueryExpression
                    {
                        Criteria = new MetadataFilterExpression(LogicalOperator.Or),
                        Properties = new MetadataPropertiesExpression("DisplayName", "LogicalName", "SchemaName", "Privileges", "IsActivity")
                    };

                    list.ForEach(id =>
                    {
                        entityQueryExpression.Criteria.Conditions.Add(new MetadataConditionExpression("MetadataId", MetadataConditionOperator.Equals, id));
                    });

                    RetrieveMetadataChangesRequest retrieveMetadataChangesRequest = new RetrieveMetadataChangesRequest
                    {
                        Query = entityQueryExpression,
                        ClientVersionStamp = null
                    };

                    var resp = (RetrieveMetadataChangesResponse)service.Execute(retrieveMetadataChangesRequest);

                    return resp.EntityMetadata.ToList();
                }

                return new List<EntityMetadata>();
            }

            var request = new RetrieveAllEntitiesRequest
            {
                EntityFilters =
                                      EntityFilters.Entity | EntityFilters.Privileges
            };
            var response = (RetrieveAllEntitiesResponse)service.Execute(request);

            return response.EntityMetadata.ToList();
        }
    }
}
using System;
using System.Linq;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;

namespace Academia2
{
    public class Oportunidade
    {
        public IOrganizationService Service { get; set;}

        public Oportunidade(IOrganizationService service)
        {
            this.Service = service;
        }

        public Entity GetOportunidade(Guid oportunidadeId)
        {
            var fetchXml = $@"<?xml version=""1.0"" encoding=""utf-16""?>
            <fetch top=""50"">
            <entity name=""opportunity"">
                <filter>
                <condition attribute=""opportunityid"" operator=""eq"" value=""{oportunidadeId}"" uiname=""Silver"" uitype=""twk_niveldocliente"" />
                </filter>
                <link-entity name=""account"" from=""accountid"" to=""customerid"">
                <link-entity name=""twk_niveldocliente"" from=""twk_niveldoclienteid"" to=""twk_niveldocliente"" alias=""nivel"">
                    <attribute name=""twk_porcentagem"" />
                </link-entity>
                </link-entity>
            </entity>
            </fetch>";
            return this.Service.RetrieveMultiple(new FetchExpression(fetchXml)).Entities.FirstOrDefault();
        }
    }
}
using System;
using Microsoft.Xrm.Sdk;
using System.Activities;


namespace Academia2
{
    public class SomaOportunidadeCliente : ActionImplement
    {
        public override void ExecuteAction(CodeActivityContext context)
        {
            Guid oportunidadeId = this.WorkflowContext.PrimaryEntityId;

            Oportunidade oportunidade = new Oportunidade(this.Service);
            Entity opp = oportunidade.GetOportunidade(oportunidadeId);
            
            var porcentagem = opp.GetAttributeValue<AliasedValue>("nivel.twk_porcentagem").Value;

            Entity oportunidadeAtualizar = new Entity("opportunity", oportunidadeId);
            oportunidadeAtualizar["discountpercentage"] = porcentagem;
            this.Service.Update(oportunidadeAtualizar);
        }
        
    }
}

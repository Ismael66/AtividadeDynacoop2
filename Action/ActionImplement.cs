using Microsoft.Xrm.Sdk;
using System.Activities;
using Microsoft.Xrm.Sdk.Workflow;

namespace Academia2
{
    public abstract class ActionImplement : CodeActivity
    {
        public IWorkflowContext WorkflowContext;
        public IOrganizationServiceFactory ServiceFactory;
        public IOrganizationService Service;

        protected override void Execute(CodeActivityContext context)
        {
            WorkflowContext = context.GetExtension<IWorkflowContext>();
            ServiceFactory = context.GetExtension<IOrganizationServiceFactory>();
            Service = ServiceFactory.CreateOrganizationService(WorkflowContext.UserId);

            ExecuteAction(context);
        }

        public abstract void ExecuteAction(CodeActivityContext context);
    }
}
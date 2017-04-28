using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkFlowDll;

namespace WorkflowApp
{
    public class WorkflowEngine
    {
        private Workflow _workflow;
        public WorkflowEngine(Workflow workflow)
        {
            _workflow = workflow;
        }

        public void Run()
        {
            _workflow.RunWorkflow();
        }

    }

}

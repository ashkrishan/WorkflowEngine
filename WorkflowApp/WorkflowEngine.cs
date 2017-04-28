using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowApp
{
    public class WorkflowEngine
    {
        public void Run(Workflow workflow)
        {
            workflow.RunWorkflow();
        }

    }

}

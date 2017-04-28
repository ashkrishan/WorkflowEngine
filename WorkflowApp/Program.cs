using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkFlowDll;

namespace WorkflowApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var workflow = new Workflow();
            workflow.RegisterActivity(new TimeRecording());
            workflow.RegisterActivity(new UploadVideo());
            var workflowEngine = new WorkflowEngine(workflow);
            workflowEngine.Run();
            
        }
    }
}

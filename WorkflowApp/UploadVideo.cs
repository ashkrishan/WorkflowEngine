using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowApp
{
    class UploadVideo : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Upload vid now");
        }
    }
}

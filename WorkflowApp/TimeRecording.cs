using System;

namespace WorkflowApp
{
    public class TimeRecording : IActivity
    {

        public void Execute()
        {
            Console.WriteLine("Time recording running");
        }
    }

}

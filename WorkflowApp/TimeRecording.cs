using System;

namespace WorkflowApp
{
    public class TimeRecording : IActivity
    {

        public void Execute(Activity activity)
        {
            Console.WriteLine("Time recording running");
        }
    }

}

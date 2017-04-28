using System;

namespace WorkFlowDll
{
    public class TimeRecording : IActivity
    {

        public void Execute()
        {
            Console.WriteLine("Time recording running");
        }
    }

}

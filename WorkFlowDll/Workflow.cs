using System.Collections.Generic;

namespace WorkFlowDll
{
    public class Workflow
    {

        private readonly IList<IActivity> _activities;

        public Workflow()
        {
            _activities = new List<IActivity>();

        }

       internal void RunWorkflow()
        {
            foreach (var activity in _activities)
            {
                activity.Execute();
            }
        }

        public void RegisterActivity(IActivity activity)
        {
            _activities.Add(activity);
        }


    }

}

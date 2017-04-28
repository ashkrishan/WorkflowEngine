using System.Collections.Generic;

namespace WorkflowApp
{
    public class Workflow
    {

        private readonly IList<IActivity> _activities;

        public Workflow()
        {
            _activities = new List<IActivity>();

        }

        public void RunWorkflow()
        {
            foreach (var activity in _activities)
            {
                activity.Execute(new Activity());
            }
        }

        public void RegisterActivity(IActivity activity)
        {
            _activities.Add(activity);
        }


    }

}

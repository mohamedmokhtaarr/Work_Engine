using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workflow_engine.interfaces;

namespace workflow_engine.implementation
{
   public class WorkFlow:IWorkFlow

    {

       readonly private List<IActivity> activities ;

        public WorkFlow()
        {
            activities = new List<IActivity>();
        }
        public void AddActivity(IActivity activity)
        {
            activities.Add(activity);
    }

        public List<IActivity> GetActivities()
        {
            return activities;  
        }
    }
}

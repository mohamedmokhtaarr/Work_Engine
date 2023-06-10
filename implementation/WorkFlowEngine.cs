using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workflow_engine.interfaces;

namespace workflow_engine
{
    public class WorkFlowEngine:IWorkFlowEngine
    {

        public void Run(IWorkFlow workFlow)
        {
            var activity = workFlow.GetActivities();
            for (int i = 0; i < activity.Count; i++)
            {
                activity[i].Execute();
            }
        }
    }
}

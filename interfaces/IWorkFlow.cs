using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workflow_engine.interfaces
{
   public interface IWorkFlow
    {
        void AddActivity(IActivity activity);
        List<IActivity> GetActivities();
    }
}

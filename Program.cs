using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workflow_engine.implementation;

namespace workflow_engine
{
   
    class Program
    {
        static void Main(string[] args)
        {
            var act1 = new CallWebService();
            var act2 = new SendEmail();
            var act3 = new UploadVedio ();
            var workflow =new WorkFlow();
            workflow.AddActivity(act1);
            workflow.AddActivity(act2);
            workflow.AddActivity(act3);
            var workflowengine = new WorkFlowEngine ();
            workflowengine.Run(workflow);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workflow_engine.implementation;

namespace workflow_engine.interfaces
{
   public interface IWorkFlowEngine
    {
         void Run(IWorkFlow workFlow);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workflow_engine.interfaces;

namespace workflow_engine.implementation
{

    public class CallWebService : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("video ready for encoding. ");
        }
    }
}

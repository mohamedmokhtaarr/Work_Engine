using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workflow_engine.interfaces;

namespace workflow_engine.implementation
{
    public class UploadVedio : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("The Vedio Is Uploaded");
        }
    }
}

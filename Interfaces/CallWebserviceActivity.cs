using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class CallWebserviceActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Call Webservice...");
        }
    }
}

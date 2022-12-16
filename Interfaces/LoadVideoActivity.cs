using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class LoadVideoActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Load video...");
        }
    }
}

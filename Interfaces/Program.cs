using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LoadVideoActivity loadVideoActivity = new LoadVideoActivity();
            CallWebserviceActivity callWebserviceActivity = new CallWebserviceActivity();

            WorkFlow workflow = new WorkFlow();
            workflow.AddWorkFlow(loadVideoActivity);
            workflow.AddWorkFlow(callWebserviceActivity);

            List<IActivity> list = workflow.GetWorkFlow();

            WorkflowEngine workflowEngine = new WorkflowEngine();
            workflowEngine.Run(list);
        }
    }
}

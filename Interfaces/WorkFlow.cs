using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class WorkFlow
    {
        private readonly List<IActivity> _workflow;

        public WorkFlow()
        {
            _workflow = new List<IActivity>();
        }

        public void AddWorkFlow(IActivity activity)
        {
            _workflow.Add(activity);
        }

        public List<IActivity> GetWorkFlow()
        {
            return _workflow;
        }
    }
}

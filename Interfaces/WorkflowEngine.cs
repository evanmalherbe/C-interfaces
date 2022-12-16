﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class WorkflowEngine
    {
        public void Run(List<IActivity> workFlow)
        {
            foreach (IActivity activity in workFlow)
            {
                activity.Execute();
            }
        }
    }
}

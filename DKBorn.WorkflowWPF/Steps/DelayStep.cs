using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkflowCore.Interface;
using WorkflowCore.Models;

namespace DKBorn.WorkflowWPF.Steps
{
    public class DelayStep : StepBody
    {
        public int Delay { get; set; }
        public override ExecutionResult Run(IStepExecutionContext context)
        {
            Thread.Sleep(Delay);
            return ExecutionResult.Next();
        }
    }
}

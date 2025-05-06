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
    public class AddNumbersStep : StepBody
    {
        public int Input1 { get; set; }
        public int Input2 { get; set; }
        public int Result { get; set; }

        public override ExecutionResult Run(IStepExecutionContext context)
        {
            Result = Input1 + Input2;

            Trace.WriteLine($"{Input1} + {Input2} = {Result}");
            Console.Out.Flush();
            return ExecutionResult.Next();
        }
    }
}

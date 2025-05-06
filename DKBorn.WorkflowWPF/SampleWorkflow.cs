using DKBorn.WorkflowWPF.Steps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkflowCore.Interface;

namespace DKBorn.WorkflowWPF
{
    public class SampleWorkflow : IWorkflow<Dictionary<string, object>>
    {
        public string Id => "SampleWorkflow";
        public int Version => 1;

        public void Build(IWorkflowBuilder<Dictionary<string, object>> builder)
        {
            builder
                .StartWith<AddNumbersStep>()
                    .Input(step => step.Input1, _ => 3)
                    .Input(step => step.Input2, _ => 5)
                .Parallel()
                    .Do(branch => branch
                        .StartWith<DelayStep>()
                            .Input(step => step.Delay, _ => 1000)
                        .Then<AddNumbersStep>()
                            .Input(step => step.Input1, _ => 33)
                            .Input(step => step.Input2, _ => 44)
                        .Then<AddNumbersStep>()
                            .Input(step => step.Input1, _ => 33)
                            .Input(step => step.Input2, _ => 44)
                        .Then<AddNumbersStep>()
                            .Input(step => step.Input1, _ => 33)
                            .Input(step => step.Input2, _ => 44)
                        .Then<AddNumbersStep>()
                            .Input(step => step.Input1, _ => 33)
                            .Input(step => step.Input2, _ => 44))
                    .Do(branch => branch
                        .StartWith<DelayStep>()
                            .Input(step => step.Delay, _ => 3000)
                        .Then<AddNumbersStep>()
                            .Input(step => step.Input1, _ => 10)
                            .Input(step => step.Input2, _ => 20)
                        .Then<AddNumbersStep>()
                            .Input(step => step.Input1, _ => 10)
                            .Input(step => step.Input2, _ => 20)
                        .Then<AddNumbersStep>()
                            .Input(step => step.Input1, _ => 10)
                            .Input(step => step.Input2, _ => 20)
                        .Then<AddNumbersStep>()
                            .Input(step => step.Input1, _ => 10)
                            .Input(step => step.Input2, _ => 20))
                .Join();
        }
    }

}

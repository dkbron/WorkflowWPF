using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WorkflowCore.Interface;

namespace DKBorn.WorkflowWPF.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        private readonly IWorkflowHost _workflowHost;

        public ObservableCollection<NodeViewModel> Nodes { get; } = new();
        public ObservableCollection<ConnectionViewModel> Connections { get; } = new();

        public MainViewModel(IWorkflowHost workflowHost)
        {
            _workflowHost = workflowHost;
            _workflowHost.RegisterWorkflow<SampleWorkflow, Dictionary<string, object>>();
            _workflowHost.Start();
        }

        [RelayCommand]
        private void RunWorkflow()
        {
            _workflowHost.StartWorkflow("SampleWorkflow", 1, new Dictionary<string, object>());
        }
    }

}

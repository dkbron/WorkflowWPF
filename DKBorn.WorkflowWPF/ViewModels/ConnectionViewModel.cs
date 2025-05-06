using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKBorn.WorkflowWPF.ViewModels
{
    public partial class ConnectionViewModel : ObservableObject
    {
        [ObservableProperty]
        private ConnectorViewModel? source;
        [ObservableProperty]
        private ConnectorViewModel? target;
    }
}

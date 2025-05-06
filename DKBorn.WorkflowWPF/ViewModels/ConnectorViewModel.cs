using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DKBorn.WorkflowWPF.ViewModels
{
    public partial class ConnectorViewModel : ObservableObject
    {
        [ObservableProperty]
        private string title;

        [ObservableProperty]
        private Point anchor;

        [ObservableProperty]
        private bool isConnected;
    }
}

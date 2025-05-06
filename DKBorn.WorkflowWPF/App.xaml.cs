using DKBorn.WorkflowWPF.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Data;
using System.Windows;

namespace DKBorn.WorkflowWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static IServiceProvider Services { get; private set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            Services = ConfigureServices();

            var mainWindow = Services.GetRequiredService<MainWindow>();
            mainWindow.Show();
        }

        private static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddLogging();
            services.AddWorkflow();
            services.AddSingleton<MainViewModel>();

            // 注册 View，并设置其 DataContext
            services.AddSingleton<MainWindow>(provider =>
            {
                var viewModel = provider.GetRequiredService<MainViewModel>();
                return new MainWindow { DataContext = viewModel };
            });

            return services.BuildServiceProvider();
        }
    }

}

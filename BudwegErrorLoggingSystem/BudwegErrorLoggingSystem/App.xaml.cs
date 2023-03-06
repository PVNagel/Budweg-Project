using BudwegErrorLoggingSystem.Stores;
using BudwegErrorLoggingSystem.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace BudwegErrorLoggingSystem
{
    public partial class App : Application
    {
        private readonly ModalNavigationStore _modalNavigationStore;
        private readonly SelectedReportStore _selectedReportStore;

        public App()
        {
            _modalNavigationStore = new ModalNavigationStore();
            _selectedReportStore = new SelectedReportStore();  
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            ReportVM reportVM = new ReportVM(_selectedReportStore, _modalNavigationStore);

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_modalNavigationStore, reportVM) 
            };
            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}

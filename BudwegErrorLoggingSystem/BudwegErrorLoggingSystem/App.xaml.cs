using BudwegErrorLoggingSystem.Stores;
using BudwegErrorSystem.ViewModels;
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
        private readonly SelectedReportStore _selectedReportStore;

        public App()
        {
            _selectedReportStore = new SelectedReportStore();  
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow
            {
                DataContext = new ReportsViewVM(_selectedReportStore)
            };
            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}

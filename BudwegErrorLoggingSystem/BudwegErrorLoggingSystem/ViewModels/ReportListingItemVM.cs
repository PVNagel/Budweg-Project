using BudwegErrorLoggingSystem.Commands;
using BudwegErrorLoggingSystem.Models;
using BudwegErrorLoggingSystem.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BudwegErrorLoggingSystem.ViewModels
{
    public class ReportListingItemVM : ViewModelBase
    {
        public Report Report { get; private set; }

        public string ErrorMessage => Report.ErrorMessage;

        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }

        public ReportListingItemVM(Report report, ReportStore reportStore, ModalNavigationStore modalNavigationStore)
        {
            Report = report;

            EditCommand = new OpenEditReportCommand(this, reportStore, modalNavigationStore);
        }

        public void Update(Report report)
        {
            Report = report;

            OnPropertyChanged(nameof(Report));
        }
    }
}

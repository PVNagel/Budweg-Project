using BudwegErrorLoggingSystem.Commands;
using BudwegErrorLoggingSystem.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BudwegErrorLoggingSystem.ViewModels
{
    public class ReportVM : ViewModelBase
    {
        public ReportListingVM ReportListingVM { get; }
        public ReportDetailsVM ReportDetailsVM { get; }

        public ICommand AddReportCommand { get; }

        public ReportVM(SelectedReportStore _selectedReportStore, ModalNavigationStore modalNavigationStore)
        {
            ReportListingVM= new ReportListingVM(_selectedReportStore, modalNavigationStore);
            ReportDetailsVM= new ReportDetailsVM(_selectedReportStore);

            AddReportCommand = new OpenAddReportCommand(modalNavigationStore);
        }
    }
}

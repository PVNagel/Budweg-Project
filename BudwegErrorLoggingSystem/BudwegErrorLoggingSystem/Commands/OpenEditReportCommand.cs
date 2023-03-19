using BudwegErrorLoggingSystem.Models;
using BudwegErrorLoggingSystem.Stores;
using BudwegErrorLoggingSystem.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudwegErrorLoggingSystem.Commands
{
    public class OpenEditReportCommand : CommandBase
    {
        private readonly ModalNavigationStore _modalNavigationStore;
        private readonly ReportListingItemVM _reportListingItemVM;
        private readonly ReportStore _reportStore;

        public OpenEditReportCommand(ReportListingItemVM reportListingItemVM, 
            ReportStore reportStore, 
            ModalNavigationStore modalNavigationStore)
        {
            _reportListingItemVM = reportListingItemVM;
            _reportStore = reportStore;
            _modalNavigationStore = modalNavigationStore;
        }

        public override void Execute(object? parameter)
        {
            Report report = _reportListingItemVM.Report;

            EditReportVM editReportVM = 
                new EditReportVM(report, _reportStore, _modalNavigationStore);
            _modalNavigationStore.CurrentViewModel = editReportVM;
        }
    }
}

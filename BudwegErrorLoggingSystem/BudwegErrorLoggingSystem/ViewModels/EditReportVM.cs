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
    public class EditReportVM : ViewModelBase
    {
        public Guid ReportId { get; }

        public ReportDetailsFormVM ReportDetailsFormVM { get; }

        public EditReportVM(Report report, ReportStore reportStore, ModalNavigationStore modalNavigationStore)
        {
            ReportId = report.Id;

            ICommand submitCommand = new EditReportCommand(this, reportStore, modalNavigationStore);
            ICommand cancelCommand = new CloseModalCommand(modalNavigationStore);
            ReportDetailsFormVM = new ReportDetailsFormVM(submitCommand, cancelCommand)
            {
                Report = report.ReportDisplay,
                ErrorMessage = report.ErrorMessage,
                IsResolved = report.IsResolved
                
            };
        }
    }
}

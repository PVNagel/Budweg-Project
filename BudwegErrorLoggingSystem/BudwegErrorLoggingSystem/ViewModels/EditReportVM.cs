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
    public class EditReportVM : ViewModelBase
    {
        public ReportDetailsFormVM ReportDetailsFormVM { get; }

        public EditReportVM(ModalNavigationStore modalNavigationStore)
        {
            ICommand cancelCommand = new CloseModalCommand(modalNavigationStore);
            ReportDetailsFormVM = new ReportDetailsFormVM(null, cancelCommand);
        }
    }
}

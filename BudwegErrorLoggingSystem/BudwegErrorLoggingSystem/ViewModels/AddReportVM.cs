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
    public class AddReportVM : ViewModelBase
    {
        public ReportDetailsFormVM ReportDetailsFormVM { get; }

        public AddReportVM(ModalNavigationStore modalNavigationStore)
        {
            ICommand cancelCommand = new CloseModalCommand(modalNavigationStore);
            ReportDetailsFormVM = new ReportDetailsFormVM(null, cancelCommand);
        }
    }
}

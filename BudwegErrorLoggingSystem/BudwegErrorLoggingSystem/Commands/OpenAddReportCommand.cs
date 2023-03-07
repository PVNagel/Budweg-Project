using BudwegErrorLoggingSystem.Stores;
using BudwegErrorLoggingSystem.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BudwegErrorLoggingSystem.Commands
{
    public class OpenAddReportCommand : CommandBase
    {
        private readonly ReportStore _reportStore;
        private readonly ModalNavigationStore _modalNavigationStore;

        public OpenAddReportCommand(ReportStore reportStore, ModalNavigationStore modalNavigationStore)
        {
            _reportStore = reportStore;
            _modalNavigationStore = modalNavigationStore;
        }

        public override void Execute(object parameter)
        {
            AddReportVM addReportVM = new AddReportVM(_reportStore, _modalNavigationStore);
            _modalNavigationStore.CurrentViewModel = addReportVM;
        }
    }
}

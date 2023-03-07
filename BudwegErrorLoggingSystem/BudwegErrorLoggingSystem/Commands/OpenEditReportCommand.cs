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
        private readonly Report _report;
        private readonly ModalNavigationStore _modalNavigationStore;

        public OpenEditReportCommand(
            Report report,
            ModalNavigationStore modalNavigationStore)
        {
            _report = report;
            _modalNavigationStore = modalNavigationStore;
        }

        public override void Execute(object? parameter)
        {
            EditReportVM editReportVM = new EditReportVM(_report, _modalNavigationStore);
            _modalNavigationStore.CurrentViewModel = editReportVM;
        }
    }
}

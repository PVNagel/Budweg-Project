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
    public class DeleteReportCommand : AsyncCommandBase
    {
        private readonly DeleteReportVM _deleteReportVM;
        private readonly ReportStore _reportStore;
        private readonly ModalNavigationStore _modalNavigationStore;

        public DeleteReportCommand(DeleteReportVM deleteReportVM, ReportStore reportStore, ModalNavigationStore modalNavigationStore)
        {
            _deleteReportVM = deleteReportVM;
            _reportStore = reportStore;
            _modalNavigationStore = modalNavigationStore;
        }
        public override async Task ExecuteAsync(object? parameter)
        {
            ReportDetailsFormVM formVM = _deleteReportVM.ReportDetailsFormVM;

            Report report = new Report(
                _deleteReportVM.ReportId,
                formVM.Report,
                formVM.ErrorMessage,
                formVM.IsResolved);

            try
            {
                await _reportStore.Update(report);

                _modalNavigationStore.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

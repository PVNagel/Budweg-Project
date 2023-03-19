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
    public class EditReportCommand : AsyncCommandBase
    {
        private readonly EditReportVM _editReportVM;
        private readonly ReportStore _reportStore;
        private readonly ModalNavigationStore _modalNavigationStore;

        public EditReportCommand(EditReportVM editReportVM, ReportStore reportStore, ModalNavigationStore modalNavigationStore)
        {
            _editReportVM = editReportVM;
            _reportStore = reportStore;
            _modalNavigationStore = modalNavigationStore;
        }
        public override async Task ExecuteAsync(object? parameter)
        {
            ReportDetailsFormVM formVM = _editReportVM.ReportDetailsFormVM;

            Report report = new Report(
                _editReportVM.ReportId,
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

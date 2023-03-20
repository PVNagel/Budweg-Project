using BudwegErrorLoggingSystem.Models;
using BudwegErrorLoggingSystem.Persistens;
using BudwegErrorLoggingSystem.Stores;
using BudwegErrorLoggingSystem.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudwegErrorLoggingSystem.Commands
{
    public class AddReportCommand : AsyncCommandBase
    {
        private readonly ModalNavigationStore _modalNavigationStore;
        private readonly AddReportVM _addReportVM;
        private readonly ReportStore _reportStore;
        private readonly ErrorReportRepo _errorReportRepo;

        public AddReportCommand(AddReportVM addReportVM, ReportStore reportStore, ModalNavigationStore modalNavigationStore)
        {
            _addReportVM = addReportVM;
            _reportStore = reportStore;
            _modalNavigationStore = modalNavigationStore;

            _errorReportRepo = new ErrorReportRepo();


        }
        public override async Task ExecuteAsync(object? parameter)
        {

            ReportDetailsFormVM formVM = _addReportVM.ReportDetailsFormVM;

            Report report = new Report(
                Guid.NewGuid(),
                formVM.Report, 
                formVM.ErrorMessage, 
                formVM.IsResolved);

            try
            {
                _errorReportRepo.Save(report);

                await _reportStore.Add(report);

                _modalNavigationStore.Close();
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}

﻿using BudwegErrorLoggingSystem.Models;
using BudwegErrorLoggingSystem.Stores;
using BudwegErrorLoggingSystem.ViewModels;
using System;
using System.Collections.Generic;
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

        public AddReportCommand(AddReportVM addReportVM, ReportStore reportStore, ModalNavigationStore modalNavigationStore)
        {
            _addReportVM = addReportVM;
            _reportStore = reportStore;
            _modalNavigationStore = modalNavigationStore;
        }
        public override async Task ExecuteAsync(object? parameter)
        {
            ReportDetailsFormVM formVM = _addReportVM.ReportDetailsFormVM;

            Report report = new Report(
                formVM.Report, 
                formVM.ErrorMessage, 
                formVM.IsResolved);

            try
            {
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
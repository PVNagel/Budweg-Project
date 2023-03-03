using System;
using BudwegErrorLoggingSystem.Stores;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BudwegErrorLoggingSystem.Models;

namespace BudwegErrorSystem.ViewModels
{
    public class ReportDetailsVM : ViewModelBase
    {
        private readonly SelectedReportStore _selectedReportStore;

        private Report SelectedReport => _selectedReportStore.SelectedReport;

        public bool HasSelectedReport => SelectedReport!= null;
        public string Report => SelectedReport?.ReportDisplay ?? "Unknown";
        public string ErrorMessageDisplay => SelectedReport?.ErrorMessage ?? "Unknown";
        public string IsResolved => (SelectedReport?.IsResolved ?? false) ? "Yes" : "No";

        public ReportDetailsVM(SelectedReportStore selectedReportStore)
        {
            _selectedReportStore = selectedReportStore;

            _selectedReportStore.SelectedReportChanged += _selectedReportStore_SelectedReportChanged;
        }

        protected override void Dispose()
        {
            _selectedReportStore.SelectedReportChanged += _selectedReportStore_SelectedReportChanged;

            base.Dispose();
        }

        private void _selectedReportStore_SelectedReportChanged()
        {
            OnPropertyChanged(nameof(HasSelectedReport));
            OnPropertyChanged(nameof(Report));
            OnPropertyChanged(nameof(ErrorMessageDisplay));
            OnPropertyChanged(nameof(IsResolved));
        }
    }
}

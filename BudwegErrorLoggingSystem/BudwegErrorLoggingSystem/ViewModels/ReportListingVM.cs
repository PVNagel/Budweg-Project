using System;
using BudwegErrorLoggingSystem.Stores;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BudwegErrorLoggingSystem.Models;
using System.Windows.Input;
using BudwegErrorLoggingSystem.Commands;

namespace BudwegErrorLoggingSystem.ViewModels
{
    public class ReportListingVM : ViewModelBase
    {
        private readonly ReportStore _reportStore;
        private readonly SelectedReportStore _selectedReportStore;
        private readonly ModalNavigationStore _modalNavigationStore;

        private readonly ObservableCollection<ReportListingItemVM> _reportListingItemVMs;

        public IEnumerable<ReportListingItemVM> ReportListingItemVMs => _reportListingItemVMs;

        private ReportListingItemVM _selectedReportListingItemVM;
        public ReportListingItemVM SelectedReportListingItemVM
        {
            get
            {
                return _selectedReportListingItemVM;
            }
            set
            {
                _selectedReportListingItemVM = value;
                OnPropertyChanged(nameof(SelectedReportListingItemVM));

                _selectedReportStore.SelectedReport = _selectedReportListingItemVM?.Report; 
            }
        }
        public ReportListingVM(ReportStore reportStore, SelectedReportStore selectedReportStore, ModalNavigationStore modalNavigationStore)
        {
            _reportStore = reportStore;
            _selectedReportStore = selectedReportStore;
            _modalNavigationStore = modalNavigationStore;
            _reportListingItemVMs = new ObservableCollection<ReportListingItemVM>();

            _reportStore.ReportAdded += ReportStore_ReportAdded;          
        }

        protected override void Dispose()
        {
            _reportStore.ReportAdded -= ReportStore_ReportAdded;

            base.Dispose();
        }

        private void ReportStore_ReportAdded(Report report)
        {
            AddReport(report);
        }

        private void AddReport(Report report)
        {
            ICommand editCommand = new OpenEditReportCommand(report, _modalNavigationStore);
            _reportListingItemVMs.Add(new ReportListingItemVM(report, editCommand));
        }
    }
}
;
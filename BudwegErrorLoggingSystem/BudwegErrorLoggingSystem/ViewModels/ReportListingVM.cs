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
using BudwegErrorLoggingSystem.Persistens;

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

            var repo = new ErrorReportRepo();

            var reports = repo.GetAll();
            foreach(var report in reports)
            {
                _reportListingItemVMs.Add(new ReportListingItemVM(report, _reportStore, _modalNavigationStore));

            }

            _reportStore.ReportAdded += ReportStore_ReportAdded;
            _reportStore.ReportUpdated += ReportStore_ReportUpdated;
        }

        protected override void Dispose()
        {
            _reportStore.ReportAdded -= ReportStore_ReportAdded;
            _reportStore.ReportUpdated -= ReportStore_ReportUpdated;

            base.Dispose();
        }

        private void ReportStore_ReportAdded(Report report)
        {
            AddReport(report);
        }
        private void ReportStore_ReportUpdated(Report report)
        {
            ReportListingItemVM reportVM =
                _reportListingItemVMs.FirstOrDefault(y => y.Report.Id == report.Id);

            if (reportVM != null)
            {
                reportVM.Update(report);
            }
        }

        private void AddReport(Report report)
        {
            ReportListingItemVM itemViewModel =
               new ReportListingItemVM(report, _reportStore, _modalNavigationStore);
            _reportListingItemVMs.Add(itemViewModel);
        }
    }
}
;
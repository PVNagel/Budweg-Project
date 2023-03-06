using System;
using BudwegErrorLoggingSystem.Stores;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BudwegErrorLoggingSystem.Models;

namespace BudwegErrorLoggingSystem.ViewModels
{
    public class ReportListingVM : ViewModelBase
    {

        private readonly ObservableCollection<ReportListingItemVM> _reportListingItemVMs;

        private readonly SelectedReportStore _selectedReportStore;

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

                _selectedReportStore.SelectedReport = _selectedReportListingItemVM.Report; //selectedReportListingItemVM?
            }
        }

        public ReportListingVM(SelectedReportStore selectedReportStore)
        {
            _selectedReportStore = selectedReportStore;
            _reportListingItemVMs = new ObservableCollection<ReportListingItemVM>();

            _reportListingItemVMs.Add(new ReportListingItemVM(new Report("Fejl kode 22", "Skrue løs", true)));
            _reportListingItemVMs.Add(new ReportListingItemVM(new Report("Fejlk kode 46","Forkert kasse", false)));
            _reportListingItemVMs.Add(new ReportListingItemVM(new Report("Bla bla", "blø blø", false)));
           
        }
    }
}
;
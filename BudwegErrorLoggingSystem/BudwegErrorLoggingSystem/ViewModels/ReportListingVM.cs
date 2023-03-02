using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudwegErrorSystem.ViewModels
{
    public class ReportListingVM : ViewModelBase
    {

        private readonly ObservableCollection<ReportListingItemVM> _reportListingItemVMs;
        public IEnumerable<ReportListingItemVM> ReportListingItemVMs => _reportListingItemVMs;

        public ReportListingVM()
        {
            _reportListingItemVMs= new ObservableCollection<ReportListingItemVM>();

            _reportListingItemVMs.Add(new ReportListingItemVM("Skrue Løs"));
            _reportListingItemVMs.Add(new ReportListingItemVM("Skæv vinkel"));
            _reportListingItemVMs.Add(new ReportListingItemVM("Bla bla"));
        }
    }
}
;
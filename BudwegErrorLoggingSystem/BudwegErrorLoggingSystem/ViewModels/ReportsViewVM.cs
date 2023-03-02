using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BudwegErrorSystem.ViewModels
{
    public class ReportsViewVM : ViewModelBase
    {
        public ReportListingVM ReportListingVM { get; }
        public ReportDetailsVM ReportDetailsVM { get; }

        public ICommand AddReportCommand { get; }

        public ReportsViewVM()
        {
            ReportListingVM= new ReportListingVM();
            ReportDetailsVM= new ReportDetailsVM();
        }
    }
}

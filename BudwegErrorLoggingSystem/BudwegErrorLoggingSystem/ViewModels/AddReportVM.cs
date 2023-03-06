using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudwegErrorLoggingSystem.ViewModels
{
    public class AddReportVM : ViewModelBase
    {
        public ReportDetailsFormVM ReportDetailsFormVM { get; }

        public AddReportVM()
        {
            ReportDetailsFormVM= new ReportDetailsFormVM();
        }
    }
}

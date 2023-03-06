using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudwegErrorLoggingSystem.ViewModels
{
    public class EditReportVM : ViewModelBase
    {
        public ReportDetailsFormVM ReportDetailsFormVM { get; }

        public EditReportVM()
        {
            ReportDetailsFormVM = new ReportDetailsFormVM();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudwegErrorSystem.ViewModels
{
    public class ReportDetailsVM : ViewModelBase
    {
        public string Report { get; }
        public string ErrorMessageDisplay { get; }
        public string ReasonDisplay { get; }

        public ReportDetailsVM()
        {
            Report = "Fejlkode 22";
            ErrorMessageDisplay = "Forkert kasse";
            ReasonDisplay = "Forkert kasse";
        }
    }
}

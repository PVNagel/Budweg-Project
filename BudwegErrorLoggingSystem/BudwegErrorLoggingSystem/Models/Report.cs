using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudwegErrorLoggingSystem.Models
{
    public class Report
    {
        public string ReportDisplay { get; }
        public string ErrorMessage { get; }
        public bool IsResolved { get; }

        public Report(string reportDisplay, string errorMessage, bool isResolved)
        {
            ReportDisplay = reportDisplay;
            ErrorMessage = errorMessage;
            IsResolved = isResolved;
        }
    }
}

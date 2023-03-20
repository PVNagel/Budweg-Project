using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudwegErrorLoggingSystem.Models
{
    public class Report
    {
        public int Id { get; }
        public string ReportDisplay { get; }
        public string ErrorMessage { get; }
        public bool IsResolved { get; }

        public Report() { }

        public Report(ErrorReport errorReport)
        {
            Id = errorReport.ErrorReportID;
            ReportDisplay = errorReport.ErrorCode;
            ErrorMessage = errorReport.ErrorDescription;
            IsResolved = errorReport.IsResolved;
        }

        public Report(int id, string reportDisplay, string errorMessage, bool isResolved)
        {
            Id = id;
            ReportDisplay = reportDisplay;
            ErrorMessage = errorMessage;
            IsResolved = isResolved;
        }
        public Report(string reportDisplay, string errorMessage, bool isResolved)
        {
            ReportDisplay = reportDisplay;
            ErrorMessage = errorMessage;
            IsResolved = isResolved;
        }
    }
}

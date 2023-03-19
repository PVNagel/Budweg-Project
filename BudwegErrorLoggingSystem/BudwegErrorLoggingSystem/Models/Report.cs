using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudwegErrorLoggingSystem.Models
{
    public class Report
    {
        public Guid Id { get; }
        public string ReportDisplay { get; }
        public string ErrorMessage { get; }
        public bool IsResolved { get; }

        public Report(Guid id, string reportDisplay, string errorMessage, bool isResolved)
        {
            Id = id;
            ReportDisplay = reportDisplay;
            ErrorMessage = errorMessage;
            IsResolved = isResolved;
        }
    }
}

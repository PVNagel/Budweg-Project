using BudwegErrorLoggingSystem.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudwegErrorLoggingSystem.Models
{
    public class ErrorReport
    {
        public int ReportId { get; set; }

        public string ErrorType { get; set; }

        public string ErrorDescription { get; set; }

        public int WorkerId { get; set; }

        public int InspectorId { get; set; }
        public ErrorReport() { }

        public ErrorReport(int reportId, string errorType, string errorDescription, int workerId, int inspectorId)
        {
            ReportId = reportId;
            ErrorType = errorType;
            ErrorDescription = errorDescription;
            WorkerId = workerId;
            InspectorId = inspectorId;
        }
    }
}

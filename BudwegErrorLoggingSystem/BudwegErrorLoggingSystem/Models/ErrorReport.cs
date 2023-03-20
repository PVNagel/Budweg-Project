using BudwegErrorLoggingSystem.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BudwegErrorLoggingSystem.Models
{
    public class ErrorReport
    {
        public int ErrorReportID { get; set; }
        public string ErrorCode { get; set; }
        public string ErrorType { get; set; }
        public string ErrorDescription { get; set; }
        public bool IsResolved { get; set; } 
        public int WorkerId { get; set; }
        public int InspectorId { get; set; }  
        
        public ErrorReport() { }

        public ErrorReport(Report report)
        {
            ErrorReportID = report.Id;
            ErrorCode = report.ReportDisplay;
            ErrorDescription = report.ErrorMessage;
            IsResolved = report.IsResolved;
        }

        public ErrorReport(int errorReportID, string errorCode, string errorType, 
            string errorDescription, bool isResolved, int workerId, int inspectorId)
        {
            ErrorReportID = errorReportID;
            ErrorCode = errorCode;
            ErrorType = errorType;
            ErrorDescription = errorDescription;
            IsResolved = isResolved;
            WorkerId = workerId;
            InspectorId = inspectorId;
        }
    }
}

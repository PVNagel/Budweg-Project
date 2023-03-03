using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudwegErrorLoggingSystem.Models
{
    public class ErrorReport
    {
        public int Id { get; set; }

        public string ErrorType { get; set; }

        public string ErrorDescription { get; set; }

        public int WorkerID { get; set; }

        public int InspectorID { get; set; }
        public ErrorReport() { }

        public ErrorReport(int reportID, string errorType, string errorDescription, int workerID, int inspectorID)
        {
            ReportID = reportID;
            ErrorType = errorType;
            ErrorDescription = errorDescription;
            WorkerID = workerID;
            InspectorID = inspectorID;
        }
    }
}

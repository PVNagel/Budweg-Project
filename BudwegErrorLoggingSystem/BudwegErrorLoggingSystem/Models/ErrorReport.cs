using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudwegErrorLoggingSystem.Models
{
    public class ErrorReport :Worker :Inspector
    {
        public int ReportID { get; set; }

        public string ErrorType { get; set; }

        public string ErrorDescription { get; set; }

        public ErrorReport() { }

        public ErrorReport(int RaportID, string ErrorType, string ErrorDescription, int WorkerID, int InspectorID)

        RaportID = raportID;
        ErrorType = errorType;
        ErrorDescription = errorDescription;
        WorkerID = workerID;
        InspectorID = inspectorID;
    }
}

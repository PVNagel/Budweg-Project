using BudwegErrorLoggingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudwegErrorLoggingSystem.Persistens
{
    public class ErrorReportRepository
    {
        public List<ErrorReport> errorReports = new List<ErrorReport>();

        public List<ErrorReport> GetAll()
        {
            return errorReports;
        }
        public void Add(ErrorReport errorReport)
        {
            errorReports.Add(errorReport);
        }
        public ErrorReport Get(int Id)
        {
            ErrorReport result = null;

            foreach(ErrorReport errorReport in errorReports)
            {
                if (errorReport.Id == Id)
                {
                    result = errorReport;
                    break;
                }
            }
            return result;
        }
        public void Remove(int id)
        {
            errorReports.RemoveAt(id);

            foreach (ErrorReport errorReport in errorReports)
            {
                if (errorReport.Id == id)

                    errorReports.Remove(errorReport);
                break;
            }
        }
        public void Update(int id, string errorType, string errorDescription, int workerID, int inspectorID)
        {
            foreach(ErrorReport errorReport in errorReports)
            {
                if(errorReport.Id == id)
                {
                    errorReport.ErrorType = errorType;
                    errorReport.ErrorDescription = errorDescription;
                    errorReport.WorkerID = workerID;
                    errorReport.InspectorID = inspectorID;
                    break;
                }
            }
        }
    }
}

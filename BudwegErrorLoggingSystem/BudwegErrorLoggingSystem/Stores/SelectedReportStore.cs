using BudwegErrorLoggingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudwegErrorLoggingSystem.Stores
{
    public class SelectedReportStore
    {
        private readonly ReportStore _reportStore;

        private Report _selectedReport;
        public Report SelectedReport
        {
            get 
            { 
                return _selectedReport; 
            }
            set 
            { 
                _selectedReport = value;
                SelectedReportChanged?.Invoke();
            }
        }

        public event Action SelectedReportChanged; 

        public SelectedReportStore(ReportStore reportStore)
        {
            _reportStore = reportStore;

            _reportStore.ReportUpdated += ReportStore_ReportUpdated;
        }

        private void ReportStore_ReportUpdated(Report report)
        {
            if (report.Id == SelectedReport?.Id)
            {
                SelectedReport = report; 
            }
        }
    }
}

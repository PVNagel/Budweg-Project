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
    }
}

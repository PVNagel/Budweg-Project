using BudwegErrorLoggingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudwegErrorLoggingSystem.Stores
{
    public class ReportStore
    {
        public event Action<Report> ReportAdded;

        public async Task Add(Report report)
        {
            ReportAdded?.Invoke(report);
        }
    }
}

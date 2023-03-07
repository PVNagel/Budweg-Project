using BudwegErrorLoggingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BudwegErrorLoggingSystem.ViewModels
{
    public class ReportListingItemVM : ViewModelBase
    {
        public Report Report { get; }

        public string ErrorMessage => Report.ErrorMessage;

        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }


        public ReportListingItemVM(Report report, ICommand editCommand)
        {
            Report = report;
            EditCommand = editCommand;
        }
    }
}

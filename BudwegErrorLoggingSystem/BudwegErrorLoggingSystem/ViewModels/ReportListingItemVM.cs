using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BudwegErrorSystem.ViewModels
{
    public class ReportListingItemVM : ViewModelBase
    {
        public string ErrorMessage { get; }

        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }


        public ReportListingItemVM(string errorMessage)
        {
            ErrorMessage = errorMessage;
        }
    }
}

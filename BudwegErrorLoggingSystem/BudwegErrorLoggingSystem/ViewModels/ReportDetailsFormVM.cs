using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BudwegErrorLoggingSystem.ViewModels
{
    public class ReportDetailsFormVM : ViewModelBase
    {
        private string _report;

        public string Report
        {
            get
            {
                return _report;
            }
            set
            {
                _report = value;
                OnPropertyChanged(nameof(Report));
                OnPropertyChanged(nameof(CanSubmit));
            }
        }

        private string _errorMessage;
        public string ErrorMessage
        {
            get
            {
                return _errorMessage;
            }
            set
            {
                _errorMessage = value;
                OnPropertyChanged(nameof(ErrorMessage));
            }
        }

        private bool _isResolved;
        public bool IsResolved
        {
            get
            {
                return _isResolved;
            }
            set
            {
                _isResolved = value;
                OnPropertyChanged(nameof(IsResolved));
            }
        }

        public bool CanSubmit => !string.IsNullOrEmpty(Report);

        public ICommand SubmitCommand { get; }
        public ICommand CancelCommand { get; }
    }
}

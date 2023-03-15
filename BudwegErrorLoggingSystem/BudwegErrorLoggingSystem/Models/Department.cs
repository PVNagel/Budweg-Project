using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudwegErrorLoggingSystem.Models
{
    public class Department
    {
        public string Storrage { get; set; }

        public string Production { get; set; }

        public ProductionMachine Machine  { get; set; }

        public StorageMachine Machine1 { get; set; }
    }
}

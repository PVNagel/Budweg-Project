using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudwegErrorLoggingSystem.Models
{
    public class Inspector: Person
    {
        public int InspectorId { get; set; }

        public Inspector() { }

        public Inspector(int inspectorId)
        {
            InspectorId = inspectorId;
        }
    }
}

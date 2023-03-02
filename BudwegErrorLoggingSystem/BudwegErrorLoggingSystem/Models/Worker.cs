using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudwegErrorLoggingSystem.Models
{
    // Worker class
    public class Worker : Person
    {
        public int WorkerID { get; set; }

        public Worker() { }
        public Worker (int workerID, string name, int phoneNumber, string email)
        {
            WorkerID = workerID;
            Name = name;
            Phonenumber = phoneNumber;
            Email = email;
        }
        
    }
}

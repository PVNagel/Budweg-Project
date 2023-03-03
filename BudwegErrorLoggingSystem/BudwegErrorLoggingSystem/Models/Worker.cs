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
        public int Id { get; set; }

        public Worker() { }
        public Worker(int workerId, string name, int phoneNumber, string email)
        {
            Id = workerId;
            Name = name;
            Phonenumber = phoneNumber;
            Email = email;
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudwegErrorLoggingSystem.Models
{
    public class Leader: Person
    {
        public int Id { get; set; }

        public Leader() { }

        public Leader(int leaderId, string name, int phoneNumber, string email)
        {
            Id = leaderId;
            Name = name;
            Phonenumber = phoneNumber;
            Email = email;
        }
    }
}

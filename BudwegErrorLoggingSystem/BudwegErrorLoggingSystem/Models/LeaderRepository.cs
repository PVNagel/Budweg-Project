using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudwegErrorLoggingSystem.Models
{
    public class LeaderRepository
    {
        public List<Leader> leaders = new List<Leader>();

        public List<Leader> GetAll()
        {
            return leaders;
        }
        public void Add(Leader leader)
        {
            leaders.Add(leader);
        }
        public Leader Get(int Id)
        {
            Leader result = null;

            foreach(Leader leader in leaders)
            {
                if(leader.Id == Id)
                
                    result = leader;
                break;
            }
            return result;
        }
        public void Remove(int Id)
        {
            leaders.RemoveAt(Id);

            foreach(Leader leader in leaders)
            {
                if(leader.Id == Id)
                {
                    leaders.Remove(leader);
                    break;
                }
            }
        }
        public void Update(int Id, string name, int phonenumber, string email)
        {
            foreach(Leader leader in leaders)
            {
                if(leader.Id == Id)
                {
                    leader.Name = name;
                    leader.Phonenumber = phonenumber;
                    leader.Email = email;
                    break;
                }
            }
        }
    }
}

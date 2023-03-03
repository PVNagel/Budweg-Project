using BudwegErrorLoggingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudwegErrorLoggingSystem.Persistens
{
    public class InspectorRepository
    {
        public List<Inspector> inspectors = new List<Inspector>();

        public List<Inspector> GetAll()
        {
            return inspectors;
        }

        public void Add(Inspector inspector)
        {
            inspectors.Add(inspector);
        }


        public Inspector Get(int id)
        {
            Inspector result = null;

            foreach (Inspector inspector in inspectors)
            {
                if (inspector.Id == id)
                {
                    result = inspector;
                    break;
                }
            }
            return result;
        }
        public void Remove(int id)
        {
            inspectors.RemoveAt(id);

            foreach (Inspector inspector in inspectors)
            {
                if (inspector.Id == id)
                {
                   inspectors.Remove(inspector);
                   break;
                }
            }
        }
        public void Update(int id, string name, string email, int phoneNumber)
        {
            foreach (Inspector inspector in inspectors)
            {
                if (inspector.Id == id)
                {
                    inspector.Name = name;
                    inspector.Email = email;
                    inspector.Phonenumber = phoneNumber;
                    break;
                }
            }
        }
    }
}

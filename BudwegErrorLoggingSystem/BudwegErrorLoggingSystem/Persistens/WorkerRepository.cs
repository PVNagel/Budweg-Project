using BudwegErrorLoggingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace BudwegErrorLoggingSystem.Persistens
{
    public class WorkerRepository
    {
        public List<Worker> workers = new List<Worker>();

        public List<Worker> GetAll()
        {
            return workers;
        }
        public void Add(Worker worker)
        {
            workers.Add(worker);
        }
        public Worker Get(int id)
        {
            Worker result = null;

            foreach(Worker worker in workers)
            {
                if(worker.Id == id)
                    result = worker;
                break;
            }
            return result;
        }
        public void Remove(int id)
        {
            workers.RemoveAt(id);

            foreach(Worker worker in workers)
            {
                if (worker.Id == id)
                {
                    workers.Remove(worker);
                    break;
                }
            }
        }
        public void Update(int id, string name, int phonenumber, string email)
        {
            foreach(Worker worker in workers)
            {
                if(worker.Id == id)
                {
                    worker.Name = name;
                    worker.Phonenumber = phonenumber;
                    worker.Email = email;
                    break;
                }
            }    
        }
    }
}

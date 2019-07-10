using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_Demo.Model
{
    public class Department
    {
        public string name { get; set; }
        public int code { get; set; }
        public string location { get; set; }
        public int phoneExtension { get; set; }
        public double budget { get; set; }
        public List<Employee> staff { get; set; }
        public Employee chief { get; set; }

        public void addEmployee(Employee e)
        {
            if(staff == null)
            {
                staff = new List<Employee>();
            } 
            staff.Add(e);
        }

        public void removeEmployee(Employee e)
        {
            staff.Remove(e);
        }

        public void removeEmployee(long id)
        {
            staff.Remove(staff.Find(e => e.id == id));
        }

        public void listAllEmployees()
        {
            Console.WriteLine("\n------------------");
            foreach(Employee e in staff)
            {
                e.printState();
            }
            Console.WriteLine("\n------------------");
        }

        public int sizeOfEmployees()
        {
            return staff.Count;
        }

        public Employee getEmployee(long id)
        {
            return staff.Find(e => e.id == id);
        }
    }
}

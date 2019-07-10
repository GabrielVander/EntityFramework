using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_Demo.Model
{
    public class Employee
    {
        public string name { get; set; }
        public long id { get; set; }
        public double salary { get; set; }
        public string jobTitle { get; set; }
        public Department dept { get; set; }    
        public Department deptInCharge { get; set; }

        public void printState()
        {
            Console.WriteLine("\nName: {0}\nID: {1}\nSalary: {2}\nJob title: {3}\n" +
                "Department: {4}\nIn charge of: {5}", 
                name, id, salary, jobTitle, dept, deptInCharge);
        }

        public void getAnnualSalary()
        {
            Console.WriteLine("\nAnnual salary: {0}", salary * 12);
        }
    }
}

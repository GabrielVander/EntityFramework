using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity_Framework_Demo.DAO;
using Entity_Framework_Demo.EntityConfigurations;
using Entity_Framework_Demo.Model;

namespace Entity_Framework_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var dep = new Department
            {
                name = "Phantom Troupe",
                budget = 123456,
                phoneExtension = 16,
                location = "Japan",
                chief = new Employee
                {
                    name = "Hisoka",
                    salary = 12345,
                    jobTitle = "Hunter",
                },
            };


            var dao = new DepartmentDAO();
            dao.Add(dep);

            new EmployeeDAO().Add(new Employee
                {
                    name = "Kurapika",
                    salary = 123456.00,
                    dept = new Department
                    {
                        name = "Kurta Clan",
                        location = "Japan",
                        budget = 1231213,
                        phoneExtension = 17,
                    },
                    jobTitle = "Hunter",
                }
            );

            /*                              [DEPARTMENTS]
             * ___________________________________________________________________________
             * code     name        location    phoneExtension       budget       chiefId
             * ___________________________________________________________________________
             * 7	Kurta Clan	      Japan	          17	        1231213.0	     -
             * 6	Phantom Troupe	  Japan	          16	        123456.0	    10
             * 
             * <----------------------------------------------------------------------------------->
             * 
             *                              [EMPLOYEES]
             * __________________________________________________________________________________
             * id     name        salary        jobTitle       dept_Code       deptInCharge_code
             * __________________________________________________________________________________
             * 10	Hisoka	      12345.0	     Hunter	          -	                    -
             * 11	Kurapika	  123456.0	     Hunter	          7	                    -
             * 
             * 
             * 
             * 
             */

        }
    }
}

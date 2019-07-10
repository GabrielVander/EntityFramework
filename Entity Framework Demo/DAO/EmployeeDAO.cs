using Entity_Framework_Demo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_Demo.DAO
{
    public class EmployeeDAO : GenericDAO<Employee>
    {
        // The GenericDAO class already has every method we need to persist a Employee object on the database
        // If we needed something else though, like a new implementation of Add, it would be here.
    }
}

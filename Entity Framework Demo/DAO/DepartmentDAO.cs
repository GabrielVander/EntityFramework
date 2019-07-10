using Entity_Framework_Demo.EntityConfigurations;
using Entity_Framework_Demo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_Demo.DAO
{
    class DepartmentDAO : GenericDAO<Department>
    {
       // The GenericDAO class already has every method we need to persist a Department object on the database
       // If we needed something else though, like a new implementation of Add or a method to return all employees, it would be here.

    }
}

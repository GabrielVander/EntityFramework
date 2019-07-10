using Entity_Framework_Demo.Model;
using System.Data.Entity.ModelConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_Demo.EntityConfigurations
{
    public class DepartmentConfiguration : EntityTypeConfiguration<Department>
    {
        public DepartmentConfiguration()
        {
            HasKey(d => d.code);
        }
    }
}

using System;
using System.Data.Entity;
using System.Linq;

namespace MvcPureHtml.Models
{
    public class CompanyModel : DbContext
    {

        public CompanyModel()
            : base("name=CompanyModel")
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Department> Departments { get; set; }

    }

}
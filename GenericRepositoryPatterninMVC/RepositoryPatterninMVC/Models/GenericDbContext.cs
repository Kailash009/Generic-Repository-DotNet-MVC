using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RepositoryPatterninMVC.Models
{
    public class GenericDbContext:DbContext
    {
        public GenericDbContext():base("DBCS")
        {
            
        }
        public DbSet<Employee> Employees { get; set; }  // ALL CRUD Operation
        public DbSet<Student> Students { get; set; }  // ALL CRUD Operation
    }
}
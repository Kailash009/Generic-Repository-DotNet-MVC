using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RepositoryPatterninMVC.Models
{
    public class Employee
    {
        [Key]
        public int Eid { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string MobileNo { get; set; }
        public int Salary { get; set; }
    }
}
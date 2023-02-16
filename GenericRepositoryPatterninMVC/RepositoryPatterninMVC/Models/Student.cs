using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RepositoryPatterninMVC.Models
{
    public class Student
    {
        [Key]
        public int Sid { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string MobileNo { get; set; }
        public int Fees { get; set; }
    }
}
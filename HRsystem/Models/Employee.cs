using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HRsystem.Models
{
    public class Employee
    {

        public int ID { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public int number { get; set; }
        public bool gender { get; set; }
        public int MyProperty { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public Double salary { get; set; }
        public Double expsalary { get; set; }
        public DateTime hiredate { get; set; }
        public string image { get; set; }
       [ForeignKey("cnt")]
        public int country_id { get; set; }
        [ForeignKey("cty")]
        public int city_id { get; set; }
        [ForeignKey("dept")]
        public int Department_id { get; set; }

        [NotMapped]
        public int gnd { get; set; }


        public Country cnt { get; set; }
        public City cty { get; set; }
        public Department dept { get; set; }

    }
}
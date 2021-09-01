using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRsystem.Models
{
    public class Country
    {

        public int ID { get; set; }
        public string name { get; set; }

       
        public List<Employee> emp { get; set; }
        public List<City> cty { get; set; }

    }
}
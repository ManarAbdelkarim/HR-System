using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRsystem.Models
{
    public class VMEmp
    {
        public Employee emp { get; set; }
        public Country cnt { get; set; }
        public City cty { get; set; }
        public Department dept { get; set; }

        public List<Department> listdept { get; set; }
        public List<Country> listCountry { get; set; }
        public List<City> listCity { get; set; }
        public List<Employee> listEmployee { get; set; }

        
           
    }
}
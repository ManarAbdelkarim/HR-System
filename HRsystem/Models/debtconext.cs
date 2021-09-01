using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace HRsystem.Models
{
    public class debtconext : DbContext
    {
        public debtconext (): base("name = HRSystems")
        {


        }
        public virtual DbSet <Employee> Emp { get; set; }
        public virtual DbSet<Department> Dept { get; set; }
        public virtual DbSet<Country> Cnt { get; set; }
        public virtual DbSet<City> Cty { get; set; }

    }
}
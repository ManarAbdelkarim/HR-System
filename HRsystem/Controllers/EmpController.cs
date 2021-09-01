using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRsystem.Models;
namespace HRsystem.Controllers
{
    public class EmpController : Controller
    {
        // GET: Emp
        VMEmp vmobj = new VMEmp();
        Employee obj = new Employee();
        debtconext context = new debtconext();
        public ActionResult Index()
        {
            vmobj.listCity = FillCity();
            vmobj.listCountry = Fillcountry();
            vmobj.listdept = filldepartments();


            return View("HRemp", vmobj);
        }

        private List<City> FillCity()
        {
            City obj = new City();
            var x = from c in context.Cty
                    select c;
            List<City> lic = new List<City>();
            foreach (var item in x) {
                obj.ID = item.ID;
                obj.name = item.name;
                lic.Add(obj);
            }

            return lic;

        }

        private List<Country> Fillcountry()
        {
            Country obj = new Country();
            var x = from c in context.Cnt
                    select c;
            List<Country> lic = new List<Country>();
            foreach (var item in x)
            {
                obj.ID = item.ID;
                obj.name = item.name;
                lic.Add(obj);
            }

            return lic;
        }

        private List<Department> filldepartments()
        {

            Department obj = new Department();
            var x = from c in context.Dept
                    select c;
            List<Department> lic = new List<Department>();
            foreach (var item in x)
            {
                obj.ID = item.ID;
                obj.name = item.name;
                lic.Add(obj);
            }

            return lic;


        }


    public ActionResult Save()
       {

      
           

        debtconext context = new debtconext();
        VMEmp vmemp = new VMEmp();
        Employee obj = new Employee();
          

            obj.fname = Request.Form["emp.fname"];
        obj.number = Convert.ToInt32(Request.Form["emp.number"]);
        obj.country_id = Convert.ToInt32(Request.Form["emp.country_id"]);
        obj.address = Request.Form["emp.Address"];
        obj.salary = Convert.ToDouble(Request.Form["emp.salary"]);
        obj.image = Request.Form["emp.image"];
        obj.Department_id = Convert.ToInt32(Request.Form["emp.emp.Department_id"]);
        obj.lname = Request.Form["emp.lname"];
            obj.gnd = Convert.ToInt32(Request.Form["emp.gnd"]);
            if (obj.gnd == 1)
            {
                obj.gender = true;
            }


            obj.city_id = Convert.ToInt32(Request.Form["emp.city_id"]);
        obj.email = Request.Form["emp.email"];
        obj.expsalary = Convert.ToDouble(Request.Form["emp.expsalary"]);
        obj.hiredate = Convert.ToDateTime(Request.Form["Date"]);

        context.Emp.Add(obj);
        context.SaveChanges();

        vmemp.listCountry = Fillcountry();
        vmemp.listCity = FillCity();
        vmemp.listdept = filldepartments();

        return View("EmpSearch", vmemp);
        }

        public ActionResult Search()
        {
         
            vmobj.listEmployee = FillWebgrid();
            return View("EmpSearch", vmobj);
        }
        public List<Employee> FillWebgrid()
        {
            
            List<Employee> liemp = new List<Employee>();

            var name = Request.Form["emp.fname"];
            var liemps = from c in context.Emp
                         where c.fname == name
                         select new
                         {
                             c.fname,
                             c.lname,
                             c.number,
                             c.salary
                         };

            foreach (var item in liemps)
            {
               
                obj.fname = item.fname;
                obj.lname = item.lname;
                obj.number = item.number;
                obj.salary = item.salary;

                liemp.Add(obj);
            }
            return liemp;

        }
        }
}













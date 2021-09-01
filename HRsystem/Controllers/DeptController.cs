using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRsystem.Models;


namespace HRsystem.Controllers
{
    public class DeptController : Controller
    {
        // GET: Dept
        public ActionResult save()
        {
            debtconext context = new debtconext();
            Employee emp = new Employee();

            return View();

        }

        public ActionResult Index()
        {
            return View();
        }
    }
}
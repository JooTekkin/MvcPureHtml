using MvcPureHtml.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcPureHtml.Controllers
{
    public class EmployeeController : Controller
    {
        CompanyModel db;

        public EmployeeController()
        {
            db = new CompanyModel();
        }
        // GET: Employee
        public ActionResult Index()
        {
            var emps = db.Employees.Include(dept => dept.Department).ToList();
            return View(emps);
        }
    }
}
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

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.depts = db.Departments.ToList();
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Employees.Add(employee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }else
            {
                return View();
            }
        }
    }
}
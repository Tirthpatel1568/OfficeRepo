using MVCCrudDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCrudDemo.Controllers
{
    public class EmployeeController : Controller
    {
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.StateId = new SelectList(HrDemoEntities.States, "StateId", "StateName");
            return View();
        }
        //[HttpPost]
        //public ActionResult signup(Employee employee)
        //{
        //    return View();
        //}

      public ActionResult EmpCreate()
    {
      ViewBag.StateId = new SelectList(HrDemoEntities.States, "StateId", "StateName");
      return View("Empcreate");
      }
    [HttpPost]
    public ActionResult EmpCreate(Employee employee)
    {
      if (ModelState.IsValid == true)
      {
        HrDemoEntities.Employees.Add(employee);
        HrDemoEntities.SaveChanges();
        return RedirectToAction("Index");
      }
      else
      {
        return View();
      }
    }
        [HttpPost]
        public ActionResult Create(Employee employee)
        {

            if (ModelState.IsValid == true)
            {
              HrDemoEntities.Employees.Add(employee);
              HrDemoEntities.SaveChanges();
              return RedirectToAction("Index");
            }
            else
            {
              ModelState.AddModelError("Name", "Name Field can not be blank");
              return View();
            }
    }

   
HrDemoEntities HrDemoEntities = new HrDemoEntities();
        [HttpGet]
        // GET: Employee
        public ActionResult Index()
        {
            //List<Employee> employees = new List<Employee>()
            //{
            //    new Employee() { ID=1,Name="Sneha",Address="Ahmedabad",Gender="Female"},
            //    new Employee() { ID=2,Name="Meghna",Address="Mumbai",Gender="Female"},
            //    new Employee() { ID=3,Name="Rahul",Address="Calcutta",Gender="Male"},
            //};
            //TempData["emplist"] = employees;
            //return View(employees);
            
            return View(HrDemoEntities.Employees.ToList<Employee>());


        }
        //[HttpGet]
        //public ActionResult Edit(int id)
        //{
        //    //if (TempData["emplist"] != null)
        //    //{
        //    //    List<Employee> employees = TempData["emplist"] as List<Employee>;
        //    //   Employee employee= employees.Where(d => d.ID == id).SingleOrDefault();
        //    //return View(employee);
        //    //}
        //    //else
        //    //{
        //    //    return RedirectToAction("Index");
        //    //}
           
        //}
        //[HttpPost]
        //public ActionResult Edit(Employee employee)
        //{
        //    //if (TempData["emplist"] != null)
        //    //{

        //    //}
        //    //    return View();
        //}
    }
}
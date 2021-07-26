using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        static IList<Student> studentList = new List<Student>{
                new Student() { StudentId = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentId = 2, StudentName = "Steve",  Age = 21 } ,
                new Student() { StudentId = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentId = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentId = 5, StudentName = "Ron" , Age = 31 } ,
                new Student() { StudentId = 4, StudentName = "Chris" , Age = 17 } ,
                new Student() { StudentId = 4, StudentName = "Rob" , Age = 19 }
            };
        // GET: Student
        public ActionResult Index()
        {
            ViewBag.TotalStudents = studentList.Count();
            ViewData["students"] = studentList;
            return View(studentList);
        }
        //below home action using viewbag returns my custom rensdering iew to understand the concept
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult Edit(int id)
        {
            var std = studentList.Where(s => s.StudentId == id).FirstOrDefault();
            return View(std);
        }
        [HttpPost]
        public ActionResult Edit(Student std)
        {
            bool nameAlreadyExist =false;
            if (ModelState.IsValid)
            {
                var student = studentList.Where(s => s.StudentId == std.StudentId).FirstOrDefault();
                foreach (var item in studentList)
                {
                    if(item.StudentName == std.StudentName)
                    {
                         nameAlreadyExist = true;
                    }
                   

                }
                if (nameAlreadyExist)
                {
                    ModelState.AddModelError("name", "Student Name Already Exist");
                    return View(std);
                }
                else
                {
                    studentList.Remove(student);
                    studentList.Add(std);

                    return RedirectToAction("Index");
                }
            }
            return View(std);
        }

    }
}
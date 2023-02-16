using RepositoryPatterninMVC.Models;
using RepositoryPatterninMVC.Repository.Contract;
using RepositoryPatterninMVC.Repository.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RepositoryPatterninMVC.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        private  IGeneric<Student> _student;
        public StudentController()
        {
            this._student = new GenericService<Student>();
        }
        public StudentController(IGeneric<Student> _student)
        {
            this._student = _student;
        }
        public ActionResult Index()
        {
            var student = _student.GETALL();
            return View(student);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student stuObj)
        {
            _student.Add(stuObj);
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            var student = _student.GetByID(id);
            return View(student);
        }

        [HttpPost]
        public ActionResult Edit(Student stuObj)
        {
            _student.Update(stuObj);
            return RedirectToAction("Index");

        }
        public ActionResult Delete(int id)
        {
            _student.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
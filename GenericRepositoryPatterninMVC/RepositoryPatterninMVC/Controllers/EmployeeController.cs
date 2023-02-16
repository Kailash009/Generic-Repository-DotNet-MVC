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
    public class EmployeeController : Controller
    {
        // GET: Employee
        private IGeneric<Employee> _employee;
        public EmployeeController()
        {
            this._employee = new GenericService<Employee>();
        }
        public EmployeeController(IGeneric<Employee> _employee)
        {
            this._employee = _employee;
        }
        public ActionResult Index()
        {
            var employee=_employee.GETALL();
            return View(employee);
        }
        public ActionResult Create()
        { 
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee empObj)
        {
            _employee.Add(empObj);
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            var employee = _employee.GetByID(id);
            return View(employee);
        }

        [HttpPost]
        public ActionResult Edit(Employee empObj)
        {
            _employee.Update(empObj);
            return RedirectToAction("Index");

        }
        public ActionResult Delete(int id)
        {
            _employee.Delete(id);
            return RedirectToAction("Index");
        }

    }
}







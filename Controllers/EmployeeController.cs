using EmployeeEF.Models;
using EmployeeEF.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeEF.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService service;
         EmployeeController(IEmployeeService service)
        {
            this.service = service;
        }
        // GET: EmployeeController
        public ActionResult Index()
        {
            var model = service.GetAllEmployees();
            return View(model);
        }

        // GET: EmployeeController/Details/5
        public ActionResult Details(int id)
        {
            var model = service.GetEmployeeById(id);
            return View(model);
        }

        // GET: EmployeeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee e)
        {
            try
            {
                int res = service.AddEmployee(e);
                if (res == 1)
                    return RedirectToAction(nameof(Index));
                else
                    return View();
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            var model = service.GetEmployeeById(id);
            return View(model);
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Employee e)
        {
            try
            {
                int res = service.UpdateEmployee(e);
                if (res == 1)
                    return RedirectToAction(nameof(Index));
                else
                    return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            var model = service.GetEmployeeById(id);
            return View(model);
        }

        // POST: EmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
            try
            {
                int res = service.DeleteEmployee(id);
                if (res == 1)
                    return RedirectToAction(nameof(Index));
                else
                    return View();
            }
            catch
            {
                return View();
            }
        }
    }
}

    


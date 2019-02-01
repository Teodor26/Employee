using Employee.Models.DataModels;
using EmployeeMVC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeMVC.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployeApiService _employeeApiService = new EmployeeApiService();
        // GET: Employee
        public async System.Threading.Tasks.Task<ActionResult> List()
        {
            var employess = await _employeeApiService.GetList();
            return View(employess.ToList());
        }
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async System.Threading.Tasks.Task<ActionResult> Add(BaseEmployee employee)
        {
            var employess = await _employeeApiService.GetList();
            
            employess.Add(employee);

            return View("List");
        }

    }
}
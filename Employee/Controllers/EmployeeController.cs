using Employee.BusinessLogic.Services;
using Employee.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Employee.Controllers
{
    public class EmployeeController : ApiController
    {
        public IEmployeeService _employeeService;

        public EmployeeController()
        {
            _employeeService = new EmployeeService();
        }

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var employees = _employeeService.GetList();
            return Ok(employees);
        }
        [HttpPost]
        public IHttpActionResult Add([FromBody]BaseEmployee employee)
        {
            if (string.IsNullOrEmpty(employee.FirstName) ||
                string.IsNullOrEmpty(employee.LastName) ||
                string.IsNullOrEmpty(employee.Title))
                return BadRequest("Wrong input");
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            else
                return Ok();
        }
        public IHttpActionResult Edit(int id, BaseEmployee employee)
        {
            List<BaseEmployee> employees = _employeeService.GetList();
            if (id > employees.Count)
                return BadRequest("Wrong id. Try again");
            else
            {
                employee.Id = id;
                return Ok(employee);
            };
                
        }

        public IHttpActionResult Delete(int id, BaseEmployee employee)
        {

            List<BaseEmployee> employees = _employeeService.GetList();
            if (id > employees.Count)
                return BadRequest("Wrong id. Try again");
            else
            {
                employee.Id = id;
                employees.Remove(employee);
                return Ok(employee);
            };
        }

    }
}

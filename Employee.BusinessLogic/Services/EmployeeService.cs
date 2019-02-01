using Employee.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.BusinessLogic.Services
{
    public interface IEmployeeService
    {
        List<BaseEmployee> GetList();
    }
    public class EmployeeService : IEmployeeService
    {
        public List<BaseEmployee> GetList()
        {
            var employees = new List<BaseEmployee>
           {
               new BaseEmployee
               {
                   Id =1,
                   FirstName = "James",
                   LastName = "Smith",
                   Title = "Postman"
               },
               new BaseEmployee
               {

                   Id =2,
                   FirstName ="Robert",
                   LastName ="Junior",
                   Title = "Senior"
               }
           };
            return employees;
        }
    }
}

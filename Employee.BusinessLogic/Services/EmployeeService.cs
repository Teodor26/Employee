using Employee.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.BusinessLogic.Services
{
    public interface IEmployeeSerice
    {
        List<BaseEmployee> GetList();
    }
    public class EmployeeService : IEmployeeSerice
    {
        public List<BaseEmployee> GetList()
        {
            throw new NotImplementedException();
        }
    }
}

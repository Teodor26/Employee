using Employee.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace EmployeeMVC.Services
{
    public interface IEmployeApiService
    {
        Task<List<BaseEmployee>> GetList();
    }
    public class EmployeeApiService : IEmployeApiService
    {
        public async Task<List<BaseEmployee>> GetList()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:57214");

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            List<BaseEmployee> employees = new List<BaseEmployee>();

            var response = await client.GetAsync("api/employees");

            if (response.IsSuccessStatusCode)
                employees = await response.Content.ReadAsAsync<List<BaseEmployee>>();
            return employees;
        }
    }
}
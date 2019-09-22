using DBLogger.AppRepository;
using DBLogger.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TestApi_App.Controllers
{
    public class TestController : ApiController
    {
        string connectionString = "Data Source=Ajinkya-PC;Initial Catalog=DBLoggerEFModelFirst;User ID=sa;Password=1";

        private ReportManager _reportManager;

        public TestController()
        {
            _reportManager = new ReportManager(connectionString);
        }

        [HttpPost]
        [Route("api/Test/SaveEmployee")]
        public void SaveEmployee(Employee employee)
        {
            _reportManager.InsertEmployee(employee);
        }

        [HttpGet]
        [Route("api/Test/GetEmployees")]
        public IEnumerable<Employee> GetEmployees()
        {
            return _reportManager.GetEmployees();
        }

        [HttpGet]
        [Route("api/Test/GetEmployeeById")]
        public Employee GetEmployeeById(int id)
        {
            return _reportManager.GetEmployeeById(id);
        }

        #region
        //Aniket
        #endregion
    }
}

using DBLogger.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLogger.AppRepository
{
   public class ReportManager
    {
        private readonly MyModelContainer _dbContext;

        public DBManager _dbManager;

        public ReportManager(MyModelContainer db)
        {
            _dbContext = new MyModelContainer();
            _dbManager = new DBManager(db);

        }
        public ReportManager(string connectionString)
        {
            _dbContext = new MyModelContainer(connectionString);
            _dbManager = new DBManager(connectionString);
        }

        public void InsertEmployee(Employee employee)
        {
            _dbManager.EmployeeRepository.SaveEmployee(employee);
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _dbManager.EmployeeRepository.GetEmployees();
        }

        public Employee GetEmployeeById(int id)
        {
            return _dbManager.EmployeeRepository.GetEmployeeById(id);
        }
    }
}

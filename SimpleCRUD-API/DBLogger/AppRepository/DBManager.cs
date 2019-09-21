using DBLogger.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLogger.AppRepository
{
    public class DBManager
    {
        private readonly MyModelContainer _dbContext;

        public EmployeeRepository EmployeeRepository;

        public DBManager(MyModelContainer context)
        {
            _dbContext = new MyModelContainer();
            EmployeeRepository = new EmployeeRepository(context);
        }

        public DBManager(string connectionString)
        {
            _dbContext = new MyModelContainer(connectionString);
            EmployeeRepository = new EmployeeRepository(connectionString);
        }
        

        public void SaveEmployee(Employee employee)
        {
            EmployeeRepository.SaveEmployee(employee);
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return EmployeeRepository.GetEmployees();
        }

        public Employee GetEmployeeById(int id)
        {
            return EmployeeRepository.GetEmployeeById(id);
        }

    }
}

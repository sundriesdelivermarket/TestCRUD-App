using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLogger.DBModel;
using DBLogger.Interface;

namespace DBLogger.AppRepository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly MyModelContainer _dbContext;

        public EmployeeRepository(string connectionString)
        {
            _dbContext = new MyModelContainer(connectionString);
        }
        public EmployeeRepository(MyModelContainer context)
        {
            _dbContext = context;
        }

        public void SaveEmployee(Employee employee)
        {
            _dbContext.Employees.Add(employee);
            Save();
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _dbContext.Employees.ToList();
        }

        public void UpdateEmployee(Employee employee)
        {
            _dbContext.Entry(employee).State = EntityState.Modified;
        }

        public void DeleteEmployee(int id)
        {
            var employee = _dbContext.Employees.Find(id);
            if (employee != null) _dbContext.Employees.Remove(employee);
        }

        public Employee GetEmployeeById(int id)
        {
            return _dbContext.Employees.Find(id);
        }
    }
}

using Domain;
using Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class EmployeeServiceLoggerDecorator : IEmployeeService
    {


        private readonly IEmployeeService _employeeService;


        // kodi qesh
        private List<Employee> _employees = new List<Employee>();

        public EmployeeServiceLoggerDecorator(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }


        public void AddEmployee(Employee employee)
        {
            // loging
            _employeeService.AddEmployee(employee);
        }

        public void DeleteEmployeeById(int id)
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployeeById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}

using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstract
{
   public interface IEmployeeService
    {

        void AddEmployee(Employee employee);
        Employee GetEmployeeById(int id);
        void UpdateEmployee(Employee employee);

        void DeleteEmployeeById(int id);
    }
}

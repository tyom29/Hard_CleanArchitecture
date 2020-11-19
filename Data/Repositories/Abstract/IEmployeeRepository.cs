using Entities;

namespace Data.Repositories.Abstract
{
    public interface IEmployeeRepository
    {
        void AddEmployee(EmployeeEntity employee);
        EmployeeEntity GetEmployeebYiD(int id);
        void UpdateEmployee(EmployeeEntity employee);

        void DeleteEmployeeById(int id);


      
    }
}

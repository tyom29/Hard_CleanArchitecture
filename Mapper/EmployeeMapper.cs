using Domain;
using Entities;
using ViewModels;

namespace Mapper
{

    // adapter pattern
  public static class EmployeeMapper
    {


        public static EmployeeEntity toEntity(this Employee employee)
        {
            return new EmployeeEntity
            {
                Age = employee.Age,
                Name = employee.Name
            };
        }


        public static Employee toDomain(this EmployeeModel employee)
        {
            if (employee==null)
            {
                return null;
            }
            return new Employee
            {
                Age = employee.Age,
                Name = employee.Name
            };
        }
    }
}

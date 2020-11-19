using Mapper;
using Microsoft.AspNetCore.Mvc;
using Services.Abstract;
using ViewModels;

namespace API.Controllers

{

    // Facade pattern


    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

       private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {

            _employeeService = employeeService;
        }

        public void AddEmployee(EmployeeModel employee)
        {
            _employeeService.AddEmployee(employee.toDomain());
        }

    }
}
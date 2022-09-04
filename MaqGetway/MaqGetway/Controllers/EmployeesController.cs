
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MaqGetway.Domain.Entities;
using MaqGetway.Domain.IJsonItem;

namespace MaqGetway.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeRepository _service;

        public EmployeesController(IEmployeeRepository service)
        {
            _service = service;
        }

        //Get
        [HttpGet]
        public IEnumerable<Employee> EmployeeList()
        {
            var productList = _service.GetEmployeeList();
            return productList;

        }

        [HttpGet("{id}")]
        public Employee GetEmployeeById(string id)
        {
            return _service.GetEmployeeById(id);
        }

        [HttpPost]
        public Employee AddEmployee(Employee Employee)
        {
            return _service.AddEmployee(Employee);
        }

        [HttpPut]
        public Employee UpdateEmployee(Employee Employee)
        {
            return _service.UpdateEmployee(Employee);
        }

        [HttpDelete("{id}")]
        public bool DeleteEmployee(string id)
        {
            return _service.DeleteEmployee(id);
        }
    }

 }

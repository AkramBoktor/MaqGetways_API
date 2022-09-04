using MaqGetway.Domain.Entities;
using System.Collections.Generic;

namespace MaqGetway.Domain.IJsonItem
{
    public interface IEmployeeRepository 
    {
        public IEnumerable<Employee> GetEmployeeList();
        public Employee GetEmployeeById(string id);
        public Employee AddEmployee(Employee Employee);
        public Employee UpdateEmployee(Employee Employee);
        public bool DeleteEmployee(string Id);

    }
}

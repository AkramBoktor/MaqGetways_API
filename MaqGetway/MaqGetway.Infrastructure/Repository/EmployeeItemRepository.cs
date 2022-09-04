using Microsoft.EntityFrameworkCore;
using MaqGetway.Domain.Entities;
using MaqGetway.Domain.IJsonItem;
using MaqGetway.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MaqGetway.Infrastructure.Repository
{
    public class EmployeeItemRepository : IEmployeeRepository
    {
        private readonly EmployeeItemContext _dbContext;
        public EmployeeItemRepository(EmployeeItemContext dbContext)
        {
            _dbContext = dbContext;

        }
     

        public Employee AddEmployee(Employee Employee)
        {
            var result = _dbContext.Employees.Add(Employee);
            _dbContext.SaveChanges();
            return result.Entity;
        }


    

        public bool DeleteEmployee(string Id)
        {
            var filteredData = _dbContext.Employees.Where(x => x.Id == Id).FirstOrDefault();
            var result = _dbContext.Remove(filteredData);
            _dbContext.SaveChanges();
            return result != null ? true : false;
        }

      
        public Employee GetEmployeeById(string id)
        {
            return _dbContext.Employees.Where(x => x.Id == id).FirstOrDefault();
        }

        public IEnumerable<Employee> GetEmployeeList()
        {
            return _dbContext.Employees.ToList();
        }

        public Employee UpdateEmployee(Employee Employee)
        {
            var result = _dbContext.Employees.Update(Employee);
            _dbContext.SaveChanges();
            return result.Entity;
        }
    }
}


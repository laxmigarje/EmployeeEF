using EmployeeEF.Models;
using EmployeeEF.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeEF.Services
{
    public class EmployeeService : IEmployeeService

    {
        private readonly IEmployeeRepositary repo;
         EmployeeService(IEmployeeRepositary repo)
        {
            this.repo = repo;
        }

        public int AddEmployee(Employee e)
        {
            throw new NotImplementedException();
        }

        public int AddStudent(Employee e)
        {
            e.IsActive = 1;
            return repo.AddEmployee(e);
        }

        public int DeleteEmployee(int id)
        {
            return repo.DeleteEmployee(id);
        }

        public List<Employee> GetAllEmployees()
        {
            return repo.GetAllEmployees();
        }

       
        public Employee GetEmployeeById(int id)
        {
            return repo.GetEmployeeById(id);
        }

        
        public int UpdateEmployee(Employee e)
        {
            return repo.UpdateEmployee(e);
        }
    }
}
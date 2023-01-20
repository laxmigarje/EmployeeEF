using EmployeeEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeEF.Services
{
    public interface IEmployeeService
    {
        List<Employee> GetAllEmployees();
        Employee GetEmployeeById(int id);
        int AddEmployee(Employee e);
        int UpdateEmployee(Employee e);
        int DeleteEmployee(int id);
    }
}

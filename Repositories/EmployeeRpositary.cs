using EmployeeEF.Data;
using EmployeeEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeEF.Repositories
{
    public class EmployeeRpositary : IEmployeeRepositary

    {
        private readonly ApplicationDbContext db;
        public EmployeeRpositary(ApplicationDbContext db)
        {
            this.db = db;
        }
        public int AddEmployee(Employee e)
        {
            db.Employees.Add(e);
            int res = db.SaveChanges();
            return res;
        }

        public int DeleteEmployee(int id)
        {
            int res = 0;
            var e = db.Employees.Where(x => x.Id == id).FirstOrDefault();
            if (e != null)
            {
                e.IsActive = 0;
                res = db.SaveChanges();

            }
            return res;
        }

        public List<Employee> GetAllEmployees()
        {
            var model = (from e in db.Employees
                         where e.IsActive == 1
                         select e).ToList();

            return model;
        }

        public Employee GetEmployeeById(int id)
        {
            var e = db.Employees.Where(x => x.Id == id).FirstOrDefault();
            return e;

        }

        public Employee GetStudentById(int id)
        {
            throw new NotImplementedException();
        }

        public int UpdateEmployee(Employee e)
        {
            int res = 0;
            var x = db.Employees.Where(x => x.Id == e.id).FirstOrDefault();
            if (e != null)
            {
                e.id = e.id;
                e.ename = e.ename;
                e.dept = e.dept;
                e.salary = e.salary;
                e.age = e.age;
                e.gender = e.gender;
                e.password = e.password;
                e.IsActive = 1;
                res = db.SaveChanges();

            }
            return res;
        }
    }
}


    


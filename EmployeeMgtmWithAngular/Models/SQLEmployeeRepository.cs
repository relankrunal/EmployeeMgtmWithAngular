using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeMgtmWithAngular.Models
{
    public class SQLEmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext context;

        public SQLEmployeeRepository(AppDbContext context )
        {
            this.context = context;
        }
        public Employee Add(Employee employee)
        {
            context.Employee.Add(employee);
            context.SaveChanges();
            return employee;
        }

        public Employee Delete(int Id)
        {
            Employee emp = context.Employee.Find(Id);
            if (emp!=null)
            {
                context.Employee.Remove(emp);
                context.SaveChanges();
            }
            return emp;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return context.Employee;
        }

        public Employee GetEmployee(int EmployeeId)
        {

            return context.Employee.Find(EmployeeId);
        }

        public Employee Update(Employee employeeChanges)
        {
            var updatedEmployeeData = context.Employee.Attach(employeeChanges);
            updatedEmployeeData.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();

            return employeeChanges;
        }
    }
}

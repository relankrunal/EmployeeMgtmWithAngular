using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeMgtmWithAngular.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {

        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() {EmployeeId = 1,Name= "Kunal",DepartmentName= "IT", City="ABC", Gender="Male", ProjectName= "ABC", Manager="Karam", Salary=1550000  },

                new Employee() {EmployeeId = 1,Name= "Karam",DepartmentName= "IT", City="ABC", Gender="Female", ProjectName= "ABC", Manager=String.Empty, Salary=5550000 }
            };

        }


        public Employee Add(Employee employee)
        {
            employee.EmployeeId = _employeeList.Max(x => x.EmployeeId) + 1;
            _employeeList.Add(employee);
            return employee;
        }

        public Employee Delete(int Id)
        {
            Employee employee = _employeeList.FirstOrDefault(emp => emp.EmployeeId == Id);
            if (employee != null)
            {
                _employeeList.Remove(employee);
            }
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int EmployeeId)
        {
            return _employeeList.FirstOrDefault(e => e.EmployeeId == EmployeeId);
        }

        public Employee Update(Employee employeeChanges)
        {
            Employee employee = _employeeList.FirstOrDefault(emp => emp.EmployeeId == employeeChanges.EmployeeId);
            if (employee != null)
            {
                employee.Name = employeeChanges.Name;
                employee.Salary = employeeChanges.Salary;
                employee.Gender = employeeChanges.Gender;
                employee.ProjectName = employeeChanges.ProjectName;
                employee.City = employeeChanges.City;
                employee.DepartmentName = employeeChanges.DepartmentName;
                employee.Manager = employeeChanges.Manager;
            }
            return employee;
        }
    }
}

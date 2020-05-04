using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeMgtmWithAngular.Models
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int EmployeeId);
        IEnumerable<Employee> GetAllEmployees();
        Employee Add(Employee employee);
        Employee Update(Employee employeeChanges);
        Employee Delete(int Id);

    }
}

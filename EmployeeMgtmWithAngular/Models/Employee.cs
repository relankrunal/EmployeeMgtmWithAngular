using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeMgtmWithAngular.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public String Name { get; set; }
        public String DepartmentName{ get; set; }
        public String ProjectName { get; set; }
        public String Manager { get; set; }
        public String Gender { get; set; }
        public String City { get; set; }
        public Int32 Salary { get; set; }


    }
}

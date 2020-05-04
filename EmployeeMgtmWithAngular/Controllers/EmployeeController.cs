using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeMgtmWithAngular.Models;
using EmployeeMgtmWithAngular.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeMgtmWithAngular.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public ViewResult Index()
        {
            var model = _employeeRepository.GetAllEmployees();

            return View(model);
        }

        public ViewResult Details()
        {
            EmployeeViewModel homeDetailsViewModel = new EmployeeViewModel()
            {
                Employee = _employeeRepository.GetEmployee(1),
                PageTitle = "Employee Details"
            };


            return View(homeDetailsViewModel);

            //            return "Hello from Home controller!!";
        }
    }
}
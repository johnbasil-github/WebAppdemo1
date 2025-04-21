using Microsoft.AspNetCore.Mvc;
using WebApp.Sales.Data;
using WebApp.Sales.Models;

namespace WebApp.Sales.Controllers
{
    public class EmployeeController : Controller
    {

        private readonly ApplicationDbContext context;

        public EmployeeController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()

        {
            List<Employee> employees = new List<Employee>();

            employees = context.Employees.ToList();

            return View(employees);

        }
        //  Employee employee = new Employee
        //    { 
        //        //Id = 100,
        //        //Name = "John",
        //        //Age = 23,
        //        //Gender = "Male"

        //    }
    }
}

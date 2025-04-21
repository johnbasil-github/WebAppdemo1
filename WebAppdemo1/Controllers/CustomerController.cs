using Microsoft.AspNetCore.Mvc;
using WebApp.Sales.Data;
using WebApp.Sales.Models;

namespace WebApp.Sales.Controllers
{
    public class CustomerController : Controller
    {

        private ApplicationDbContext context;

        public CustomerController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            List<Customers> customerList = new List<Customers>();

            customerList = context.Customers.ToList();

            return View(customerList);
        }

        public IActionResult Details()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Customers customerList)
        {
            context.Customers.Add(customerList);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


        public IActionResult Delete(int id)
    }
}

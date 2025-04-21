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

        public IActionResult Details(int id)
        {
            var person = context.Customers.Find(id);
            return View(person);
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
        {
            var person = context.Customers.Find(id);

            context.Customers.Remove(person);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            var person = context.Customers.Find(id);
            return View(person);
        }


        [HttpPost]
        public IActionResult Edit(Customers customerList)
        {
            context.Customers.Update(customerList);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

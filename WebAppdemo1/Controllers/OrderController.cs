using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp.Sales.Data;
using WebApp.Sales.Models;

namespace WebApp.Sales.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {

        private ApplicationDbContext context;

        public OrderController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {

            List<Orderss> orderList = new List<Orderss>();

            orderList = context.Orderss.Include(x => x.customers).ToList();
            return View(orderList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Orderss orderList)
        {
            context.Orderss.Add(orderList);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            var person = context.Orderss.Find(id);
            return View(person);
        }

        public IActionResult Delete(int id)
        {
            var person = context.Orderss.Find(id);

            context.Orderss.Remove(person);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            var person = context.Orderss.Find(id);
            return View(person);
        }


        [HttpPost]
        public IActionResult Edit(Orderss orderList)
        {
            context.Orderss.Update(orderList);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

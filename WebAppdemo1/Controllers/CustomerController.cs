using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp.Sales.Models;
using WebApp.Services.Repository;

namespace WebApp.Sales.Controllers
{
    public class CustomerController : Controller
    {

        
        private ICustomerRepository _customerRepository;
        public CustomerController(ICustomerRepository repository)
        {
            _customerRepository= repository;
        }
        public async Task<IActionResult> Index()
        {
            List<Customers> customerList = new List<Customers>();

            customerList = await _customerRepository.GetAllCustomersAsync();

            return View(customerList);
        }

        public async Task<IActionResult> Details(int id)
        {
            var person = await _customerRepository.GetCustomersByIdAsync(id);
            return View(person);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Customers customerList)
        {
             await _customerRepository.AddCustomersAsync(customerList);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
           await _customerRepository.DeleteCustomersAsync(id);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            var person = _customerRepository.GetCustomersByIdAsync(id);
            return View(person);
        }


        [HttpPost]
        public async Task<IActionResult> Edit(Customers customerList)
        {
           await _customerRepository.UpdateCustomersAsync(customerList);
            return RedirectToAction("Index");
        }
    }
}

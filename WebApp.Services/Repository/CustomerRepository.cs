using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApp.Sales.Data;
using WebApp.Sales.Models;

namespace WebApp.Services.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private ApplicationDbContext _context;

        public CustomerRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddCustomersAsync(Customers customers)
        {
            _context.Customers.Add(customers);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCustomersAsync(int id)
        {
            var person=await _context.Customers.FindAsync(id);
            _context.Customers.Remove(person);
            await _context.SaveChangesAsync(); 
        }

        public async Task<List<Customers>> GetAllCustomersAsync()
        {
            return await _context.Customers.ToListAsync();
        }

        public async Task<Customers> GetCustomersByIdAsync(int id)
        {
            return await _context.Customers.FindAsync(id);
        }

        public async Task UpdateCustomersAsync(Customers customers)
        {
             _context.Customers.Update(customers);
            await _context.SaveChangesAsync();
        }

        //Task<List<Customers>> ICustomerRepository.GetCustomersByIdAsync(int id)
        //{
        //    throw new NotImplementedException();
        //}
    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Sales.Models;

namespace WebApp.Services.Repository
{
    public interface ICustomerRepository
    {
        Task<List<Customers>> GetAllCustomersAsync();
        Task<Customers> GetCustomersByIdAsync(int id);

        Task AddCustomersAsync(Customers customers);

        Task UpdateCustomersAsync(Customers customers);
        Task DeleteCustomersAsync(int id);
    }
}

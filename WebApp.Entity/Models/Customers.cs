using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Sales.Models
{
    [Table("Customers")]
    public class Customers
    {
        [Key]
        public int CustomerId { get; set; }
        [Display(Name ="CustName")]
        public string? CustomerName { get; set; }

        public string? Email { get; set; }

        public long ContactNo { get; set; }

        public string? Location { get; set; }


        public List<Orderss> ordersses  {  get; set; }
    }
}

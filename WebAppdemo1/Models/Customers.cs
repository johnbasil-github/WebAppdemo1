using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Sales.Models
{
    [Table("Customers")]
    public class Customers
    {
        [Key]
        public int CustomerId { get; set; }

        public string? CustomerName { get; set; }

        public string? Email { get; set; }

        public long ContactNo { get; set; }

        public string? Location { get; set; }
    }
}

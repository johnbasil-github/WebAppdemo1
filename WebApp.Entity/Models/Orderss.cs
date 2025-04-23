using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Sales.Models
{

    [Table("Orderss")]
    public class Orderss
    {
        [Key]
        public int OrderId { get; set; }

        public string? ProductName { get; set; }

        public int Qty { get; set; }

        public int Total { get; set; }


        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int TotalPrice { get; set; }

        public int CustId { get; set; }
        [ForeignKey("CustId")]
        public Customers customers {  get; set; }
    }
}

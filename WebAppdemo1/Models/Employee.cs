using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Sales.Models
{
    [Table("Employeee")]
    public class Employee
    {
        [Key]
        public int id { get; set; }

        public string Name { get; set; }

        public DateTime Dob {  get; set; }

        public string EmailId { get; set; }

        public int Salary {  get; set; }

        public string  Designation {  get; set; }
        public int Age { get; set; }


    }
}

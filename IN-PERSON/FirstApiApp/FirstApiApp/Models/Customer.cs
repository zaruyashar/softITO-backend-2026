using System.ComponentModel.DataAnnotations;

namespace FirstApiApp.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
    }
}

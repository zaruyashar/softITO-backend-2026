using System.ComponentModel.DataAnnotations;

namespace CodeFirstJavaScriptApp.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Ad girin: ")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Şehir girin: ")]
        public string City { get; set; }

        public string State { get; set; }

        public string? Salary { get; set; }
    }
}

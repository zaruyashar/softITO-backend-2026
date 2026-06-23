using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bridge_mvc_project.Models
{
    public class Developer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DeveloperId { get; set; }
        public string? DeveloperName { get; set; }
        public DateTime FoundationDate { get; set; }
        public float DeveloperValue { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisualArt.Models
{
    public class Art
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Year { get; set; }
        public string? Technic { get; set; }
        public string? Size { get; set; }
        [Display(Name = "Price €")]
        [Range(0, 999999.99, ErrorMessage = "The Price must be between 0 and 999,999.99.")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }
}

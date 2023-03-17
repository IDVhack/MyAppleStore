using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyAppleProject.Models
{
    public class Product
    {
        public long Id { get; set; }
        [Required(ErrorMessage = "Пожалуйста, введите значение")]
        public string Name { get; set; }
        public string Slug { get; set; }
        [Required, MinLength(4, ErrorMessage = "Минимальная длина составляет 2")]
        public string Description { get; set; }
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Пожалуйста, введите значение")]
        [Column(TypeName = "decimal(8,2")]
        public decimal Price { get; set; }
        public long CategoryId { get; set; }
        public Category Category { get; set; }
        public string Image { get; set; }

    }
}

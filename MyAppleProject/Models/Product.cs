using MyAppleProject.Infrasrtucture.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyAppleProject.Models
{
    public class Product
    {
        public long Id { get; set; }
        [Display(Name = "Название")]

        [Required(ErrorMessage = "Необходимо указать название")]
        public string Name { get; set; }

        public string Slug { get; set; }
        [Display(Name = "Описание товара")]

        [Required(ErrorMessage = "Необходимо добавить описание")]
        [MinLength(4, ErrorMessage = "Минимальная длина 4")]
        public string Description { get; set; }
        [Display(Name = "Цена")]

        [Required(ErrorMessage = "Необходимо указать цену")]
        [RegularExpression(@"^[0-9]{1,}$", ErrorMessage = "Недопустимая цена")]
        [Range(0, 99999999999999, ErrorMessage = "Недопустимая цена")]
        [Column(TypeName = "decimal(16,2)")]
        public decimal Price { get; set; }
        

        [Required, Range(1, int.MaxValue, ErrorMessage = "Необходимо выбрать категорию")]
        [Display(Name = "Категория")]
        public long CategoryId { get; set; }

        public Category Category { get; set; }

        public string Image { get; set; } = "noimage.png";
        [Display(Name = "Фото")]
        [NotMapped]
        [FileExtension]
        public IFormFile ImageUpload { get; set; }

    }
}

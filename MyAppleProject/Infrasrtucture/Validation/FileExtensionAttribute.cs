using System.ComponentModel.DataAnnotations;

namespace MyAppleProject.Infrasrtucture.Validation
{
    public class FileExtensionAttribute:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is IFormFile file)
            {
                var extension = Path.GetExtension(file.FileName);
                string[] extensions = { "jpg", "png"};
                bool result = extensions.Any(x=>extension.EndsWith(x));
                if (!result)
                {
                    return new ValidationResult("Разрешенными расширениями являются jpg и png");
                }
            }
            return ValidationResult.Success;
        }
    }
}

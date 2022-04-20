using System.ComponentModel.DataAnnotations;

namespace PruebaMarilynMonrroy.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
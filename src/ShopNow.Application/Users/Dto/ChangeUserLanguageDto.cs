using System.ComponentModel.DataAnnotations;

namespace ShopNow.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;

namespace ElsaProject.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
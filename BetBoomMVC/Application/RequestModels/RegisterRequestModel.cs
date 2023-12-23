using System.ComponentModel.DataAnnotations;

namespace BetBoomMVC.Application.RequestModels
{
    public class RegisterRequestModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Пароли должны быть одинаковыми.")]
        public string ConfirmPassword { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace BetBoomMVC.Application.RequestModels
{
    public class LoginRequestModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember me")]
        public bool RememberMe { get; set; }
    }
}

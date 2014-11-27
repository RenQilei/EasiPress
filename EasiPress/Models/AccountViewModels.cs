using System.ComponentModel.DataAnnotations;

namespace EasiPress.Models
{
    // 暂时不明
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }
    }

    // 用户设置新密码
    public class ManageUserViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Current password")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "{0} must contains at least {2} characters.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Again password")]
        [Compare("NewPassword", ErrorMessage = "Passwords twice are different.")]
        public string ConfirmPassword { get; set; }
    }

    // 用户登录
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    // 用户注册
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "{0} must contains at least {2} characters.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Again password")]
        [Compare("Password", ErrorMessage = "Passwords twice are different.")]
        public string ConfirmPassword { get; set; }
    }
}

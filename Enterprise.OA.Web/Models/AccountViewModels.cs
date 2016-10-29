using Enterprise.OA.Web.Resources;
using System.ComponentModel.DataAnnotations;

namespace Enterprise.OA.Web.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(ResourceType = typeof(MetaStrings), Name = "AccountViewModel_UserName")]
        public string UserName { get; set; }
    }

    public class ManageUserViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(ResourceType = typeof(MetaStrings), Name = "AccountViewModel_OldPassword")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(ResourceType = typeof(MetaStrings), Name = "AccountViewModel_NewPassword")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(ResourceType = typeof(MetaStrings), Name = "AccountViewModel_ConfirmPassword")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(ResourceType = typeof(MetaStrings), Name = "AccountViewModel_UserName")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(ResourceType = typeof(MetaStrings), Name = "AccountViewModel_Password")]
        public string Password { get; set; }

        [Display(ResourceType = typeof(MetaStrings), Name = "AccountViewModel_RememberMe")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required]
        [Display(ResourceType = typeof(MetaStrings), Name = "AccountViewModel_UserName")]
        public string UserName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(ResourceType = typeof(MetaStrings), Name = "AccountViewModel_Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(ResourceType = typeof(MetaStrings), Name = "AccountViewModel_ConfirmPassword")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}

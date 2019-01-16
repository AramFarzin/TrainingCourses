using System.ComponentModel.DataAnnotations;

namespace TrainingCourses.Presentation.Web.ViewModels
{
    public class LoginViewModel
    {
        [Display(Name = "نام کاربری")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Username { get; set; }

        [Display(Name = "رمز عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "مرا به خاطر بسپار")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public bool RememberMe { get; set; }
    }
}
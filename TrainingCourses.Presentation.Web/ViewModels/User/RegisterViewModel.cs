using System.ComponentModel.DataAnnotations;

namespace TrainingCourses.Presentation.Web.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "نام را وارد نمایید")]
        [Display(Name = "نام")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "نام خانوادگی را وارد نمایید")]
        [Display(Name = "نام خانوادگی")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "نام کاربری را وارد نمایید")]
        [Display(Name = "نام کاربری")]
        [StringLength(100, ErrorMessage = "نام کاربری باید بیشتر از 4 کاراکتر باشد", MinimumLength = 4)]
        public string Username { get; set; }

        [Required(ErrorMessage = "رمز عبور را وارد نمایید")]
        [DataType(DataType.Password)]
        [Display(Name = "رمز عبور")]
        [StringLength(100, ErrorMessage = "رمز عبور باید بیشتر از 6 کاراکتر باشد", MinimumLength = 6)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "تکرار رمز عبور")]
        [Compare("Password", ErrorMessage = "با رمز عبور یکسان نمی باشد")]
        public string ConfirmPassword { get; set; }
    }
}
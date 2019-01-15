using System;
using System.Web.Mvc;
using PresentationTier.ViewModels;
using TrainingCourses.Model;

namespace PresentationTier.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
                try
                {
                    //var userDto = RegisterViewModelMapToUserDto(registerViewModel);
                    //HttpClientHelper.Post(apiUri, endpoint, userDto);
                    //return RedirectToAction("Login");
                    var user = new User(); // TODO : Use DI
                    var repo = new UserRepository();
                    repo.Add(user);
                    return Content("OK");
                }
                catch (Exception)
                {
                    ViewBag.ErrorMessage = "خطا در ثبت نام لطفا دوباره تلاش کنید";
                    return View(registerViewModel);
                }

            return View(registerViewModel);
        }
    }
}
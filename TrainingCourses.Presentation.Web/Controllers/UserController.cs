using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Security;
using TrainingCourses.Presentation.Web.ViewModels;
using TrainingCourses.Model.Users;

namespace TrainingCourses.Presentation.Web.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register([Bind(Include = "Username,Password,ConfirmPassword")] RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
                try
                {
                    //var userDto = RegisterViewModelMapToUserDto(registerViewModel);
                    var user = new User(); // TODO : Use DI
                    var repo = new UserRepository();
                    repo.Add(user);
                    return RedirectToAction("Login");
                }
                catch (Exception)
                {
                    ViewBag.ErrorMessage = "خطا در ثبت نام لطفا دوباره تلاش کنید";
                    return View(registerViewModel);
                }

            return View(registerViewModel);
        }


        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login([Bind(Include = "Username,Password,RememberMe")] LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // TODO : Authenticate User
                    return RedirectToAction("Index", "Order");
                }
                catch (Exception)
                {
                    ModelState.AddModelError("username", errorMessage: "نام کاربری یا رمز عبور اشتباه است");
                    return View(loginViewModel);
                }
            }
            return View(loginViewModel);
        }


        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}
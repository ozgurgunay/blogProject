using BlogProje.DataAccess.Repository.Abstract;
using BlogProje.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogProje.DataAccess;

namespace BlogProje.Controllers
{
    public class UserController : Controller
    {
        IUserRepository userRepository;
        public UserController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public IActionResult Login()
        {
            if(Request.Cookies["eMail"] != null)
            {
                LoginVM loginVM = new LoginVM()
                {
                    Email = Request.Cookies["eMail"],
                    IsRemember = true
                };
                return View(loginVM);
            }
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginVM loginUser)
        {
            User user = userRepository.LoginByUser(loginUser.Email);

            if (user != null)
            {
                //HttpContext.Session.SetString("firstName", user.FirstName);
                //HttpContext.Session.SetString("lastName", user.LastName);
                //setstring ile gönderilen eMail i SaveUserController da yakalıyoruz
                if (loginUser.IsRemember)
                {
                    CookieOptions cookieOptions = new CookieOptions();
                    cookieOptions.Path = "User/Login";
                    cookieOptions.Expires = DateTime.Now.AddDays(15);
                    Response.Cookies.Append("eMail", loginUser.Email, cookieOptions);
                    
                    EMailVM.SendMail(user.Email, user.UserId);
                }
                ViewBag.Message = "Giriş için mailinizi kontrol ediniz.";

            }
            else
            {
                //db kayıt kısmı
                User newUser = new User();
                newUser.Email = loginUser.Email;
                
                userRepository.AddUser(newUser);
            }
            
            return View();
        }
        public IActionResult ActivedUser(int id)
        {
            User user = userRepository.GetUser(id);
            HttpContext.Session.SetString("eMail", user.Email);
            
            //return View();
            return RedirectToAction(nameof(Index), "Home");
        }

        public IActionResult LogOut()
        {
            HttpContext.Session.Remove("eMail");
            return RedirectToAction(nameof(Index), "Home");
        }
    }
}

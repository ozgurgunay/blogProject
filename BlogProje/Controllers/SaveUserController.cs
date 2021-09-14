using BlogProje.DataAccess;
using BlogProje.DataAccess.Repository.Abstract;
using BlogProje.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProje.Controllers
{
    public class SaveUserController : Controller
    {
        IUserRepository userRepository;
        public SaveUserController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UpdateUser(UserSaveVM userSaveVM)
        {
            User newUser = new User()
            {
                FirstName = userSaveVM.FirstName,
                LastName = userSaveVM.LastName,
                UserName = userSaveVM.UserName,
                Email = HttpContext.Session.GetString("eMail"),
                //UserController dan gelen eMail i kullanıyoruz güncelleme için
                Explanation = userSaveVM.Explanation,
                Picture = userSaveVM.Picture
            };

            bool check = userRepository.UpdateUser(newUser);

            if(check)
            {
                return Json("ok");
            }
            return Json("fail");
        }
    }
}

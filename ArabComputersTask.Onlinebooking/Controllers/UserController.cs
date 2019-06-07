using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ArabComputersTask.API.Models;
using ArabComputersTask.Services;

namespace ArabComputersTask.Onlinebooking.Controllers
{
    public class UserController : Controller
    {
        UserServices _userServices = new UserServices();
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(UserLogin userLogin)
        {
            User user = _userServices.GetUser(userLogin);
            if (user != null)
            {
                bool UserIsVistor = _userServices.UserIsVistor(user.UserID);
                if (UserIsVistor)
                {
                    Session["userid"] = user.UserID;
                    return RedirectToAction(nameof(RoomController.Index), nameof(Room));
                }
                else
                {
                    return View(userLogin);
                }
            }
            else
            {
                return View(userLogin);
            }
        }

    }
}
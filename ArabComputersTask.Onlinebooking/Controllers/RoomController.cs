using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using ArabComputersTask.API.Controllers;
using ArabComputersTask.API.Models;
using System.Threading.Tasks;
using ArabComputersTask.Services;


namespace ArabComputersTask.Onlinebooking.Controllers
{
    public class RoomController : Controller
    {
        RoomServices _roomServices = new RoomServices();

        // GET: Room
        public ActionResult Index()
        {
            if (Session["userid"] == null)
            {
                return RedirectToAction(nameof(UserController.Login), nameof(User));
            }
            IEnumerable<Room> rooms = _roomServices.GetEmptyRooms();
            return View(rooms);
        }
      public ActionResult Reserve (int RoomID)
        {
            if (Session["userid"] == null)
            {
                return RedirectToAction(nameof(UserController.Login), nameof(User));
            }
            _roomServices.Reserve(RoomID);
            return RedirectToAction(nameof(Index));
        }
    }
}
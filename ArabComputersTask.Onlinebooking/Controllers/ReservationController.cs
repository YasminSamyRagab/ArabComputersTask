using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ArabComputersTask.Services;
using ArabComputersTask.API.Models;

namespace ArabComputersTask.Onlinebooking.Controllers
{
    public class ReservationController : Controller
    {
        ReservationServices _reservationServices = new ReservationServices();
        // GET: Reservation
        public ActionResult Index()
        {
            if (Session["userid"] == null)
            {
                return RedirectToAction(nameof(UserController.Login), nameof(User));
            }
            return View();
        }

        [HttpGet]
        public ActionResult Reserve( int RoomID, int RoomNumber)
        {
            if (Session["userid"] == null)
            {
                return RedirectToAction(nameof(UserController.Login), nameof(User));
            }
            else
            {
                Reservation reservation = new Reservation()
                {
                    RoomID = RoomID,
                    ReservationTime = DateTime.Now,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                    UserID = int.Parse(Session["userid"].ToString()),
                    CreateReservationBy = int.Parse(Session["userid"].ToString())                     
                };
                reservation.Room = new Room()
                {
                    RoomNumber = RoomNumber
                };
                return PartialView(reservation);
            }
        }
        [HttpPost]
        public ActionResult Reserve(Reservation reservation)
        {
            if (Session["userid"] == null)
            {
                return RedirectToAction(nameof(UserController.Login), nameof(UserController));
            }
            else
            {
                if (ModelState.IsValid == true)
                {
                    _reservationServices.Reserve(reservation);
                    return RedirectToAction(nameof(RoomController.Reserve), nameof(Room), new { RoomID = reservation.RoomID });
                }
                else
                {
                    return RedirectToAction(nameof(Reserve));
                }
            }
        }
    }
}
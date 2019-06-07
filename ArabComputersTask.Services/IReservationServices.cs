using System;
using System.Collections.Generic;
using System.Text;
using ArabComputersTask.API.Models;

namespace ArabComputersTask.Services
{
    interface IReservationServices
    {

        Reservation GetCurrentReservation(int RoomId);
        IEnumerable<Reservation> GetReservations();

        Boolean CheckOut(int RoomId);
        Boolean Reserve(Reservation reservation);

    }
}

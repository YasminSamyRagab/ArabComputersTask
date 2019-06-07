using System;
using System.Collections.Generic;
using System.Text;
using ArabComputersTask.API.Models;

namespace ArabComputersTask.Services
{
    interface IRoomServices
    {
        IEnumerable<Room> GetRooms();
        Room GetRoom(int RoomId);
        IEnumerable<Room> GetEmptyRooms();
        IEnumerable<Room> GetReservedRooms();
        Boolean CheckOut(int RoomId);
        Boolean Reserve(int RoomId);
    }
}

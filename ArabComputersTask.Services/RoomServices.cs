using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using ArabComputersTask.API.Models;

namespace ArabComputersTask.Services
{
    public class RoomServices : IRoomServices
    {
        public bool CheckOut(int RoomId)
        {
            try
            {
                Room room = GetRoom(RoomId);
                room.Availability = true;
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:60002/api/Rooms/");

                    //HTTP PUT
                    var putTask = client.PutAsJsonAsync<Room>(RoomId.ToString(), room);
                    putTask.Wait();

                    var result = putTask.Result;
                    if (result.IsSuccessStatusCode)
                    {

                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Room> GetEmptyRooms()
        {
            try
            {
                IEnumerable<Room> rooms = null;
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:60002/api/");
                    //HTTP GET
                    var responseTask = client.GetAsync("EmptyRooms");
                    responseTask.Wait();

                    var result = responseTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var readTask = result.Content.ReadAsAsync<IList<Room>>();
                        readTask.Wait();
                        rooms = readTask.Result;
                    }
                    else //web api sent error response 
                    {
                        //log response status here..
                        rooms = Enumerable.Empty<Room>();
                    }
                }
                return rooms;
            }
            catch (Exception ex)
            {
                throw ex;
            } 
        }

        public IEnumerable<Room> GetReservedRooms()
        {
            try { 
            IEnumerable<Room> rooms = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:60002/api/");
                //HTTP GET
                var responseTask = client.GetAsync("ReservedRooms");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<Room>>();
                    readTask.Wait();
                    rooms = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..
                    rooms = Enumerable.Empty<Room>();
                }
            }
            return rooms;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Room GetRoom(int RoomId)
        {
            try { 
            Room room = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:60002/api/Room/");
                //HTTP GET
                var responseTask = client.GetAsync(RoomId.ToString());
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<Room>();
                    readTask.Wait();
                    room = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..
                    room = null ;
                }
            }
            return room;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Room> GetRooms()
        {
            try { 
            IEnumerable<Room> rooms = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:60002/api/");
                //HTTP GET
                var responseTask = client.GetAsync("Rooms");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<Room>>();
                    readTask.Wait();
                    rooms = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..
                    rooms = Enumerable.Empty<Room>();
                }
            }
            return rooms;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Reserve(int RoomId)
        {
            try
            {
                Room room = GetRoom(RoomId);
                room.Availability = false;
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:60002/api/Rooms/");

                    //HTTP PUT
                    var putTask = client.PutAsJsonAsync<Room>(RoomId.ToString(), room);
                    putTask.Wait();

                    var result = putTask.Result;
                    if (result.IsSuccessStatusCode)
                    {

                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

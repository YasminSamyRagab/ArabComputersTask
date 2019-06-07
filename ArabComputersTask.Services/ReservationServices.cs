using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using ArabComputersTask.API.Models;

namespace ArabComputersTask.Services
{
   public class ReservationServices : IReservationServices
    {
        public Reservation GetCurrentReservation(int RoomId)
        {
            try
            {
                Reservation reservation = null;

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:60002/api/CurrentReservation/");
                    //HTTP GET
                    var responseTask = client.GetAsync(RoomId.ToString());
                    responseTask.Wait();

                    var result = responseTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var readTask = result.Content.ReadAsAsync<Reservation>();
                        readTask.Wait();
                        reservation = readTask.Result;
                    }
                    else //web api sent error response 
                    {
                        //log response status here..
                        reservation = null;
                    }
                }
                return reservation;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Reservation> GetReservations()
        {
            try
            {
             List<Reservation> reservations = null;

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:60002/api/");
                    //HTTP GET
                    var responseTask = client.GetAsync("Reservations");
                    responseTask.Wait();

                    var result = responseTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var readTask = result.Content.ReadAsAsync<List<Reservation>>();
                        readTask.Wait();
                        reservations = readTask.Result;
                    }
                    else //web api sent error response 
                    {
                        //log response status here..
                        reservations = null;
                    }
                }
                return reservations;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool CheckOut(int RoomId)
        {
            try
            {
                Reservation reservation = GetCurrentReservation(RoomId);
                reservation.CheckoutTime = DateTime.Now;
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:60002/api/Reservations/");

                    //HTTP PUT
                    var putTask = client.PutAsJsonAsync<Reservation>(reservation.ReservationID.ToString(), reservation);
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

        public bool Reserve(Reservation reservation )
        {
            try
            {
                reservation.ReservationTime = DateTime.Now;
                
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:60002/api/");

                    //HTTP POST
                    var postTask = client.PostAsJsonAsync<Reservation>("Reservations", reservation);
                    postTask.Wait();
                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch
            {
                return false;
            }           
        }
    }
}

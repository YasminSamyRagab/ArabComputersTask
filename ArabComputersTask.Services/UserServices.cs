using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using ArabComputersTask.API.Models;

namespace ArabComputersTask.Services
{
    public class UserServices : IUserServices
    {
        public IEnumerable<User> GetUsers()
        {
            try { 
            IEnumerable<User> Users = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:60002/api/Users");
                //HTTP GET
                var responseTask = client.GetAsync("Users");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<User>>();
                    readTask.Wait();
                    Users = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..
                    Users = Enumerable.Empty<User>();
                }
            }
            return Users;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<User> GetVistors()
        {
            try { 
            IEnumerable<User> Users = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:60002/api/");
                //HTTP GET
                var responseTask = client.GetAsync("Vistors");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<User>>();
                    readTask.Wait();
                    Users = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..
                    Users = Enumerable.Empty<User>();
                }
            }
            return Users;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool UserIsAdmin(int UserId)
        {
            try
            {
                bool IsAdmin = false;

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:60002/api/");
                    //HTTP GET
                    var responseTask = client.GetAsync("UserIsAdmin/"+UserId.ToString());
                    responseTask.Wait();

                    var result = responseTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var readTask = result.Content.ReadAsAsync<bool>();
                        readTask.Wait();
                        IsAdmin = readTask.Result;
                    }
                    else //web api sent error response 
                    {
                        //log response status here..
                        IsAdmin = false;
                    }
                }
                return IsAdmin;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UserIsVistor(int UserId)
        {
            try
            {
                bool IsAdmin = false;

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:60002/api/");
                    //HTTP GET
                    var responseTask = client.GetAsync("UserIsVistor/" + UserId.ToString());
                    responseTask.Wait();

                    var result = responseTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var readTask = result.Content.ReadAsAsync<bool>();
                        readTask.Wait();
                        IsAdmin = readTask.Result;
                    }
                    else //web api sent error response 
                    {
                        //log response status here..
                        IsAdmin = false;
                    }
                }
                return IsAdmin;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public User GetUser(UserLogin userLogin)
        {
            try
            {
                User User = null;

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:60002/api/");
                   
                    //HTTP GET
                    var responseTask = client.PostAsJsonAsync("GetUser", userLogin);
                    responseTask.Wait();

                    var result = responseTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var readTask = result.Content.ReadAsAsync<User>();
                        readTask.Wait();
                        User = readTask.Result;
                    }
                    else //web api sent error response 
                    {
                        //log response status here..
                        User = null;
                    }
                }
                return User;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

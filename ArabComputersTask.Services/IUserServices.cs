using System;
using System.Collections.Generic;
using System.Text;
using ArabComputersTask.API;
using ArabComputersTask.API.Models;


namespace ArabComputersTask.Services
{
    interface IUserServices
    {
        IEnumerable<User> GetUsers();
        IEnumerable<User> GetVistors();
    }
}

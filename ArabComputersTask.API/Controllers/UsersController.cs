using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ArabComputersTask.API.Models;

namespace ArabComputersTask.API.Controllers
{
    public class UsersController : ApiController
    {
        private ArabComputersTaskDB db = new ArabComputersTaskDB();

        // GET: api/Users
        public IQueryable<User> GetUsers()
        {
            return db.Users;
        }
        [HttpGet]
        [Route("api/Vistors")]
        public IQueryable<User> GetVistors()
        {
            return db.Users.Where(e=>e.Role.RoleName == "Vistor");
        }

        // GET: api/Users/5
        [ResponseType(typeof(User))]
        public IHttpActionResult GetUser(int id)
        {
            User user = db.Users.Find(id);
            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        // PUT: api/Users/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutUser(int id, User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != user.UserID)
            {
                return BadRequest();
            }

            db.Entry(user).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

      //  POST: api/Users
       [ResponseType(typeof(User))]
        public IHttpActionResult PostUser(User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Users.Add(user);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = user.UserID }, user);
        }

        // DELETE: api/Users/5
        [ResponseType(typeof(User))]
        public IHttpActionResult DeleteUser(int id)
        {
            User user = db.Users.Find(id);
            if (user == null)
            {
                return NotFound();
            }

            db.Users.Remove(user);
            db.SaveChanges();

            return Ok(user);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public bool UserExists(int id)
        {
            return db.Users.Count(e => e.UserID == id) > 0;
        }
        [HttpPost]
        [Route("api/GetUser")]
        [ResponseType(typeof(User))]
        public IHttpActionResult GetUser(UserLogin userLogin)
        {
            User user = db.Users.Where(e=>e.UserMailAddress == userLogin.UserMailAddress && e.UserPassword == userLogin.UserPassword).FirstOrDefault();
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }
        [HttpGet]
        [Route ("api/UserIsAdmin/{id}")]
        public bool UserIsAdmin(int id)
        {
            return db.Users.Where(e=>e.Role.RoleName=="Admin").Count(e => e.UserID == id) > 0;
        }
        [HttpGet]
        [Route("api/UserIsVistor/{id}")]
        public bool UserIsVistor(int id)
        {
            return db.Users.Where(e => e.Role.RoleName == "Vistor").Count(e => e.UserID == id) > 0;
        }
    }
}
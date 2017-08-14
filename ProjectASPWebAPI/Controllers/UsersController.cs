using ProjectASPWebAPI.Models;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjectASPWebAPI.Controllers
{
    public class UsersController : ApiController
    {
        [HttpGet]
        public IHttpActionResult All()
        {
            using (var context = new Context())
            {
                var users = context.Users.ToList();
                return Ok(users);
            }
        }

        [HttpGet]
        public IHttpActionResult FindUserById(int id)
        {
            using (var context = new Context())
            {
                var user = context.Users.Find(id);
                if (user == null)
                {
                    return NotFound();
                }
                return Ok(user);
            }
        }

        [HttpPost]
        public HttpResponseMessage InsertNewData([FromBody] User user)
        {
            using (var context = new Context())
            {
                context.Users.Add(new User()
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    Password = user.Password,
                    CreatedAt = DateTime.Today,
                    UpdatedAt = DateTime.Today
                });
                context.SaveChanges();
            }
            return Request.CreateResponse(HttpStatusCode.Created, "OK!");
        }
    }
}

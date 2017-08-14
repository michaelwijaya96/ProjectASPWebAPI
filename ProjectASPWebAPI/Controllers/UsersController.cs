using ProjectASPWebAPI.Models;
using System;
using System.Web.Http;

namespace ProjectASPWebAPI.Controllers
{
    public class UsersController : ApiController
    {
        [HttpGet]
        public IHttpActionResult All()
        {
            //using (var context = new Context())
            //{
            //    context.Users.Add(new User()
            //    {
            //        FirstName = "Alvin",
            //        LastName = "Oktavianus",
            //        Password = "Halelujah",
            //        Email = "agentsam1995@gmail.com",
            //        CreatedAt = DateTime.Today,
            //        UpdatedAt = DateTime.Today
            //    });
            //    context.SaveChanges();
            //}
            return Ok();
        }
    }
}

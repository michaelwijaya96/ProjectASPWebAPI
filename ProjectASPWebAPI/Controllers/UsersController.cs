using System;
using System.Collections.Generic;
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
            return Ok("Hello world!");
        }
    }
}

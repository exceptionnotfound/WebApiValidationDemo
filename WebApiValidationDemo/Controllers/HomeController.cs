using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using WebApiValidationDemo.Filters;
using WebApiValidationDemo.Models;

namespace WebApiValidationDemo.Controllers
{
    [RoutePrefix("users")]
    public class HomeController : ApiController
    {
        [HttpGet]
        [Route("all")]
        [ValidateModelStateFilter]
        public IHttpActionResult GetAll()
        {
            var users = new List<User>();
            users.Add(new User()
            {
                FirstName = "Mark",
                LastName = "Watney",
                BirthDate = new DateTime(2003, 8, 7),
                Username = "mwatney549"
            });

            users.Add(new Models.User()
            {
                FirstName = "Melissa",
                LastName = "Lewis",
                BirthDate = new DateTime(1999, 1, 26),
                Username = "cmdrlewis"
            });

            users.Add(new Models.User()
            {
                FirstName = "Rick",
                LastName = "Martinez",
                BirthDate = new DateTime(1998, 4, 5),
                Username = "mmartinez"
            });

            return Ok(users);
        }

        [HttpPost]
        [Route("add")]
        public IHttpActionResult Add(User user)
        {
            return Ok();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _1111webapi.Models;
namespace _1111webapi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        internal BookContext _db;
        // GET api/values
        public TestController()
        {

        }

        [HttpGet]
        public IActionResult TestUser([FromQuery]User name)
        {
            // string userInfo = $"Id: {user.Id}  Name: {user.Name}  Age: {user.Age}  HasRight: {user.HasRight}";
            return Content(name.Name+" "+name.id);
        }

        [HttpGet]
        public IActionResult TestUser2([FromRoute]User user)
        {
            if (user == null)
                return Content("asdasdasdasd"); ;
            // string userInfo = $"Id: {user.Id}  Name: {user.Name}  Age: {user.Age}  HasRight: {user.HasRight}";
            return Content(user.Name);
        }

        public IActionResult TestUser3(User user)
        {
            if (user == null)
                return Content("asdasdasdasd"); ;
            // string userInfo = $"Id: {user.Id}  Name: {user.Name}  Age: {user.Age}  HasRight: {user.HasRight}";
            return Content(user.Name);
        }

        [HttpGet]
        public IActionResult TestUser1(string name)
        {
            // string userInfo = $"Id: {user.Id}  Name: {user.Name}  Age: {user.Age}  HasRight: {user.HasRight}";
            return Content(name);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _1111webapi.Models;
namespace _1111webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        public ValuesController(BookContext context)
        {
            _db = context;
        }
      [HttpGet]
       [Route("api/[controller]/[action]")]
        public IActionResult AddUser(Client client)
        {
           // string userInfo = $"Id: {user.Id}  Name: {user.Name}  Age: {user.Age}  HasRight: {user.HasRight}";
            return Content("AddUser");
        }

        internal BookContext _db;

        string[] st = { "value1", "value2" };

        [HttpGet]
        public ActionResult<IEnumerable<Client>> Get()
        {
            var books = _db.Clients;

            // var cl = new Client() { Name = "cl", Amount = 100 };
            // if (cl.Transactions == null)
            // {
            //     cl.Transactions = new List<Transaction>();
            // }
            // var tr1 = new Transaction() { Amount = 2, Date = DateTime.Now };
            // var tr2 = new Transaction() { Amount = 6, Date = DateTime.Now };
            // cl.Transactions.Add(tr1);
            // cl.Transactions.Add(tr2);
            // _db.Clients.Add(cl);
            // _db.SaveChanges();

            return books;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return st[id];
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

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

    internal BookContext _db;

		string[] st= { "value1", "value2" };
		
        [HttpGet]
        public ActionResult<IEnumerable<Book>> Get()
        {
            var books=_db.Books;
            User user=new User();
            Book b=new Book();
            _db.Add(b);
            _db.SaveChanges();
            
            return  books;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return   st[id];
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

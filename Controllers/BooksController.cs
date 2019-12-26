using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _1111webapi.Models;
using Microsoft.AspNetCore.Mvc;
namespace _1111webapi.Controllers
{
    [Route ("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        // GET api/values
        public BooksController (BookContext context)
        {
            _db = context;
        }

        internal BookContext _db;

        [HttpGet]
        public ActionResult<IEnumerable<Book>> Get ()
        {
            var books = _db.Books;
            var t = _db.Trnsactions;
            var m = _db.Clients;
            var l = books.ToList ();
            return books;
        }

        // GET api/values/5
        [HttpGet ("{id}")]
        public ActionResult<string> Get (int id)
        {
            var book = _db.Books.FirstOrDefault (x => x.Id == id);
            if (book == null)
                return NotFound ();
            return new ObjectResult (book);
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post ([FromBody] Book book)
        {
            if (book == null)
            {
                return BadRequest ();
            }
            _db.Books.Add (book);
            _db.SaveChanges ();
            return Ok (book);
        }

        // PUT api/Books/
        [HttpPut]
        public IActionResult Put ([FromBody] Book book)
        {
            if (book == null)
            {
                return BadRequest ();
            }
            if (!_db.Books.Any (x => x.Id == book.Id))
            {
                return NotFound ();
            }

            try
            {
                _db.Update (book);
                _db.SaveChanges ();
            }
            catch (System.Exception ex)
            {
                return BadRequest (ex.ToString ());
            }

            return Ok (book);
        }

        // DELETE api/Books/5
        [HttpDelete ("{id}")]
        public IActionResult Delete (int id)
        {
            var book = _db.Books.FirstOrDefault (x => x.Id == id);
            if (book == null)
            {
                return NotFound ();
            }
            _db.Books.Remove (book);
            _db.SaveChanges ();
            return Ok (book);
        }
    }
}

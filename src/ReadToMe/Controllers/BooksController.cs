using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using readtome.Model;

namespace readtome.Controllers
{
    [Route("api/[controller]")]
    public class BooksController : Controller
    {
        private List<Book> Books = new List<Book>{new Book(1, "Book 1", null), new Book(2, "Book 2", new Author[]{new Author("Mr.", "John", "Doe")})};

        // GET api/values
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return this.Books;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Book Get(int id)
        {
            return this.Books.Find(book => book.Id == id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Book bookToAdd)
        {
            Book existingBook = this.Books.Find(book => book.Id == bookToAdd.Id);

            if(existingBook == null) {
                this.Books.Add(bookToAdd);
            }else{
                int bookIndexToUpdate = this.Books.FindIndex(book => book.Id == bookToAdd.Id);
                this.Books[bookIndexToUpdate] = bookToAdd;
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

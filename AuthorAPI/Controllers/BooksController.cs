using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AuthorAPI.DatabaseAccess;
using AuthorAPI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AuthorAPI.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class BooksController:ControllerBase
    {
        private DatabaseContext databaseContext;
        public BooksController(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }
        
        [HttpGet] 
        public async Task<ActionResult<IList<Book>>> GetBooks()
        {
            try {
                IList<Book> books = await databaseContext.books.ToListAsync();
                return Ok(books); 
            } catch (Exception e) {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
        [HttpPost("{authorId:int}")]
        public async Task<ActionResult<Book>> AddBook([FromBody] Book book, [FromRoute] int authorId) {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                Author author = await databaseContext.authors.FirstOrDefaultAsync(t => t.Id == authorId);
                book.Author = author;
                await databaseContext.books.AddAsync(book);
                await databaseContext.SaveChangesAsync();
                return Created($"/{book.ISBN}",book);

            } catch (Exception e) {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult> DeleteBook([FromRoute] int id) {
            try
            {
                Book bookToDelete = await databaseContext.books.FirstOrDefaultAsync(t => t.ISBN == id);
                if (bookToDelete != null)
                {
                    databaseContext.books.Remove(bookToDelete);
                    await databaseContext.SaveChangesAsync();
                }
                return Ok();
            } catch (Exception e) {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
    }
}
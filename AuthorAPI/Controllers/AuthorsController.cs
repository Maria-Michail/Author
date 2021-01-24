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
    public class AuthorsController:ControllerBase
    {
        private DatabaseContext databaseContext;
        public AuthorsController(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }
        
        [HttpGet] 
        public async Task<ActionResult<IList<Author>>> GetAuthors()
        {
            try {
                IList<Author> authors = await databaseContext.authors.ToListAsync();
                return Ok(authors); 
            } catch (Exception e) {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
        [HttpPost]
        public async Task<ActionResult<Author>> AddAuthor([FromBody] Author author) {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                await databaseContext.authors.AddAsync(author);
                await databaseContext.SaveChangesAsync();
                return Created($"/{author.Id}",author);

            } catch (Exception e) {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
    }
}
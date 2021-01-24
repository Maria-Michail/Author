using AuthorAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace AuthorAPI.DatabaseAccess
{
    public class DatabaseContext:DbContext
    {
        public DbSet<Author> authors { get; set; }
        public DbSet<Book> books { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(
                @"Data Source = C:\Users\maria\OneDrive\Documents\Rider\293100-Exam-A20\AuthorAPI\AuthorAPI\MainDb.db");
        }
    }
}
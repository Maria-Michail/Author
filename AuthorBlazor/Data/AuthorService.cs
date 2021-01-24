using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using AuthorAPI.Model;

namespace AuthorBlazor.Data
{
    public class AuthorService
    {
        private readonly HttpClient client;
        private string uri = "https://localhost:5001";

        public AuthorService()
        {
            client = new HttpClient();
        }
        
        public async Task AddAuthor(Author newAuthor)
        {
            string account = JsonSerializer.Serialize(newAuthor);
            HttpContent content = new StringContent(account,
                Encoding.UTF8,
                "application/json");
            await client.PostAsync(uri+"/Authors", content);
        }
        
        public async Task<IList<Author>> GetAuthorsAsync()
        {
            Task<string> stringAsync = client.GetStringAsync(uri+"/Authors");
            string message = await stringAsync;
            IList<Author> result = JsonSerializer.Deserialize<IList<Author>>(message);
            return result;
        }
        
        public async Task<IList<Book>> GetBooks()
        {
            Task<string> stringAsync = client.GetStringAsync(uri+"/Books");
            string message = await stringAsync;
            IList<Book> result = JsonSerializer.Deserialize<IList<Book>>(message);
            return result;
        }
        
        public async Task AddBook(Book newBook , int id)
        {
            string account = JsonSerializer.Serialize(newBook);
            HttpContent content = new StringContent(account,
                Encoding.UTF8,
                "application/json");
            await client.PostAsync($"https://localhost:5001/Books/{id}", content);
        }
        
        public async Task RemoveBook(int bookId) {
            await client.DeleteAsync($"https://localhost:5001/Books/{bookId}");
        }

    }
}
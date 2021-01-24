using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace AuthorAPI.Model
{
    public class Author
    {
        [Key]
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [Required, MaxLength(15)]
        [JsonPropertyName("firstName")]
        public string FirstName { get; set; }
        [Required, MaxLength(15)]
        [JsonPropertyName("lastName")]
        public string LastName { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace AuthorAPI.Model
{
    public class Book
    {
        [Key]
        [JsonPropertyName("iSBN")]
        public int ISBN { get; set; }
        [Required, MaxLength(40)]
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("publicationYear")]
        public int PublicationYear { get; set; }
        [JsonPropertyName("numOfPages")]
        public int NumOfPages { get; set; }
        [JsonPropertyName("genre")]
        public string Genre { get; set; }
        [JsonPropertyName("author")]
        public Author Author { get; set; }
    }
}
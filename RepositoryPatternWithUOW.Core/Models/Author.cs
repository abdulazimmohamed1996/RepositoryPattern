using System.ComponentModel.DataAnnotations;

namespace RepositoryPatternWithUOW.Api.Models
{
    public class Author
    {
        public int Id { get; set; }
        [Required, MaxLength(150)]
        public string? Name { get; set; }
        public List<Book> Books { get; set; } = new List<Book>();
    }
}

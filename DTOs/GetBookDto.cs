using meraproject.Models.Entities;

namespace meraproject.DTOs
{
    public class GetBookDto
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public float Price { get; set; }
    }
}


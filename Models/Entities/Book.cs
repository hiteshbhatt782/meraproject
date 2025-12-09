namespace meraproject.Models.Entities
{
    public class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public float Price { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}

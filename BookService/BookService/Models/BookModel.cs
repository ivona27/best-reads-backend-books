namespace BookService.Models
{
    public class BookModel
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public string? title { get; set; }
        public string? author { get; set; }
        public int? isbn { get; set; }
        public DateTime? release_date { get; set; }
    }
}

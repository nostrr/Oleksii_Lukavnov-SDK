namespace LotRSDK.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public List<Quote> Quote { get; set; }
    }
}

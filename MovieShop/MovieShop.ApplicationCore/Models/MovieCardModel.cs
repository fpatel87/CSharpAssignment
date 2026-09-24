namespace MovieShop.ApplicationCore.Models
{
    public class MovieCardModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string PosterUrl { get; set; }

        public decimal Price { get; set; }

        public string Overview { get; set; }

        public DateTime ReleaseDate { get; set; }
    }
}
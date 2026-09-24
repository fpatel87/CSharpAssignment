namespace MovieShop.ApplicationCore.Entities
{
    public class MovieCasts
    {
        public int MovieId { get; set; }
        public int CastId { get; set; }
        public string Character { get; set; }
        public int? CastOrder { get; set; }

        public Movie Movie { get; set; }
        public Cast Cast { get; set; }
    }
}
using MovieShop.ApplicationCore.Contracts.Repository;
using MovieShop.ApplicationCore.Contracts.Services;
using MovieShop.ApplicationCore.Models;

namespace MovieShop.Infrastructure.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public IEnumerable<MovieCardModel> GetAllMovies()
        {
            return _movieRepository.GetAll()
                .Select(movie => new MovieCardModel
                {
                    Id = movie.Id,
                    Title = movie.Title,
                    PosterUrl = movie.PosterUrl,
                    Price = movie.Price,
                    Overview = movie.Overview,
                    ReleaseDate = movie.ReleaseDate ?? DateTime.MinValue
                })
                .ToList();
        }

        public MovieCardModel GetMovieById(int id)
        {
            var movie = _movieRepository.GetById(id);

            if (movie == null)
            {
                return null;
            }

            return new MovieCardModel
            {
                Id = movie.Id,
                Title = movie.Title,
                PosterUrl = movie.PosterUrl,
                Price = movie.Price,
                Overview = movie.Overview,
                ReleaseDate = movie.ReleaseDate ?? DateTime.MinValue
            };
        }
    }
}
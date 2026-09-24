using MovieShop.ApplicationCore.Models;

namespace MovieShop.ApplicationCore.Contracts.Services
{
    public interface IMovieService
    {
        IEnumerable<MovieCardModel> GetAllMovies();
        MovieCardModel GetMovieById(int id);
    }
}
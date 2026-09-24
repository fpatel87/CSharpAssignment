using MovieShop.ApplicationCore.Entities;

namespace MovieShop.ApplicationCore.Contracts.Services
{
    public interface ICastService
    {
        IEnumerable<Cast> GetAllCasts();
        Cast GetCastById(int id);
    }
}
using MovieShop.ApplicationCore.Entities;

namespace MovieShop.ApplicationCore.Contracts.Repository
{
    public interface ICastRepository
    {
        IEnumerable<Cast> GetAll();
        Cast GetById(int id);
    }
}
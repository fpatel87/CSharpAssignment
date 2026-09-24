using MovieShop.ApplicationCore.Contracts.Services;
using MovieShop.ApplicationCore.Entities;

namespace MovieShop.Infrastructure.Services
{
    public class CastService : ICastService
    {
        public IEnumerable<Cast> GetAllCasts()
        {
            return new List<Cast>();
        }

        public Cast GetCastById(int id)
        {
            return null;
        }
    }
}
using MovieShop.ApplicationCore.Contracts.Repository;
using MovieShop.ApplicationCore.Entities;
using MovieShop.Infrastructure.Data;

namespace MovieShop.Infrastructure.Repository
{
    public class CastRepository : ICastRepository
    {
        private readonly MovieShopDbContext _context;

        public CastRepository(MovieShopDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Cast> GetAll()
        {
            return _context.Casts.ToList();
        }

        public Cast GetById(int id)
        {
            return _context.Casts.FirstOrDefault(c => c.Id == id);
        }
    }
}
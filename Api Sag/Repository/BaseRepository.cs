using Api_Sag.Context;
using Api_Sag.Repository.Interfaces;

namespace Api_Sag.Repository
{
    public class BaseRepository : IBaseRepository
    {
        private readonly SagContext _context;

        public BaseRepository(SagContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<bool> SaveChangesAsync()
        {
           return await _context.SaveChangesAsync() > 0;
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }
    }
}

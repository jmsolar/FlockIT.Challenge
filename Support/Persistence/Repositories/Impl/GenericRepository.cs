using Support.Persistence.Contexts;
using Support.Persistence.Repositories.Interfaces;
using System.Threading.Tasks;

namespace Support.Persistence.Repositories.Impl
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationContext _dbContext;

        public GenericRepository(ApplicationContext appContext)
        {
            _dbContext = appContext;
        }

        public async Task<T> AddAsync(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }
    }
}

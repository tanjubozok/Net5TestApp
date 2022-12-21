using Net5TestApp.DataAccess.Abstract;
using Net5TestApp.DataAccess.Concrete.EfCore.Context;
using Net5TestApp.DataAccess.Concrete.EfCore.Repositories;
using Net5TestApp.Entities.Concrete;
using System.Threading.Tasks;

namespace Net5TestApp.DataAccess.Concrete.UnitOfWork
{
    public class Uow : IUow
    {
        private readonly DatabaseContext _context;

        public Uow(DatabaseContext context)
        {
            _context = context;
        }

        public IRepository<T> GetRepository<T>() where T : BaseEntity
        {
            return new Repository<T>(_context);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}

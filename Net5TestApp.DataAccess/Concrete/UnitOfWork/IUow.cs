using Net5TestApp.DataAccess.Abstract;
using Net5TestApp.Entities.Concrete;
using System.Threading.Tasks;

namespace Net5TestApp.DataAccess.Concrete.UnitOfWork
{
    public interface IUow
    {
        IRepository<T> GetRepository<T>() where T : BaseEntity;
        Task SaveChangesAsync();
    }
}

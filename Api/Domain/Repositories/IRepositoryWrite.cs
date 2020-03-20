using System.Threading.Tasks;

namespace Backend.Domain.Repositories
{
    public interface IRepositoryWrite<T>
    {
        Task<T> Insert(T t);
        Task<T> Delete(T t);
        Task<T> Update(T t);
    }
}
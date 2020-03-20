using System.Collections.Generic;
using System.Threading.Tasks;

namespace Backend.Domain.Repositories
{
    public interface IRepositoryReadOnly<T>
    {
        Task<List<T>> GetAll();
        Task<T> GetById(object id);
    }
}
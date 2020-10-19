
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Indicadores.Api.DataAccess.Contracts.Repositories
{
    public interface IRepository<T> where T : class
    {
    
        Task<int> Add(T element);
        Task<int> Update(T element);
       
    }
}

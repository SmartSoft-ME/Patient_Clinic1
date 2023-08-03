using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.IRepositories
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        

        Task Deleteasync(int id);

        Task<TEntity> GetByIdAsync(int id);

        Task<TEntity> GetAsync();
    }
}

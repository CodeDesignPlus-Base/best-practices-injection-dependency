using BestPracticesInjectionDependency.Abstractions;
using System.Threading.Tasks;

namespace BestPracticesInjectionDependency.Services.BestPractice4
{
    public interface IBestPractice4Service
    {
        Task<int> CreateAsync<TEntity, TRepository>(TEntity data)
               where TEntity : class
               where TRepository : IBaseRepository<TEntity>;
    }
}

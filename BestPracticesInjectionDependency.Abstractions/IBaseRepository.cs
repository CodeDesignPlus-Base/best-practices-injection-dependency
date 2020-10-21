using System.Threading.Tasks;

namespace BestPracticesInjectionDependency.Abstractions
{
    public interface IBaseRepository<TEntity>
    {
        Task<int> CreateAsync(TEntity data);
        Task<int> UpdateAsync(int id, TEntity data);
        Task<int> DeleteAsync(int id);
    }
}

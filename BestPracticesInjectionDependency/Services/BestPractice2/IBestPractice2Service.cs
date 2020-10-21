using BestPracticesInjectionDependency.Entities;
using System.Threading.Tasks;

namespace BestPracticesInjectionDependency.Services.BestPractice2
{
    public interface IBestPractice2Service
    {
        Task<int> CreateAsync(TypeDocument data);
    }
}
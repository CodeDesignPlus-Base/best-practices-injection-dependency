using BestPracticesInjectionDependency.Entities;
using System.Threading.Tasks;

namespace BestPracticesInjectionDependency.Services.BestPractice3
{
    public interface IBestPractice3Service
    {
        Task<int> CreateAsync(TypeDocument data);
    }
}

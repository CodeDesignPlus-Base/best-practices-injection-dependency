using BestPracticesInjectionDependency.Entities;
using System.Threading.Tasks;

namespace BestPracticesInjectionDependency.Services.BestPractice1
{
    public interface IBestPractice1Service
    {
        Task<int> CreateAsync(TypeDocument data);
    }
}
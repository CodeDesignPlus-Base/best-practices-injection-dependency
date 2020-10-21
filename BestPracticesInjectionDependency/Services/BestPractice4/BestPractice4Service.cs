using BestPracticesInjectionDependency.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace BestPracticesInjectionDependency.Services.BestPractice4
{
    public class BestPractice4Service : IBestPractice4Service
    {
        private readonly IServiceProvider _serviceProvider;

        public BestPractice4Service(IServiceProvider serviceProvider)
        {
            this._serviceProvider = serviceProvider;
        }

        public async Task<int> CreateAsync<TEntity, TRepository>(TEntity data)
            where TEntity : class
            where TRepository : IBaseRepository<TEntity>
        {
            using var scope = this._serviceProvider.CreateScope();

            var repository = scope.ServiceProvider.GetRequiredService<TRepository>();

            var id = await repository.CreateAsync(data);

            return id;
        }
    }
}

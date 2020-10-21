using BestPracticesInjectionDependency.Abstractions;
using BestPracticesInjectionDependency.Entities;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace BestPracticesInjectionDependency.Services.BestPractice1
{
    public class BestPractice1Service : IBestPractice1Service
    {
        private readonly ITypeDocumentsRepository _repository;

        private readonly ILogger<BestPractice1Service> _logger;

        public BestPractice1Service(ILogger<BestPractice1Service> logger, ITypeDocumentsRepository repository)
        {
            this._logger = logger;
            this._repository = repository;
        }

        public async Task<int> CreateAsync(TypeDocument data)
        {
            var id = await this._repository.CreateAsync(data);

            if (id > 0)
                this._logger.LogInformation("Se creo el registro con el id {0}", id);

            return id;
        }
    }
}

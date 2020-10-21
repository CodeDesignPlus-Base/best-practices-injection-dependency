using BestPracticesInjectionDependency.Abstractions;
using BestPracticesInjectionDependency.Entities;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using System.Threading.Tasks;

namespace BestPracticesInjectionDependency.Services.BestPractice2
{
    public class BestPractice2Service : IBestPractice2Service
    {
        private readonly ITypeDocumentsRepository _repository;

        public ILogger<BestPractice2Service> Logger { get; set; }

        public BestPractice2Service(ITypeDocumentsRepository repository)
        {
            this._repository = repository;

            // Null Object Pattern
            this.Logger = NullLogger<BestPractice2Service>.Instance;
        }

        public async Task<int> CreateAsync(TypeDocument data)
        {
            var id = await this._repository.CreateAsync(data);

            if (id > 0)
                this.Logger.LogInformation("Se creo el registro con el id {0}", id);

            return id;
        }
    }
}

using BestPracticesInjectionDependency.Abstractions;
using BestPracticesInjectionDependency.Entities;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using System;
using System.Threading.Tasks;

namespace BestPracticesInjectionDependency.Services.BestPractice3
{
    public class BestPractice3Service : IBestPractice3Service
    {
        private readonly ITypeDocumentsRepository _repository;

        private readonly ILogger<BestPractice3Service> _logger;

        public BestPractice3Service(IServiceProvider serviceProvider)
        {
            this._repository = serviceProvider.GetRequiredService<ITypeDocumentsRepository>();

            this._logger = serviceProvider.GetService<ILogger<BestPractice3Service>>() ?? NullLogger<BestPractice3Service>.Instance;
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

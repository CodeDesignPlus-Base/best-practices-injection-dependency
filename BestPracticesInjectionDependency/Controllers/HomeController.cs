using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BestPracticesInjectionDependency.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            this._logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            this._logger.LogInformation("Invoked - BestPractice1Controller:Get");

            return Ok();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.FeatureManagement.Mvc;

namespace AzureApiFeatureFlag.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OfficeQuoteController : ControllerBase
    {
        private readonly ILogger<OfficeQuoteController> _logger;

        public OfficeQuoteController(ILogger<OfficeQuoteController> logger)
        {
            _logger = logger;
        }

        [FeatureGate("FeatureA")]
        [HttpGet]
        public OfficeQuote Get()
        {
            return new()
            {
                Quote = "I give her a 10 for her looks and a 3 for her ability to describe herself",
                Character = "Michael Scott",
                Season = 4,
                Episode = 14
            };
        }
    }
}
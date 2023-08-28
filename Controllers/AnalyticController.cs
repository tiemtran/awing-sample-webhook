using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using WebhookTestAPI.Models;

namespace WebhookTestAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnalyticController : ControllerBase
    {
        private readonly ILogger<AnalyticController> _logger;

        public AnalyticController(ILogger<AnalyticController> logger)
        {
            _logger = logger;
        }
        [HttpPost("View")]
        public  IActionResult View([FromBody] AnalyticView analyticView)
        {
            _logger.LogInformation("AnalyticView", analyticView);
            return Ok("ok");
        }

        [HttpPost("Event")]
        public IActionResult Event([FromBody] AnalyticEvent analyticEvent)
        {
            _logger.LogInformation("AnalyticEvent", analyticEvent);
            return Ok("ok");
        }
    }
}

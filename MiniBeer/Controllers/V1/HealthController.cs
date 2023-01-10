using Microsoft.AspNetCore.Mvc;

namespace Beer.Api.Controllers.V1
{
    [ApiController]
    [Route("/v1/health")]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            try
            {
                Object response = new
                {
                    healthy = "ok",
                    date = DateTime.Now,
                };

                return StatusCode(StatusCodes.Status200OK, response);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.StackTrace);
            }
        }
    }
}


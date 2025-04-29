using Microsoft.AspNetCore.Mvc;


namespace ProjetoUsuarios.Controllers
{
    [ApiController]
    [Route ("api/getStatus")]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok ("OK");
        }
    }
}

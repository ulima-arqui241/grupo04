using Microsoft.AspNetCore.Mvc;
using WebApp.Clases;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ComunicacionController : ControllerBase
    {
        private readonly Proxy _proxy;

        public ComunicacionController(Proxy proxy)
        {
            _proxy = proxy;
        }


        [HttpGet("message")]
        public async Task<IActionResult> Test()
        {
            var message = await _proxy.GetMessage4();
            return Ok(message);
        }
    }
}



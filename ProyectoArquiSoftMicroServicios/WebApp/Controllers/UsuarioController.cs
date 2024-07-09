using Microsoft.AspNetCore.Mvc;
using WebApp.Clases;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly Proxy _proxy;

        public UsuarioController(Proxy proxy)
        {
            _proxy = proxy;
        }

        [HttpGet("message")]
        public async Task<IActionResult> Test()
        {
            var message = await _proxy.GetMessage();
            return Ok(message);
        }
    }
}

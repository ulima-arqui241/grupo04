using Microsoft.AspNetCore.Mvc;
using WebApp.Clases;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdministracionController : ControllerBase
    {
        private readonly Proxy _proxy;

        public AdministracionController(Proxy proxy)
        {
            _proxy = proxy;
        }


        [HttpGet("message")]
        public async Task<IActionResult> Test()
        {
            var message = await _proxy.GetMessage5();
            return Ok(message);
        }
    }
}



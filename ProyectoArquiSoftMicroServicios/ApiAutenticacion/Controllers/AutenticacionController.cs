using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

[ApiController]
[Route("api/[controller]")]
public class AutenticacionController : ControllerBase
{
    private readonly IConfiguration _configuration;

    public AutenticacionController(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    [HttpGet("message")]
    public IActionResult GetMessage()
    {
        return Ok("Hello from ApiAuth!");
    }
}



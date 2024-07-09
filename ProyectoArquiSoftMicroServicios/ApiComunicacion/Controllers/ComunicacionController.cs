using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

[ApiController]
[Route("api/[controller]")]
public class ComunicacionController : ControllerBase
{
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new List<string> { "User1", "User2" };
    }

    [HttpGet("message")]
    public IActionResult GetMessage()
    {
        return Ok("Hello from ApiComunicacion!");
    }
}

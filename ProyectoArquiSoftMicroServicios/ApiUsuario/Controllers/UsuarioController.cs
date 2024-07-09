using ApiUsuario.Business;
using ApiUsuario.Models.LEARNHUB.DB;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

[ApiController]
[Route("api/[controller]")]
public class UsuarioController : ControllerBase
{
    private readonly IUsuarioBO _usuarioBO;
    private readonly LearnHubContext _context;
    public UsuarioController(IUsuarioBO usuarioBO, LearnHubContext context)
    {
        _usuarioBO = usuarioBO;
        _context = context;
    }

    private void DisposeResources()
    {
        _context.Dispose();
    }

    [HttpGet("message")]
    public async Task<IActionResult> GetMessage()
    {
        var respuesta = await _usuarioBO.GetMessage();
        return Ok(respuesta);
        //return Ok("Hello from ApiGrupo!");

    }
}

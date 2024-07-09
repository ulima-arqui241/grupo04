using ApiUsuario.DataAccess;
using ApiUsuario.Entities.Response;
using System.Data;
using System.Net;
namespace ApiUsuario.Business
{
    public class UsuarioBO : IUsuarioBO
    {
        private readonly IUsuarioDO _usuarioDO;
        public UsuarioBO(IUsuarioDO usuarioDO)
        {
            _usuarioDO = usuarioDO;
        }

        public async Task<ObtenerTodosLosValoresResultResponse> GetMessage()
        {
            try
            {
                return await _usuarioDO.GetMessage();
            }
            catch (Exception ex)
            {
                return new ObtenerTodosLosValoresResultResponse()
                {
                    codigoRes = HttpStatusCode.InternalServerError,
                    mensajeRes = "Error interno al llamar al sp"
                };
            }
        }
    }
}

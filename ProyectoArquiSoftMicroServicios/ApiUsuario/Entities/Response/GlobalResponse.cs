using System.Net;

namespace ApiUsuario.Entities.Response
{
    public class GlobalResponse
    {
        public HttpStatusCode codigoRes { get; set; }
        public string mensajeRes { get; set; }
    }
}

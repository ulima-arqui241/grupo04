using System.Net;

namespace ApiGrupo.Entities.Response
{
    public class GlobalResponse
    {
        public HttpStatusCode codigoRes { get; set; }
        public string mensajeRes { get; set; }
    }
}

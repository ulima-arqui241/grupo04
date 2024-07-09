using System.Net;

namespace ApiAdministracion.Entities.Response
{
    public class GlobalResponse
    {
        public HttpStatusCode codigoRes { get; set; }
        public string mensajeRes { get; set; }
    }
}

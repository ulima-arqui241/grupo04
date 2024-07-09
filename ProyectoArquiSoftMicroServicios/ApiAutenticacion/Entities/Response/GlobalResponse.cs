using System.Net;

namespace ApiAutenticacion.Entities.Response
{
    public class GlobalResponse
    {
        public HttpStatusCode codigoRes { get; set; }
        public string mensajeRes { get; set; }
    }
}

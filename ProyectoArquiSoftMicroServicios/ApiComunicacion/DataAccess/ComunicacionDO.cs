using ApiComunicacion.Models.LEARNHUB.DB;

namespace ApiComunicacion.DataAccess
{
    public class ComunicacionDO
    {
        private readonly LearnHubContext _context;
        private readonly HttpClient _httpClient;

        public ComunicacionDO(LearnHubContext context, HttpClient httpClient)
        {
            _context = context;
            _httpClient = httpClient;

        }
    }
}

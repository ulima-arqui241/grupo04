using ApiAutenticacion.Models.LEARNHUB.DB;

namespace ApiAutenticacion.DataAccess
{
    public class AutenticacionDO
    {
        private readonly LearnHubContext _context;
        private readonly HttpClient _httpClient;

        public AutenticacionDO(LearnHubContext context, HttpClient httpClient)
        {
            _context = context;
            _httpClient = httpClient;

        }
    }
}

using ApiGrupo.Models.LEARNHUB.DB;

namespace ApiGrupo.DataAccess
{
    public class GrupoDO
    {
        private readonly LearnHubContext _context;
        private readonly HttpClient _httpClient;
        public GrupoDO(LearnHubContext context, HttpClient httpClient)
        {
            _context = context;
            _httpClient = httpClient;

        }
    }
}

using Microsoft.EntityFrameworkCore;
using ApiAdministracion.Models.LEARNHUB.DB;

namespace ApiAdministracion.DataAccess
{
    public class AdministracionDO
    {
        private readonly LearnHubContext _context;
        private readonly HttpClient _httpClient;

        public AdministracionDO(LearnHubContext context, HttpClient httpClient)
        {
            _context = context;
            _httpClient = httpClient;

        }
    }
}

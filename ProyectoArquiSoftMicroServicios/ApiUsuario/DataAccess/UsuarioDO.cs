using ApiUsuario.Entities.Response;
using ApiUsuario.Models.LEARNHUB.DB;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace ApiUsuario.DataAccess
{
    public class UsuarioDO : IUsuarioDO
    {
        private readonly LearnHubContext _context;
        private readonly HttpClient _httpClient;

        public UsuarioDO(LearnHubContext context, HttpClient httpClient)
        {
            _context = context;
            _httpClient = httpClient;

        }

        public async Task<ObtenerTodosLosValoresResultResponse> GetMessage()
        {
            ObtenerTodosLosValoresResultResponse response = new ObtenerTodosLosValoresResultResponse();

            try
            {
                var respuesta = await _context.ObtenerTodosLosValores
                    .FromSqlRaw("EXEC ObtenerTodosLosValores")
                    .ToListAsync();

                response.codigoRes = HttpStatusCode.OK;
                response.mensajeRes = "Datos obtenidos correctamente.";
            }
            catch (Exception ex)
            {
                response.codigoRes = HttpStatusCode.InternalServerError;
                response.mensajeRes = "No se pudo obtener los datos: " + ex.Message;
            }

            return response;
        }
    }
}

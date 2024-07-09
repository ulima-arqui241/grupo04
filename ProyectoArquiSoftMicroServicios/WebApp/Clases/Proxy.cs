using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace WebApp.Clases
{
    public class Proxy
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public Proxy(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }

        public async Task<string> GetMessage()
        {
            var response = await _httpClient.GetAsync("http://localhost:5236/Usuario/message");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
        public async Task<string> GetMessage2()
        {
            var response = await _httpClient.GetAsync("http://localhost:5236/Autenticacion/message");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
        public async Task<string> GetMessage3()
        {
            var response = await _httpClient.GetAsync("http://localhost:5236/Grupo/message");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
        public async Task<string> GetMessage4()
        {
            var response = await _httpClient.GetAsync("http://localhost:5236/Comunicacion/message");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
        public async Task<string> GetMessage5()
        {
            var response = await _httpClient.GetAsync("http://localhost:5236/Administracion/message");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
}

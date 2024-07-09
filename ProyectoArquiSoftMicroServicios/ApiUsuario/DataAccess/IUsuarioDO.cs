using ApiUsuario.Entities.Response;

namespace ApiUsuario.DataAccess
{
    public interface IUsuarioDO
    {
        Task<ObtenerTodosLosValoresResultResponse> GetMessage();
    }
}

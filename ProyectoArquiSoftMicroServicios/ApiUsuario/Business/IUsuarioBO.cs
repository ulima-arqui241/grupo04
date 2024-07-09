using ApiUsuario.Entities.Response;

namespace ApiUsuario.Business
{
    public interface IUsuarioBO
    {
        Task<ObtenerTodosLosValoresResultResponse> GetMessage();
    }
}

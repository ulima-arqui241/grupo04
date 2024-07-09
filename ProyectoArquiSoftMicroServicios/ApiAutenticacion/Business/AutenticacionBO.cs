using ApiAutenticacion.DataAccess;

namespace ApiAutenticacion.Business
{
    public class AutenticacionBO
    {
        private readonly IAutenticacionDO _autenticacionDO;
        public AutenticacionBO(IAutenticacionDO AutenticacionDO)
        {
            _autenticacionDO = AutenticacionDO;
        }
    }
}

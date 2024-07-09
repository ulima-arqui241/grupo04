using ApiComunicacion.DataAccess;

namespace ApiComunicacion.Business
{
    public class ComunicacionBO
    {
        private readonly IComunicacionDO _comunicacionDO;
        public ComunicacionBO(IComunicacionDO ComunicacionDO)
        {
            _comunicacionDO = ComunicacionDO;
        }
    }
}

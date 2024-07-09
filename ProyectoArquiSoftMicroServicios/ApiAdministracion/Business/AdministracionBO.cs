using ApiAdministracion.DataAccess;

namespace ApiAdministracion.Business
{
    public class AdministracionBO : IAdministracionBO
    {
        private readonly IAdministracionDO _administracionDO;
        public AdministracionBO(IAdministracionDO administracionDO)
        {
            _administracionDO = administracionDO;
        }

    }
}

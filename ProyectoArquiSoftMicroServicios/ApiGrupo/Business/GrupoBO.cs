using ApiGrupo.DataAccess;

namespace ApiGrupo.Business
{
    public class GrupoBO
    {
        private readonly IGrupoDO _grupoDO;
        public GrupoBO(IGrupoDO GrupoDO)
        {
            _grupoDO = GrupoDO;
        }
    }
}

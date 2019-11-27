using System;
using System.Collections.Generic;
using System.Text;

namespace Repositorio
{
    public class RepositorioFactory
    {
        public IUsuario CriarUsuario()
        {
            return new Usuario();
        }

        public IGrupo CriarGrupo()
        {
            return new Grupo();
        }
        
    }
}

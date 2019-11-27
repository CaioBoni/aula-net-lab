using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class UsuarioModelo
    {
        public long id { get; set; }

        public string nome { get; set; }

        public GrupoModelo Grupo { get; set; }

    }
}

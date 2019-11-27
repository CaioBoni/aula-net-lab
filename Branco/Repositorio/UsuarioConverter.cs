using Modelo;
using Dados;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositorio
{
    internal static class UsuarioConverter
    {
        internal static UsuarioModelo toUsuario(this usuario entity)
        {
            UsuarioModelo to = new UsuarioModelo();

            if (entity == null)
                return null;

            to.id = entity.id;
            to.nome = entity.nome;

            return to;
        }

        internal static void Apply(this usuario entity, UsuarioModelo to)
        {
            entity.id = to.id;
            entity.nome = to.nome;
        }
    }
}

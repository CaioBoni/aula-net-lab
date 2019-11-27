using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Modelo;
using Dados;

namespace Repositorio
{
    public class Usuario : RepositorioBase, IUsuario
    {
        public List<UsuarioModelo> GetTodos()
        {
            List<usuario> usuarios = Contexto.usuario.ToList();
            return usuarios.Select(u => u.toUsuario()).ToList();
        }
    }
}

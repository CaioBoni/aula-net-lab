using Dados;
using System;

namespace Repositorio
{
    public class RepositorioBase
    {
        public aulaEntities Contexto
        {
            get;
        }
        public RepositorioBase()
        {
            Contexto = new aulaEntities();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Teste.Domain.Entities;
using Teste.Domain.Interfaces.Repositories;
using Teste.Infra.Persistence.EF;

namespace Teste.Infra.Persistence.Repositories
{
   public class RepositoryCategoria : IRepositoryCategoria
    {
        private readonly TesteContext _context;

        public RepositoryCategoria(TesteContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Listar()
        {
            return _context.Categorias.ToList();
        }

        public Categoria ObterPorDescricao(string descricao)
        {
            return _context.Categorias.FirstOrDefault(a => a.Descricao == descricao);
        }

        //public Categoria ObterPorTipo(Domain.Enums.Enterprise_Types type)
        //{
        //    return _context.Empresas.Where(a => a.Enterprise_Types == type).FirstOrDefault();
        //}
    }
}

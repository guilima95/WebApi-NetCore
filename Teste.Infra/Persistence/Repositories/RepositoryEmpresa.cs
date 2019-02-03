using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Teste.Domain.Entities;
using Teste.Domain.Interfaces.Repositories;
using Teste.Infra.Persistence.EF;

namespace Teste.Infra.Persistence.Repositories
{
   public class RepositoryEmpresa : IRepositoryEmpresa
    {
        private readonly TesteContext _context;

        public RepositoryEmpresa(TesteContext context)
        {
            _context = context;
        }

        public IEnumerable<Empresa> Listar()
        {
            return _context.Empresas.ToList();
        }

        public Empresa ObterPorNome(string name)
        {
            return _context.Empresas.FirstOrDefault(a => a.Name == name);
        }

        public Empresa ObterPorTipo(Domain.Enums.Enterprise_Types type)
        {
            return _context.Empresas.Where(a => a.Enterprise_Types == type).FirstOrDefault();
        }
    }
}

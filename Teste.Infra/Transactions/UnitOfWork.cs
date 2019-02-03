using System;
using System.Collections.Generic;
using System.Text;
using Teste.Infra.Persistence.EF;

namespace Teste.Infra.Transactions
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TesteContext _context;

        public UnitOfWork(TesteContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
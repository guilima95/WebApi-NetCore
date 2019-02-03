using System;
using System.Collections.Generic;
using System.Text;

namespace Teste.Infra.Transactions
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}

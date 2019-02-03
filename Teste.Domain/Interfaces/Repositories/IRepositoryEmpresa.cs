using System;
using System.Collections.Generic;
using System.Text;
using Teste.Domain.Entities;

namespace Teste.Domain.Interfaces.Repositories
{
    public interface IRepositoryEmpresa
    {
        IEnumerable<Empresa> Listar();

        Empresa ObterPorNome(string name);

        Empresa ObterPorTipo(Enums.Enterprise_Types type);
    }
}

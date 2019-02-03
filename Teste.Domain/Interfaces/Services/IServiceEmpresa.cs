using System;
using System.Collections.Generic;
using System.Text;
using Teste.Domain.Arguments.Empresa;

namespace Teste.Domain.Services
{
    public interface IServiceEmpresa
    {
        IEnumerable<EmpresaResponse> Listar();

        IEnumerable<EmpresaResponse> ObterPorNome(string name);

        IEnumerable<EmpresaResponse> ListarPorTipo(int type);



    }
}

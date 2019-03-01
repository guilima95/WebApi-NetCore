using System;
using System.Collections.Generic;
using System.Text;
using Teste.Domain.Arguments.Categoria;

namespace Teste.Domain.Services
{
    public interface IServiceCategoria
    {
        IEnumerable<CategoriaResponse> Listar();

        IEnumerable<CategoriaResponse> ObterPorDescricao(string descricao);

        //IEnumerable<CategoriaResponse> ListarPorTipo(int type);



    }
}

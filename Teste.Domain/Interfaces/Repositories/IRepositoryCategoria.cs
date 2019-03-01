using System;
using System.Collections.Generic;
using System.Text;
using Teste.Domain.Entities;

namespace Teste.Domain.Interfaces.Repositories
{
    public interface IRepositoryCategoria
    {
        IEnumerable<Categoria> Listar();

        Categoria ObterPorDescricao(string descricao);

        //Categoria ObterPorTipo(Enums.Enterprise_Types type);
    }
}

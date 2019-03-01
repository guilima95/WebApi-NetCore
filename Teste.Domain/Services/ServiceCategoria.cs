using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Teste.Domain.Arguments.Categoria;
using Teste.Domain.Entities;
using Teste.Domain.Interfaces.Repositories;

namespace Teste.Domain.Services
{
    public class ServiceCategoria : IServiceCategoria
    {
        private readonly IRepositoryCategoria _repositoryCategoria;

        public ServiceCategoria(IRepositoryCategoria repositoryCategoria)
        {
            _repositoryCategoria = repositoryCategoria;
        }

        public IEnumerable<CategoriaResponse> Listar()
        {
            IEnumerable<Categoria> empresas = _repositoryCategoria.Listar();

            var response = empresas.ToList().Select(entidade => (CategoriaResponse)entidade);

            return response;
        }


        public IEnumerable<CategoriaResponse> ObterPorDescricao(string descricao)
        {
            IEnumerable<Categoria> categorias = _repositoryCategoria.Listar();

            var response = categorias.Where(a => a.Descricao == descricao).Select(entidade => (CategoriaResponse)entidade);

            return response;
        }

        //public IEnumerable<CategoriaResponse> ListarPorTipo(int type)
        //{
        //    IEnumerable<Categoria> empresas = _repositoryCategoria.Listar();

        //    var response = empresas.Where(a => a.Enterprise_Types == (Enums.Enterprise_Types)type).Select(entidade => (CategoriaResponse)entidade);

        //    return response;
        //}

    }
}

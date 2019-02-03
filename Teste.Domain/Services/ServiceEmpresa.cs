using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Teste.Domain.Arguments.Empresa;
using Teste.Domain.Entities;
using Teste.Domain.Interfaces.Repositories;

namespace Teste.Domain.Services
{
    public class ServiceEmpresa : IServiceEmpresa
    {
        private readonly IRepositoryEmpresa _repositoryEmpresa;

        public ServiceEmpresa(IRepositoryEmpresa repositoryEmpresa)
        {
            _repositoryEmpresa = repositoryEmpresa;
        }

        public IEnumerable<EmpresaResponse> Listar()
        {
            IEnumerable<Empresa> empresas = _repositoryEmpresa.Listar();

            var response = empresas.ToList().Select(entidade => (EmpresaResponse)entidade);

            return response;
        }


        public IEnumerable<EmpresaResponse> ObterPorNome(string name)
        {
            IEnumerable<Empresa> empresas = _repositoryEmpresa.Listar();

            var response = empresas.Where(a => a.Name == name).Select(entidade => (EmpresaResponse)entidade);

            return response;
        }

        public IEnumerable<EmpresaResponse> ListarPorTipo(int type)
        {
            IEnumerable<Empresa> empresas = _repositoryEmpresa.Listar();

            var response = empresas.Where(a => a.Enterprise_Types == (Enums.Enterprise_Types)type).Select(entidade => (EmpresaResponse)entidade);

            return response;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Teste.Domain.Arguments.Usuario;
using Teste.Domain.Entities;
using Teste.Domain.Interfaces.Repositories;

namespace Teste.Domain.Services
{
    public class ServiceUsuario : IServiceUsuario
    {
        private readonly IRepositoryUsuario _repositoryUsuario;

        public ServiceUsuario(IRepositoryUsuario repositoryUsuario)
        {
            _repositoryUsuario = repositoryUsuario;
        }
        public AutenticarUsuarioResponse AutenticarUsuario(AutenticarUsuarioRequest request)
        {
            if (request == null)
                throw new ApplicationException("");

            var usuario = new Usuario(request.Email, request.Password);
            usuario = _repositoryUsuario.Obter(usuario.Email, usuario.Password);

            if (usuario == null)
                throw new ApplicationException("");

            var response = (AutenticarUsuarioResponse)usuario;

            return response;


        }

        public AdicionarUsuarioResponse AdicionarUsuario(AdicionarUsuarioRequest request)
        {
            if (request == null)
                throw new ApplicationException("");

            var usuario = new Usuario(request.Email, request.Senha);

            if (usuario == null)
                throw new ApplicationException("");

            _repositoryUsuario.Adicionar(usuario);

            return new AdicionarUsuarioResponse(usuario.Id);

        }
    }
}

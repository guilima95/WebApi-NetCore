using System;
using System.Collections.Generic;
using System.Text;
using Teste.Domain.Entities;

namespace Teste.Domain.Interfaces.Repositories
{
    public interface IRepositoryUsuario
    {
        Usuario Obter(int id);
        Usuario Obter(string email, string senha);
        bool Existe(string email);

        void Adicionar(Usuario usuario);
    }
}

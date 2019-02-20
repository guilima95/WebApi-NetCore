using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Teste.Domain.Entities;
using Teste.Domain.Interfaces.Repositories;
using Teste.Infra.Persistence.EF;

namespace Teste.Infra.Persistence.Repositories
{
    public class RepositoryUsuario : IRepositoryUsuario
    {
        private readonly TesteContext _context;
        public RepositoryUsuario(TesteContext context)
        {
            _context = context;
        }

        public bool Existe(string email)
        {
            return _context.Usuarios.Any(x => x.Email == email);
        }

        public Usuario Obter(int id)
        {
            return _context.Usuarios.FirstOrDefault(x => x.Id == id);
        }

        public Usuario Obter(string email, string password)
        {
            return _context.Usuarios.FirstOrDefault(x => x.Email == email && x.Password == password);
        }

        public void Adicionar(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
        }
    }
}
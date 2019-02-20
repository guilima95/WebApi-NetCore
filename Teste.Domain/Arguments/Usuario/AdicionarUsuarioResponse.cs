using System;
using System.Collections.Generic;
using System.Text;
using Teste.Domain.Entities;

namespace Teste.Domain.Arguments.Usuario
{
    public class AdicionarUsuarioResponse
    {
        public AdicionarUsuarioResponse(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}


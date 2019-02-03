using System;
using System.Collections.Generic;
using System.Text;

namespace Teste.Domain.Arguments.Usuario
{
    public class AutenticarUsuarioResponse
    {
        public int Id { get; set; }
        public string email { get; set; }

        public static explicit operator AutenticarUsuarioResponse(Entities.Usuario entidade)
        {
            return new AutenticarUsuarioResponse()
            {
                Id = entidade.Id,
                email = entidade.Email
            };
        }
    }
}
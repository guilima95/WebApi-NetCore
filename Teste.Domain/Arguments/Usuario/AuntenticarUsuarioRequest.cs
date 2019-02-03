using System;
using System.Collections.Generic;
using System.Text;
using Teste.Domain.Entities;

namespace Teste.Domain.Arguments.Usuario
{
    public class AutenticarUsuarioRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }

       
    }
}

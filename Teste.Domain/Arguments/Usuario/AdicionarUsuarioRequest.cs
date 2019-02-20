using System;
using System.Collections.Generic;
using System.Text;

namespace Teste.Domain.Arguments.Usuario
{
   public class AdicionarUsuarioRequest
    {
        public string Email { get; set; }

        public string Senha { get; set; }
    }
}

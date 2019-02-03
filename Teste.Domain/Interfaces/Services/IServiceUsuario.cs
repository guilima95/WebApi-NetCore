using System;
using System.Collections.Generic;
using System.Text;
using Teste.Domain.Arguments.Usuario;

namespace Teste.Domain.Services
{
    public interface IServiceUsuario
    {
        AutenticarUsuarioResponse AutenticarUsuario(AutenticarUsuarioRequest request);
    }
}

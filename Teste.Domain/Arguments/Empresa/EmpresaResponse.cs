using System;
using System.Collections.Generic;
using System.Text;

namespace Teste.Domain.Arguments.Empresa
{
    public class EmpresaResponse
    {
        public string Name { get; set; }
        public Enums.Enterprise_Types Enterprise_Types { get; set; }

        public static explicit operator EmpresaResponse(Entities.Empresa usuarioIdentity)
        {
            return new EmpresaResponse()
            {

                Name = usuarioIdentity.Name,
                Enterprise_Types = usuarioIdentity.Enterprise_Types
            };
        }
    }
}

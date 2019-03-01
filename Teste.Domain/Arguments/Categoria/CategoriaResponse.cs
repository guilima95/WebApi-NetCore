using System;
using System.Collections.Generic;
using System.Text;

namespace Teste.Domain.Arguments.Categoria
{
    public class CategoriaResponse
    {
        public string Descricao { get; set; }
        //public Enums.Enterprise_Types Enterprise_Types { get; set; }

        public static explicit operator CategoriaResponse(Entities.Categoria descricaoIdentity)
        {
            return new CategoriaResponse()
            {

                Descricao = descricaoIdentity.Descricao
                
            };
        }
    }
}

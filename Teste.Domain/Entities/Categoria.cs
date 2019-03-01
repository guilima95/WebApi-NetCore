using System;
using System.Collections.Generic;
using System.Text;
using Teste.Domain.Entities.Base;
using Teste.Domain.Enums;

namespace Teste.Domain.Entities
{
    public class Categoria
    {
        protected Categoria()
        {

        }
        public Categoria(string descricao)
        {
            Descricao = descricao;
           
        }


        public int Id { get; set; }
        public string Descricao { get; set; }

       
    }
   
}



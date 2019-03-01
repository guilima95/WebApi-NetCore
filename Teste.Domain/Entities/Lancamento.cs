using System;
using System.Collections.Generic;
using System.Text;

namespace Teste.Domain.Entities
{
    public class Lancamento
    {
        protected Lancamento()
        {

        }
        public int id { get; set; }
        public string valor { get; set; }

        public DateTime data { get; set; }

        public string descricao { get; set; }

        public bool tipo { get; set; }

        public Usuario idUsuario { get; set; }
    }
}

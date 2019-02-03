using System;
using System.Collections.Generic;
using System.Text;
using Teste.Domain.Entities.Base;

namespace Teste.Domain.Entities
{
    public class Usuario : EntityBase
    {

        protected Usuario()
        {

        }

        public Usuario(string email, string password)
        {
            Email = email;
            Password = password;
        }


        public string Email { get; set; }

        public string Password { get; set; }

    }
}

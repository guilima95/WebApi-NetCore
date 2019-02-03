using System;
using System.Collections.Generic;
using System.Text;
using Teste.Domain.Entities.Base;
using Teste.Domain.Enums;

namespace Teste.Domain.Entities
{
    public class Empresa
    {
        protected Empresa()
        {

        }
        public Empresa(string name, Enterprise_Types enterprise_Types)
        {
            Name = name;
            Enterprise_Types = enterprise_Types;
        }


        public int Id { get; set; }
        public string Name { get; set; }

        public Enums.Enterprise_Types Enterprise_Types { get; set; }
    }
   
}



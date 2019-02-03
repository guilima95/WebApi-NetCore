using System;
using System.Collections.Generic;
using System.Text;

namespace Teste.Domain.Entities.Base
{
    public abstract class EntityBase
    {
        public EntityBase()
        {
            Id = Id;
        }

        public virtual int Id { get; set; }
    }
}

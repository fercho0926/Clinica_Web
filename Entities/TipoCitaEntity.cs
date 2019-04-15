using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entities
{
    public class TipoCitaEntity
    {
        public virtual int Id { get; set; }
        public virtual string Nombre { get; set; }
        public virtual string Estado { get; set; }

        public TipoCitaEntity()
        {

        }
    }
}
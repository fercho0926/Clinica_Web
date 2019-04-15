using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using FluentNHibernate.Mapping;

namespace Entities.Mappings
{
    public class TipoCitaMap : ClassMap<TipoCitaEntity>
    {
        public TipoCitaMap()
        {
            Table("TipoCita");
            Id(x => x.Id);
            Map(x => x.Nombre).Column("Nombre");
            Map(x => x.Estado).Column("Estado");
        }
    }
}

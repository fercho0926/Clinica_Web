using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using FluentNHibernate.Mapping;

namespace Entities.Mappings
{
    public class CitaMap : ClassMap<CitaEntity>
    {
        public CitaMap()
        {
            Table("Cita");
            Id(x => x.Id);
            References(x => x.TipoCita)
                .Not.Nullable()
                .Column("IdTipoCita");
            References(x => x.Paciente)
                .Not.Nullable()
                .Column("IdPaciente");
            Map(x => x.Fecha).Column("Fecha");
            Map(x => x.Estado).Column("Estado");

        }
    }
}

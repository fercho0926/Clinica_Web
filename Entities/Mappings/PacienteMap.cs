using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using FluentNHibernate.Mapping;

namespace Entities.Mappings
{
    public class PacienteMap : ClassMap<PacienteEntity>
    {
        public PacienteMap()
        {
            Table("Paciente");
            Id(x => x.Id);
            Map(x => x.Nombres).Column("Nombres");
            Map(x => x.Apellidos).Column("Apellidos");
            Map(x => x.FechaNacimiento).Column("FechaNacimiento");
            Map(x => x.Telefono).Column("Telefono");
        }
    }
}

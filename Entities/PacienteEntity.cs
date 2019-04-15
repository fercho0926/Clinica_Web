using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entities
{
    public class PacienteEntity
    {
        public virtual int Id { get; set; }
        public virtual string Nombres { get; set; }
        public virtual string Apellidos { get; set; }
        public virtual DateTime FechaNacimiento { get; set; }
        public virtual string Telefono { get; set; }

        public PacienteEntity()
        {

        }
    }
}
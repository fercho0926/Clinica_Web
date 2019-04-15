using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entities
{
    public class CitaEntity
    {
        public virtual int Id { get; set; }
        public virtual TipoCitaEntity TipoCita { get; set; }
        public virtual PacienteEntity Paciente { get; set; }
        public virtual DateTime Fecha { get; set; }
        public virtual string Estado { get; set; }

        public CitaEntity()
        {

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Entities;
using Repository;
using Bussiness;
using Ninject;

namespace Clinica_API.Controllers
{
    public class CitaController : ApiController
    {
        private readonly ICitaBussiness _citaBussiness = new CitaBussiness();

        //[Inject]
        //private ICitaBussiness _citaBussiness { get; set; }


        public List<CitaEntity> GetAll()
        {
            return _citaBussiness.ConsultarCitas();
        }

        public CitaEntity GetById(int id)
        {
            return _citaBussiness.ConsultarCita(id);
        }

        public List<CitaEntity> GetByPaciente([FromBody]PacienteEntity paciente)
        {
            return _citaBussiness.ConsultarCitasByPaciente(paciente);
        }

        public bool Save([FromBody]CitaEntity cita)
        {
            return _citaBussiness.CrearCita(cita);
        }

        public bool Update(int id, [FromBody]CitaEntity cita)
        {
            cita.Id = id;

            return _citaBussiness.ActualizarCita(cita);
        }

        public bool Cancelar([FromBody]CitaEntity cita)
        {
            return _citaBussiness.CancelarCita(cita);
        }

        public bool Eliminar([FromBody]int id)
        {
            return _citaBussiness.EliminarCita(id);
        }

    }
}

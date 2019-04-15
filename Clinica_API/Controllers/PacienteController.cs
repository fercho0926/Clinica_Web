using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Entities;
using Bussiness;

namespace Clinica_API.Controllers
{
    public class PacienteController : ApiController
    {
        static readonly PacienteBussiness pacienteBussiness = new PacienteBussiness();

        public List<PacienteEntity> GetAll()
        {
            return pacienteBussiness.ConsultarPacientes();
        }

        public PacienteEntity GetById(int id)
        {
            return pacienteBussiness.ConsultarPaciente(id);
        }

        public bool Save([FromBody]PacienteEntity paciente)
        {
            return pacienteBussiness.CrearPaciente(paciente);
        }

        public bool Update(int id, [FromBody]PacienteEntity paciente)
        {
            paciente.Id = id;
            return pacienteBussiness.ActualizarPaciente(paciente);
        }

        public bool Delete(int id)
        {
            return pacienteBussiness.EliminarPaciente(id);
        }

    }
}

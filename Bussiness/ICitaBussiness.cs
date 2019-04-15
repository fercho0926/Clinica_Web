using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Bussiness
{
    public interface ICitaBussiness
    {

        List<CitaEntity> ConsultarCitas();

        CitaEntity ConsultarCita(int id);

        List<CitaEntity> ConsultarCitasByPaciente(PacienteEntity paciente);

        bool CrearCita(CitaEntity cita);

        bool ActualizarCita(CitaEntity cita);

        bool CancelarCita(CitaEntity cita);

        bool EliminarCita(int id);
    }
}

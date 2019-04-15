using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;
using Entities;

namespace Bussiness
{
    public class CitaBussiness : ICitaBussiness
    {
        private readonly IRepository<CitaEntity> repository = new Repository<CitaEntity>();
        private readonly ICitaRepository citaRepository = new CitaRepository();

        public List<CitaEntity> ConsultarCitas()
        {
            return repository.GetAll().ToList();
        }

        public CitaEntity ConsultarCita(int id)
        {
            return repository.Get(id);
        }

        public List<CitaEntity> ConsultarCitasByPaciente(PacienteEntity paciente)
        {
            return citaRepository.GetByPaciente(paciente);
        }

        public bool CrearCita(CitaEntity cita)
        {
            List<CitaEntity> list = citaRepository.GetByFechaAndPaciente(cita.Fecha, cita.Paciente);

            if (list.Count == 0)
            {
                repository.Save(cita);

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ActualizarCita(CitaEntity cita)
        {
            List<CitaEntity> list = citaRepository.GetByFechaAndPaciente(cita.Fecha, cita.Paciente);

            if (list.Count == 0)
            {
                repository.Update(cita);

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CancelarCita(CitaEntity cita)
        {
            CitaEntity citaConsultada = ConsultarCita(cita.Id);
            TimeSpan result = citaConsultada.Fecha.Subtract(DateTime.Now);

            if (result.TotalHours >= 24)
            {
                citaConsultada.Estado = "C";

                repository.Update(citaConsultada);

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool EliminarCita(int id)
        {
            repository.Delete(id);

            return true;
        }

    }
}

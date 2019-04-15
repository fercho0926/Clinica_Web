using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;
using Entities;

namespace Bussiness
{
    public class PacienteBussiness
    {
        private readonly IRepository<PacienteEntity> repository = new Repository<PacienteEntity>();

        public List<PacienteEntity> ConsultarPacientes()
        {
            return repository.GetAll().ToList();
        }

        public PacienteEntity ConsultarPaciente(int id)
        {
            return repository.Get(id);
        }

        public bool CrearPaciente(PacienteEntity Paciente)
        {
            repository.Save(Paciente);
            return true;
        }

        public bool ActualizarPaciente(PacienteEntity Paciente)
        {
            return repository.Update(Paciente);
        }

        public bool EliminarPaciente(int id)
        {
            repository.Delete(id);

            return true;
        }

    }
}

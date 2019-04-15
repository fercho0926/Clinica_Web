using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using Entities;

namespace Repository
{
    public class CitaRepository : ICitaRepository
    {
        public CitaRepository()
        {
        }

        public List<CitaEntity> GetByFechaAndPaciente(DateTime date, PacienteEntity paciente)
        {
            using (var session = DataBase.OpenSession())
            {
                return session.Query<CitaEntity>().Where(x => x.Paciente == paciente &&
                                                                   x.Fecha.Date == date.Date).ToList();
            }
        }

        public List<CitaEntity> GetByPaciente(PacienteEntity paciente)
        {
            using (var session = DataBase.OpenSession())
            {
                return session.Query<CitaEntity>().Where(x => x.Paciente == paciente).ToList();
            }
        }
    }

}
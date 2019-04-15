using System.Collections.Generic;
using System;
using Entities;

namespace Repository
{
    public interface ICitaRepository
    {
        List<CitaEntity> GetByFechaAndPaciente(DateTime date, PacienteEntity paciente);

        List<CitaEntity> GetByPaciente(PacienteEntity paciente);
    }
}

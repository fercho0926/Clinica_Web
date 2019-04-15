using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;
using Entities;

namespace Bussiness
{
    public class TipoCitaBussiness
    {
        private readonly IRepository<TipoCitaEntity> repository = new Repository<TipoCitaEntity>();

        public List<TipoCitaEntity> ConsultarTipoCitas()
        {
            return repository.GetAll().ToList();
        }

        public TipoCitaEntity ConsultarTipoCita(int id)
        {
            return repository.Get(id);
        }

        public bool CrearTipoCita(TipoCitaEntity tipoCita)
        {
            repository.Save(tipoCita);
            return true;
        }

        public bool ActualizarTipoCita(TipoCitaEntity tipoCita)
        {
            return repository.Update(tipoCita);
        }

        public bool EliminarTipoCita(int id)
        {
            repository.Delete(id);

            return true;
        }

    }
}

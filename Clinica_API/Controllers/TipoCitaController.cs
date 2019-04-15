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
    public class TipoCitaController : ApiController
    {
        private readonly TipoCitaBussiness tipoCitaBussiness = new TipoCitaBussiness();

        public List<TipoCitaEntity> GetAll()
        {
            return tipoCitaBussiness.ConsultarTipoCitas();
        }

        public TipoCitaEntity GetById(int id)
        {
            return tipoCitaBussiness.ConsultarTipoCita(id);
        }

        public bool Save([FromBody]TipoCitaEntity TipoCita)
        {
            return tipoCitaBussiness.CrearTipoCita(TipoCita);
        }

        public bool Update(int id, [FromBody]TipoCitaEntity TipoCita)
        {
            TipoCita.Id = id;
            return tipoCitaBussiness.ActualizarTipoCita(TipoCita);
        }

        public bool Delete(int id)
        {
            return tipoCitaBussiness.EliminarTipoCita(id);
        }

    }
}

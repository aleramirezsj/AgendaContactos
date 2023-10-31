using Microsoft.EntityFrameworkCore;
using Presentacion.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.Respositories
{
    public class RepositoryContactos
    {
        public IEnumerable<Contacto> GetAll()
        {
            AgendaContext context = new AgendaContext();
            return context.Contactos.Include(c => c.Localidad).ToList();
        }
    }
}

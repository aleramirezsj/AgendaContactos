using Microsoft.EntityFrameworkCore;
using Presentacion.Modelos;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;


namespace Presentacion.Respositories
{
    public class RepositoryContactos
    {
        public IEnumerable<Contacto> GetAll()
        {
            AgendaContext context = new AgendaContext();
            return context.Contactos.Include(c => c.Localidad).ToList();
        }

        public IEnumerable<Contacto> GetAll(string textoBusqueda)
        {
            AgendaContext context= new AgendaContext();
            return context.Contactos.Where(c => c.Nombre.Contains(textoBusqueda.Trim()) || c.Apellido.Contains(textoBusqueda.Trim())).Include(c => c.Localidad).ToList();
        }
        public void Remove(int id)
        {
            AgendaContext context = new AgendaContext();
            Contacto? contacto = context.Contactos.Find(id);
            if (contacto != null)
            {
                context.Contactos.Remove(contacto);
                context.SaveChanges();
            }
            else
            {
                Debug.Print($"El contacto con el id {id} no se encontró en la base de datos, por ello no pudo eliminarse");
            }
        }

        public Contacto? GetById(int id)
        {
            AgendaContext context = new AgendaContext();
            return context.Contactos.Find(id);
        }

        public void Add(Contacto contacto)
        {
            AgendaContext context = new AgendaContext();
            context.Contactos.Add(contacto);
            context.SaveChanges();
        }
        public void Update(Contacto contacto)
        {
            AgendaContext context = new AgendaContext(); 
            context.Entry(contacto).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}

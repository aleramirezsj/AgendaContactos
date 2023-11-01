using Microsoft.EntityFrameworkCore;
using Presentacion.Modelos;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;


namespace Presentacion.Respositories
{
    public class RepositoryLocalidades
    {
        public IEnumerable<Localidad> GetAll()
        {
            AgendaContext context = new AgendaContext();
            return context.Localidades.Include(c => c.Provincia).ToList();
        }

        public IEnumerable<Localidad> GetAll(string textoBusqueda)
        {
            AgendaContext context= new AgendaContext();
            return context.Localidades.Where(c => c.Nombre.Contains(textoBusqueda.Trim()) ).Include(c => c.Provincia).ToList();
        }
        public void Remove(int id)
        {
            AgendaContext context = new AgendaContext();
            Localidad? localidad = context.Localidades.Find(id);
            if (localidad != null)
            {
                context.Localidades.Remove(localidad);
                context.SaveChanges();
            }
            else
            {
                Debug.Print($"la localidad con el id {id} no se encontró en la base de datos, por ello no pudo eliminarse");
            }
        }

        public Localidad? GetById(int id)
        {
            AgendaContext context = new AgendaContext();
            return context.Localidades.Find(id);
        }

        public void Add(Localidad localidad)
        {
            AgendaContext context = new AgendaContext();
            context.Localidades.Add(localidad);
            context.SaveChanges();
        }
        public void Update(Localidad localidad)
        {
            AgendaContext context = new AgendaContext(); 
            context.Entry(localidad).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}

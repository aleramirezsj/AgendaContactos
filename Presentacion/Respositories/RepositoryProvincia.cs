using Microsoft.EntityFrameworkCore;
using Presentacion.Modelos;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;


namespace Presentacion.Respositories
{
    public class RepositoryProvincias
    {
        public IEnumerable<Provincia> GetAll()
        {
            AgendaContext context = new AgendaContext();
            return context.Provincias.ToList();
        }

        public IEnumerable<Provincia> GetAll(string textoBusqueda)
        {
            AgendaContext context= new AgendaContext();
            return context.Provincias.Where(c => c.Nombre.Contains(textoBusqueda.Trim()) ).ToList();
        }
        public void Remove(int id)
        {
            AgendaContext context = new AgendaContext();
            Provincia? provincia = context.Provincias.Find(id);
            if (provincia != null)
            {
                context.Provincias.Remove(provincia);
                context.SaveChanges();
            }
            else
            {
                Debug.Print($"la provincia con el id {id} no se encontró en la base de datos, por ello no pudo eliminarse");
            }
        }

        public Provincia? GetById(int id)
        {
            AgendaContext context = new AgendaContext();
            return context.Provincias.Find(id);
        }

        public void Add(Provincia provincia)
        {
            AgendaContext context = new AgendaContext();
            context.Provincias.Add(provincia);
            context.SaveChanges();
        }
        public void Update(Provincia provincia)
        {
            AgendaContext context = new AgendaContext(); 
            context.Entry(provincia).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}

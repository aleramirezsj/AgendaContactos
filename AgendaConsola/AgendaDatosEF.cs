using AgendaConsola.Modelos;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AgendaConsola
{
    public class AgendaDatosEF
    {
        #region definición  de atributos
        AgendaContext db = new AgendaContext();
        IEnumerable<Contacto> contactos;
        #endregion
        public AgendaDatosEF() {
        }

        public void ListarContactos()
        {
            Console.WriteLine("        Contactos");
            Console.WriteLine("**************************");
            contactos = db.Contactos.ToList();
            if ( contactos.Count()>0 ) { 
                foreach(Contacto contacto in contactos) 
                {
                    Console.WriteLine(contacto);
                }
            }
        }
        public void InsertarUnRegistroPorConsola()
        {
            //pido el Apellido
            Console.Write("Ingrese el apellido:");
            string apellido=Console.ReadLine();
            
            //pido el nombre
            Console.Write("Ingrese el nombre:");
            string nombre=Console.ReadLine();

            //pido el email
            Console.Write("Ingrese el email:");
            string email=Console.ReadLine();

            Contacto contacto = new Contacto() { 
                Apellido=apellido, 
                Nombre=nombre, 
                Email=email
            };
            db.Contactos.Add(contacto);
            this.EjecutarComando();
        }

        public void ActualizarUnRegistro()
        {
            //pido el número de contacto a cambiar
            Console.Write("Ingrese el Nro de contacto a cambiar:");
            int idAModificar=int.Parse(Console.ReadLine());

            //pido el Apellido
            Console.Write("Ingrese el apellido:");
            string apellido = Console.ReadLine();

            //pido el nombre
            Console.Write("Ingrese el nombre:");
            string nombre = Console.ReadLine();

            //pido el email
            Console.Write("Ingrese el email:");
            string email = Console.ReadLine();

            Contacto contacto=db.Contactos.Find(idAModificar);
            contacto.Apellido = apellido;
            contacto.Nombre = nombre;
            contacto.Email = email;
            db.Entry((Contacto)contacto).State = EntityState.Modified;
            this.EjecutarComando();
        }

        private void EjecutarComando()
        {
            try
            {
                db.SaveChanges();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
                Console.WriteLine("Ha fallado la ejecución del comando");
                Console.ReadLine();
            }
        }

        public void EliminarUnRegistro()
        {
            //pido el número de contacto a cambiar
            Console.Write("Ingrese el Nro de contacto a cambiar:");
            int idAEliminar = int.Parse(Console.ReadLine());
            
            //recuperamos el contacto a eliminar desde la base de datos
            Contacto contacto = db.Contactos.Find(idAEliminar);
            db.Contactos.Remove(contacto);

            this.EjecutarComando();
        }
    }
}

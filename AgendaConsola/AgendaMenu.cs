using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaConsola
{
    public class AgendaMenu
    {
        AgendaDatosEF agendaDatos=new AgendaDatosEF();
        public AgendaMenu()
        {
            int opcion = 0;
            while (true)
            {
                MostrarMenú();
                opcion=int.Parse(Console.ReadLine());
                EjecutarOpcion(opcion);
                if (opcion == 5) break;
            }
        }

        private void EjecutarOpcion(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    Console.Clear();
                    agendaDatos.ListarContactos();
                    Console.ReadLine();
                    break;
                case 2:
                    Console.Clear();
                    agendaDatos.InsertarUnRegistroPorConsola();
                    break;
                case 3:
                    Console.Clear();
                    agendaDatos.ActualizarUnRegistro();
                    break;
                case 4:
                    Console.Clear();
                    agendaDatos.EliminarUnRegistro();
                    break;

            }
        }

        private void MostrarMenú()
        {
            Console.Clear();
            Console.WriteLine("        Agenda");
            Console.WriteLine("***********************");
            Console.WriteLine("1- Listar contactos");
            Console.WriteLine("2- Insertar un nuevo contacto");
            Console.WriteLine("3- Modificar un contacto");
            Console.WriteLine("4- Eliminar un contacto");
            Console.WriteLine("5- Salir del sistema");
            Console.Write("Ingrese una opción: ");
        }
    }
}

﻿using Microsoft.Data.SqlClient;
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
    public class AgendaDatos
    {
        #region definición  de atributos
        string cadenaConexión;
        public SqlConnection oConexión;
        SqlCommand oComandoSql = new SqlCommand();
        SqlDataReader oReader;
        #endregion
        public AgendaDatos() {
            cadenaConexión = "Data Source =.\\SQLEXPRESS;";
            cadenaConexión += "Initial Catalog = Agenda;";
            cadenaConexión += "User Id = sa; ";
            cadenaConexión += "Password = 123;";
            cadenaConexión += "MultipleActiveResultSets = True;";
            cadenaConexión += "Encrypt=False";
            Conectar();
        }
        private void Conectar()
        {
            oConexión = new SqlConnection();
            oConexión.ConnectionString = cadenaConexión;

            try
            {
                oConexión.Open();
                Debug.Print("La conexión se realizó con exito");
                //le definimos la conexión que utiliza
                oComandoSql.Connection = oConexión;

                //le definimos que va a trabajar con un comando sql escrito
                oComandoSql.CommandType = CommandType.Text;
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
                Console.WriteLine("La conexión ha fallado");
            }
        }
        public void InsertarUnRegistro()
        {
            //escribimos el comando sql en la propiedad "CommandText"
            oComandoSql.CommandText = "Insert into Contactos (apellido, nombre, email) values ('Neme','Francesca','franchusj@gmail.com')";

            this.EjecutarComando();
        }
        public void ListarContactos()
        {
            Console.WriteLine("        Contactos");
            Console.WriteLine("**************************");
            oComandoSql.CommandText = "Select * from Contactos";
            oReader = oComandoSql.ExecuteReader();
            if ( oReader.HasRows ) { 
                while ( oReader.Read())
                {
                    string contacto = oReader["id"].ToString() + " ";
                    contacto += oReader["apellido"].ToString()+" ";
                    contacto += oReader["nombre"].ToString()+" ";
                    contacto += oReader["email"].ToString();
                    Console.WriteLine(contacto);
                }
            }
            if (oReader != null) oReader.Close();
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

            //escribimos el comando sql en la propiedad "CommandText"
            oComandoSql.CommandText = $"Insert into Contactos (apellido, nombre, email) values ('{apellido}','{nombre}','{email}')";

            this.EjecutarComando();
        }
        public void InsertarUnRegistroConProcedimientosAlmacenados()
        {
            //pido el Apellido
            Console.Write("Ingrese el apellido:");
            string apellido = Console.ReadLine();

            //pido el nombre
            Console.Write("Ingrese el nombre:");
            string nombre = Console.ReadLine();

            //pido el email
            Console.Write("Ingrese el email:");
            string email = Console.ReadLine();

            //definimos que el comandosql trabaja con procedimientos almacenados
            oComandoSql.CommandType = CommandType.StoredProcedure;
            //escribimos el nombre del procedimiento almacenado
            oComandoSql.CommandText = "InsertarContacto";
            oComandoSql.Parameters.AddWithValue("@ParamApellido", apellido);
            oComandoSql.Parameters.AddWithValue("@ParamNombre", nombre);
            oComandoSql.Parameters.AddWithValue("@ParamEmail", email);

            this.EjecutarComando();
            oComandoSql.CommandType = CommandType.Text;
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

            //escribimos el comando sql en la propiedad "CommandText"
            oComandoSql.CommandText = $"UPDATE Contactos SET apellido='{apellido}', nombre='{nombre}', email='{email}' WHERE id={idAModificar}";

            this.EjecutarComando();

        }

        private void EjecutarComando()
        {
            try
            {
                //ejecutamos el comando con el método que no retorna datos
                int filasAfectadas = oComandoSql.ExecuteNonQuery();
                Console.WriteLine($"{filasAfectadas} filas actualizadas");
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

            //escribimos el comando sql en la propiedad "CommandText"
            oComandoSql.CommandText = $"DELETE FROM Contactos WHERE id={idAEliminar}";

            this.EjecutarComando();
        }
    }
}

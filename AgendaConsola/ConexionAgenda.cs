using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaConsola
{
    public class ConexionAgenda
    {
        string cadenaConexión;
        public SqlConnection oConexión;
        SqlCommand oComandoSql = new SqlCommand();
        SqlDataReader oReader;
        public ConexionAgenda() {
            cadenaConexión = "Data Source =.\\SQLEXPRESS;";
            cadenaConexión += "Initial Catalog = Agenda;";
            cadenaConexión += "User Id = sa; ";
            cadenaConexión += "Password = 123;";
            cadenaConexión += "MultipleActiveResultSets = True;";
            cadenaConexión += "Encrypt=False";
        }
        public void Conectar()
        {
            oConexión = new SqlConnection(cadenaConexión);

            try
            {
                oConexión.Open();
                Console.WriteLine("La conexión se realizó con exito");
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

            try
            {
                //ejecutamos el comando con el método que no retorna datos
                int filasAfectadas = oComandoSql.ExecuteNonQuery();
                Console.WriteLine($"{filasAfectadas} filas afectadas");
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
                Console.WriteLine("Ha fallado la ejecución del comando");
            }
        }
        public void ListarContactos()
        {
            oComandoSql.CommandText = "Select * from Contactos";
            oReader = oComandoSql.ExecuteReader();
            if ( oReader.HasRows ) { 
                while ( oReader.Read())
                {
                    string contacto = oReader["apellido"].ToString()+" ";
                    contacto += oReader["nombre"].ToString()+" ";
                    contacto += oReader["email"].ToString();
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

            //escribimos el comando sql en la propiedad "CommandText"
            oComandoSql.CommandText = $"Insert into Contactos (apellido, nombre, email) values ('{apellido}','{nombre}','{email}')";

            try
            {
                //ejecutamos el comando con el método que no retorna datos
                int filasAfectadas = oComandoSql.ExecuteNonQuery();
                Console.WriteLine($"{filasAfectadas} filas afectadas");
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
                Console.WriteLine("Ha fallado la ejecución del comando");
            }
        }
    }
}

using AgendaConsola;
using Microsoft.Data.SqlClient;
using System.Data;

public class Program
{
    private static void Main(string[] args)
    {
        ConexionAgenda conexionAgenda = new ConexionAgenda();
        conexionAgenda.Conectar();

        //conexionAgenda.InsertarUnRegistro();
        conexionAgenda.InsertarUnRegistroPorConsola();

        conexionAgenda.ListarContactos();
        
        
    }
}
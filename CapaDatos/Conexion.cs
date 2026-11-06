using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    // Clase que se encarga de conectarse a la base de datos de SQL Server
    public class Conexion
    {
        // si el servidor tiene otro nombre hay que cambiarlo aca
        private static string cadena = @"Server=.\SQLEXPRESS;Database=PanolEscolar;Trusted_Connection=True;TrustServerCertificate=True;";

        public static SqlConnection ObtenerConexion()
        {
            SqlConnection con = new SqlConnection(cadena);
            con.Open();
            return con;
        }
    }
}

using CapaDatos.Entidades;
using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    // Hace las consultas a la tabla Historial
    public class HistorialDatos
    {
        public void Insertar(Historial historial)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Historial (IdHerramienta, Fecha, Estado, Detalle) VALUES (@id, @fecha, @estado, @detalle)", con);
                cmd.Parameters.AddWithValue("@id", historial.IdHerramienta);
                cmd.Parameters.AddWithValue("@fecha", historial.Fecha);
                cmd.Parameters.AddWithValue("@estado", historial.Estado);
                cmd.Parameters.AddWithValue("@detalle", historial.Detalle);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Historial> ListarPorHerramienta(int idHerramienta)
        {
            return Consultar("WHERE hi.IdHerramienta = @id", idHerramienta);
        }

        public List<Historial> ListarDanadas()
        {
            return Consultar("WHERE hi.Estado = 'Dañada'", 0);
        }

        private List<Historial> Consultar(string filtro, int idHerramienta)
        {
            List<Historial> lista = new List<Historial>();
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT hi.IdHistorial, hi.IdHerramienta, h.Nombre, hi.Fecha, hi.Estado, hi.Detalle " +
                    "FROM Historial hi INNER JOIN Herramientas h ON hi.IdHerramienta = h.IdHerramienta " +
                    filtro + " ORDER BY hi.IdHistorial DESC", con);
                cmd.Parameters.AddWithValue("@id", idHerramienta);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Historial hi = new Historial();
                    hi.IdHistorial = dr.GetInt32(0);
                    hi.IdHerramienta = dr.GetInt32(1);
                    hi.NombreHerramienta = dr.GetString(2);
                    hi.Fecha = dr.GetDateTime(3);
                    hi.Estado = dr.GetString(4);
                    hi.Detalle = dr.IsDBNull(5) ? "" : dr.GetString(5);
                    lista.Add(hi);
                }
            }
            return lista;
        }
    }
}

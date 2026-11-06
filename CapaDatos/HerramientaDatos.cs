using CapaDatos.Entidades;
using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    // Hace las consultas a la tabla Herramientas
    public class HerramientaDatos
    {
        public List<Herramienta> Listar()
        {
            List<Herramienta> lista = new List<Herramienta>();
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SELECT IdHerramienta, Nombre, CantidadTotal, Disponibles, Danadas FROM Herramientas ORDER BY Nombre", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(LeerHerramienta(dr));
                }
            }
            return lista;
        }

        public Herramienta BuscarPorId(int idHerramienta)
        {
            Herramienta herramienta = null;
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SELECT IdHerramienta, Nombre, CantidadTotal, Disponibles, Danadas FROM Herramientas WHERE IdHerramienta = @id", con);
                cmd.Parameters.AddWithValue("@id", idHerramienta);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    herramienta = LeerHerramienta(dr);
                }
            }
            return herramienta;
        }

        // guarda la herramienta y devuelve el id que le dio la base de datos
        public int Insertar(Herramienta herramienta)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Herramientas (Nombre, CantidadTotal, Disponibles, Danadas) " +
                                                "VALUES (@nombre, @total, @disponibles, @danadas); SELECT SCOPE_IDENTITY();", con);
                cmd.Parameters.AddWithValue("@nombre", herramienta.Nombre);
                cmd.Parameters.AddWithValue("@total", herramienta.CantidadTotal);
                cmd.Parameters.AddWithValue("@disponibles", herramienta.Disponibles);
                cmd.Parameters.AddWithValue("@danadas", herramienta.Danadas);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        // guarda los cambios de stock (disponibles y dañadas)
        public void ActualizarStock(Herramienta herramienta)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("UPDATE Herramientas SET Disponibles = @disponibles, Danadas = @danadas WHERE IdHerramienta = @id", con);
                cmd.Parameters.AddWithValue("@disponibles", herramienta.Disponibles);
                cmd.Parameters.AddWithValue("@danadas", herramienta.Danadas);
                cmd.Parameters.AddWithValue("@id", herramienta.IdHerramienta);
                cmd.ExecuteNonQuery();
            }
        }

        private Herramienta LeerHerramienta(SqlDataReader dr)
        {
            Herramienta h = new Herramienta();
            h.IdHerramienta = dr.GetInt32(0);
            h.Nombre = dr.GetString(1);
            h.CantidadTotal = dr.GetInt32(2);
            h.Disponibles = dr.GetInt32(3);
            h.Danadas = dr.GetInt32(4);
            return h;
        }
    }
}

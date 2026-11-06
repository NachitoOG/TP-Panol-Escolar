using CapaDatos.Entidades;
using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    // Hace las consultas a la tabla Prestamos
    public class PrestamoDatos
    {
        public List<Prestamo> Listar()
        {
            List<Prestamo> lista = new List<Prestamo>();
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT p.IdPrestamo, p.IdAlumno, p.IdHerramienta, a.Nombre, h.Nombre, p.Cantidad, " +
                    "p.FechaPrestamo, p.FechaDevolucion, p.Estado " +
                    "FROM Prestamos p " +
                    "INNER JOIN Alumnos a ON p.IdAlumno = a.IdAlumno " +
                    "INNER JOIN Herramientas h ON p.IdHerramienta = h.IdHerramienta " +
                    "ORDER BY p.IdPrestamo DESC", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Prestamo p = new Prestamo();
                    p.IdPrestamo = dr.GetInt32(0);
                    p.IdAlumno = dr.GetInt32(1);
                    p.IdHerramienta = dr.GetInt32(2);
                    p.NombreAlumno = dr.GetString(3);
                    p.NombreHerramienta = dr.GetString(4);
                    p.Cantidad = dr.GetInt32(5);
                    p.FechaPrestamo = dr.GetDateTime(6);
                    if (!dr.IsDBNull(7))
                    {
                        p.FechaDevolucion = dr.GetDateTime(7);
                    }
                    p.Estado = dr.GetString(8);
                    lista.Add(p);
                }
            }
            return lista;
        }

        public Prestamo BuscarPorId(int idPrestamo)
        {
            // reutilizo Listar y busco el que tiene ese id
            foreach (Prestamo p in Listar())
            {
                if (p.IdPrestamo == idPrestamo)
                {
                    return p;
                }
            }
            return null;
        }

        public void Insertar(Prestamo prestamo)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Prestamos (IdAlumno, IdHerramienta, Cantidad, FechaPrestamo, Estado) " +
                                                "VALUES (@alumno, @herramienta, @cantidad, @fecha, @estado)", con);
                cmd.Parameters.AddWithValue("@alumno", prestamo.IdAlumno);
                cmd.Parameters.AddWithValue("@herramienta", prestamo.IdHerramienta);
                cmd.Parameters.AddWithValue("@cantidad", prestamo.Cantidad);
                cmd.Parameters.AddWithValue("@fecha", prestamo.FechaPrestamo);
                cmd.Parameters.AddWithValue("@estado", prestamo.Estado);
                cmd.ExecuteNonQuery();
            }
        }

        public void RegistrarDevolucion(Prestamo prestamo)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("UPDATE Prestamos SET FechaDevolucion = @fecha, Estado = @estado WHERE IdPrestamo = @id", con);
                cmd.Parameters.AddWithValue("@fecha", prestamo.FechaDevolucion);
                cmd.Parameters.AddWithValue("@estado", prestamo.Estado);
                cmd.Parameters.AddWithValue("@id", prestamo.IdPrestamo);
                cmd.ExecuteNonQuery();
            }
        }
    }
}

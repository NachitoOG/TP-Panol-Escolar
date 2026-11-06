using CapaDatos.Entidades;
using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    // Hace las consultas a la tabla Alumnos
    public class AlumnoDatos
    {
        public List<Alumno> Listar()
        {
            List<Alumno> lista = new List<Alumno>();
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SELECT IdAlumno, Dni, Nombre, Curso, Sancionado FROM Alumnos ORDER BY Nombre", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(LeerAlumno(dr));
                }
            }
            return lista;
        }

        public Alumno BuscarPorDni(string dni)
        {
            Alumno alumno = null;
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SELECT IdAlumno, Dni, Nombre, Curso, Sancionado FROM Alumnos WHERE Dni = @dni", con);
                cmd.Parameters.AddWithValue("@dni", dni);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    alumno = LeerAlumno(dr);
                }
            }
            return alumno;   // si no lo encuentra devuelve null
        }

        public void Insertar(Alumno alumno)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Alumnos (Dni, Nombre, Curso, Sancionado) VALUES (@dni, @nombre, @curso, @sancionado)", con);
                cmd.Parameters.AddWithValue("@dni", alumno.Dni);
                cmd.Parameters.AddWithValue("@nombre", alumno.Nombre);
                cmd.Parameters.AddWithValue("@curso", alumno.Curso);
                cmd.Parameters.AddWithValue("@sancionado", alumno.Sancionado);
                cmd.ExecuteNonQuery();
            }
        }

        public void CambiarSancion(int idAlumno, bool sancionado)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("UPDATE Alumnos SET Sancionado = @sancionado WHERE IdAlumno = @id", con);
                cmd.Parameters.AddWithValue("@sancionado", sancionado);
                cmd.Parameters.AddWithValue("@id", idAlumno);
                cmd.ExecuteNonQuery();
            }
        }

        // pasa una fila de la consulta a un objeto Alumno
        private Alumno LeerAlumno(SqlDataReader dr)
        {
            Alumno a = new Alumno();
            a.IdAlumno = dr.GetInt32(0);
            a.Dni = dr.GetString(1);
            a.Nombre = dr.GetString(2);
            a.Curso = dr.GetString(3);
            a.Sancionado = dr.GetBoolean(4);
            return a;
        }
    }
}

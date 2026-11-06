using CapaDatos;
using CapaDatos.Entidades;

namespace CapaNegocio
{
    // Reglas del sistema para los alumnos
    public class AlumnoNegocio
    {
        private AlumnoDatos alumnoDatos = new AlumnoDatos();

        public List<Alumno> Listar()
        {
            return alumnoDatos.Listar();
        }

        public void Agregar(string dni, string nombre, string curso)
        {
            dni = dni.Trim();
            nombre = nombre.Trim();
            curso = curso.Trim();

            if (dni == "" || nombre == "" || curso == "")
            {
                throw new Exception("Complete todos los campos");
            }
            if (!dni.All(char.IsDigit))
            {
                throw new Exception("El DNI tiene que tener solo números");
            }
            if (alumnoDatos.BuscarPorDni(dni) != null)
            {
                throw new Exception("Ya existe un alumno con ese DNI");
            }

            Alumno alumno = new Alumno(dni, nombre, curso);
            alumnoDatos.Insertar(alumno);
        }

        public void QuitarSancion(int idAlumno)
        {
            alumnoDatos.CambiarSancion(idAlumno, false);
        }
    }
}

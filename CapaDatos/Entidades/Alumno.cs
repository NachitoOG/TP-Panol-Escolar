namespace CapaDatos.Entidades
{
    // Representa a un alumno que puede pedir herramientas en el pañol
    public class Alumno
    {
        public int IdAlumno { get; set; }
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string Curso { get; set; }
        public bool Sancionado { get; set; }

        public Alumno()
        {
        }

        public Alumno(string dni, string nombre, string curso)
        {
            Dni = dni;
            Nombre = nombre;
            Curso = curso;
            Sancionado = false;
        }

        // un alumno puede pedir herramientas si no esta sancionado
        public bool PuedePedirHerramientas()
        {
            return !Sancionado;
        }
    }
}

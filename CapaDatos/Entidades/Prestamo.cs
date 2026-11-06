namespace CapaDatos.Entidades
{
    // Representa un prestamo de una herramienta a un alumno
    public class Prestamo
    {
        public int IdPrestamo { get; set; }
        public int IdAlumno { get; set; }
        public int IdHerramienta { get; set; }
        public string NombreAlumno { get; set; }
        public string NombreHerramienta { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime? FechaDevolucion { get; set; }   // puede no tener fecha si no se devolvio
        public string Estado { get; set; }

        public Prestamo()
        {
        }

        public Prestamo(Alumno alumno, Herramienta herramienta, int cantidad)
        {
            IdAlumno = alumno.IdAlumno;
            IdHerramienta = herramienta.IdHerramienta;
            NombreAlumno = alumno.Nombre;
            NombreHerramienta = herramienta.Nombre;
            Cantidad = cantidad;
            FechaPrestamo = DateTime.Now;
            Estado = "Prestado";
        }

        public bool EstaPrestado()
        {
            return Estado == "Prestado";
        }
    }
}

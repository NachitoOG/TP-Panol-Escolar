namespace CapaDatos.Entidades
{
    // Representa un movimiento en el historial de estado de una herramienta
    public class Historial
    {
        public int IdHistorial { get; set; }
        public int IdHerramienta { get; set; }
        public string NombreHerramienta { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }
        public string Detalle { get; set; }

        public Historial()
        {
        }

        public Historial(int idHerramienta, string estado, string detalle)
        {
            IdHerramienta = idHerramienta;
            Fecha = DateTime.Now;
            Estado = estado;
            Detalle = detalle;
        }
    }
}

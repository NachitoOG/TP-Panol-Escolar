namespace CapaDatos.Entidades
{
    // Representa una herramienta del pañol con su stock
    public class Herramienta
    {
        public int IdHerramienta { get; set; }
        public string Nombre { get; set; }
        public int CantidadTotal { get; set; }
        public int Disponibles { get; set; }
        public int Danadas { get; set; }

        // las prestadas no se guardan, se calculan
        public int Prestadas
        {
            get { return CantidadTotal - Disponibles - Danadas; }
        }

        public Herramienta()
        {
        }

        public Herramienta(string nombre, int cantidad)
        {
            Nombre = nombre;
            CantidadTotal = cantidad;
            Disponibles = cantidad;
            Danadas = 0;
        }

        public bool HayStock(int cantidad)
        {
            return Disponibles >= cantidad;
        }

        public void Prestar(int cantidad)
        {
            Disponibles = Disponibles - cantidad;
        }

        public void Devolver(int cantidad)
        {
            Disponibles = Disponibles + cantidad;
        }

        public void MarcarDanadas(int cantidad)
        {
            Danadas = Danadas + cantidad;
        }
    }
}

using CapaDatos;
using CapaDatos.Entidades;

namespace CapaNegocio
{
    // Reglas del sistema para el stock de herramientas y los reportes
    public class HerramientaNegocio
    {
        private HerramientaDatos herramientaDatos = new HerramientaDatos();
        private HistorialDatos historialDatos = new HistorialDatos();

        public List<Herramienta> Listar()
        {
            return herramientaDatos.Listar();
        }

        public void Agregar(string nombre, string cantidadTexto)
        {
            nombre = nombre.Trim();
            int cantidad;

            if (nombre == "" || cantidadTexto.Trim() == "")
            {
                throw new Exception("Complete todos los campos");
            }
            if (!int.TryParse(cantidadTexto, out cantidad) || cantidad <= 0)
            {
                throw new Exception("La cantidad tiene que ser un número mayor a 0");
            }

            Herramienta herramienta = new Herramienta(nombre, cantidad);
            int idNuevo = herramientaDatos.Insertar(herramienta);

            historialDatos.Insertar(new Historial(idNuevo, "Alta", "Se cargó al stock: " + cantidad + " unidades"));
        }

        // reporte de insumos dañados
        public List<Historial> ReporteDanadas()
        {
            return historialDatos.ListarDanadas();
        }

        // historial de estado de una herramienta
        public List<Historial> VerHistorial(int idHerramienta)
        {
            return historialDatos.ListarPorHerramienta(idHerramienta);
        }
    }
}

using CapaDatos;
using CapaDatos.Entidades;

namespace CapaNegocio
{
    // Reglas del sistema para los prestamos y devoluciones
    public class PrestamoNegocio
    {
        private PrestamoDatos prestamoDatos = new PrestamoDatos();
        private AlumnoDatos alumnoDatos = new AlumnoDatos();
        private HerramientaDatos herramientaDatos = new HerramientaDatos();
        private HistorialDatos historialDatos = new HistorialDatos();

        public List<Prestamo> Listar()
        {
            return prestamoDatos.Listar();
        }

        // Registra un prestamo. Si algo esta mal tira una excepcion con el mensaje del error.
        // Si sale todo bien devuelve el mensaje de confirmacion.
        public string RegistrarPrestamo(string dni, int idHerramienta, string cantidadTexto)
        {
            dni = dni.Trim();
            int cantidad;

            // 1) valido los datos
            if (dni == "" || idHerramienta <= 0 || cantidadTexto.Trim() == "")
            {
                throw new Exception("Complete todos los campos");
            }
            if (!int.TryParse(cantidadTexto, out cantidad) || cantidad <= 0)
            {
                throw new Exception("La cantidad tiene que ser un número mayor a 0");
            }

            // 2) busco al alumno
            Alumno alumno = alumnoDatos.BuscarPorDni(dni);
            if (alumno == null)
            {
                throw new Exception("No existe un alumno con ese DNI.\nPrimero hay que darlo de alta en la pestaña Alumnos.");
            }

            // 3) me fijo si tiene sancion
            if (!alumno.PuedePedirHerramientas())
            {
                throw new Exception("El alumno " + alumno.Nombre + " tiene una sanción activa.\nNo puede pedir herramientas.");
            }

            // 4) me fijo si hay stock
            Herramienta herramienta = herramientaDatos.BuscarPorId(idHerramienta);
            if (!herramienta.HayStock(cantidad))
            {
                throw new Exception("No hay stock suficiente de " + herramienta.Nombre + ".\nDisponibles: " + herramienta.Disponibles);
            }

            // 5) esta todo bien: guardo el prestamo, descuento el stock y lo anoto en el historial
            Prestamo prestamo = new Prestamo(alumno, herramienta, cantidad);
            prestamoDatos.Insertar(prestamo);

            herramienta.Prestar(cantidad);
            herramientaDatos.ActualizarStock(herramienta);

            historialDatos.Insertar(new Historial(herramienta.IdHerramienta, "Prestada", cantidad + " unidad/es a " + alumno.Nombre));

            return "Préstamo registrado:\n" + cantidad + " " + herramienta.Nombre + " para " + alumno.Nombre;
        }

        public string RegistrarDevolucion(int idPrestamo, bool vuelveDanada, string observacion)
        {
            observacion = observacion.Trim();

            Prestamo prestamo = prestamoDatos.BuscarPorId(idPrestamo);
            if (prestamo == null)
            {
                throw new Exception("Seleccione un préstamo de la lista");
            }
            if (!prestamo.EstaPrestado())
            {
                throw new Exception("Ese préstamo ya fue devuelto");
            }
            if (vuelveDanada && observacion == "")
            {
                throw new Exception("Si la herramienta vuelve dañada tiene que escribir qué le pasó en Observación");
            }

            Herramienta herramienta = herramientaDatos.BuscarPorId(prestamo.IdHerramienta);
            prestamo.FechaDevolucion = DateTime.Now;

            if (!vuelveDanada)
            {
                // vuelve al stock
                herramienta.Devolver(prestamo.Cantidad);
                prestamo.Estado = "Devuelto";
                herramientaDatos.ActualizarStock(herramienta);
                prestamoDatos.RegistrarDevolucion(prestamo);
                historialDatos.Insertar(new Historial(herramienta.IdHerramienta, "Devuelta", "Volvió en buen estado. " + observacion));
                return "Devolución registrada. La herramienta volvió al stock.";
            }
            else
            {
                // vuelve rota: no vuelve al stock, se cuenta como dañada y el alumno queda sancionado
                herramienta.MarcarDanadas(prestamo.Cantidad);
                prestamo.Estado = "Devuelto dañado";
                herramientaDatos.ActualizarStock(herramienta);
                prestamoDatos.RegistrarDevolucion(prestamo);
                alumnoDatos.CambiarSancion(prestamo.IdAlumno, true);
                historialDatos.Insertar(new Historial(herramienta.IdHerramienta, "Dañada", observacion));
                return "Devolución registrada como DAÑADA.\nEl alumno quedó sancionado.";
            }
        }
    }
}

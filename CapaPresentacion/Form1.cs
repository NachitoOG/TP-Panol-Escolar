using CapaNegocio;

namespace CapaPresentacion
{
    // CAPA DE PRESENTACION: solo muestra los datos y le pide las cosas a la capa de negocio.
    // No tiene nada de SQL ni de reglas del sistema.
    public partial class Form1 : Form
    {
        private AlumnoNegocio alumnoNegocio = new AlumnoNegocio();
        private HerramientaNegocio herramientaNegocio = new HerramientaNegocio();
        private PrestamoNegocio prestamoNegocio = new PrestamoNegocio();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbEstado.SelectedIndex = 0;
            ActualizarTodo();
        }

        // ------------------------------------------------------
        //  METODOS PARA MOSTRAR LOS DATOS
        // ------------------------------------------------------

        private void ActualizarTodo()
        {
            try
            {
                CargarPrestamos();
                CargarAlumnos();
                CargarHerramientas();
                CargarCombos();
                CargarDanadas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar con la base de datos.\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarPrestamos()
        {
            dgvPrestamos.DataSource = prestamoNegocio.Listar();
            dgvPrestamos.Columns["IdAlumno"].Visible = false;
            dgvPrestamos.Columns["IdHerramienta"].Visible = false;
            dgvPrestamos.Columns["IdPrestamo"].HeaderText = "N°";
            dgvPrestamos.Columns["NombreAlumno"].HeaderText = "Alumno";
            dgvPrestamos.Columns["NombreHerramienta"].HeaderText = "Herramienta";
            dgvPrestamos.Columns["FechaPrestamo"].HeaderText = "Fecha préstamo";
            dgvPrestamos.Columns["FechaDevolucion"].HeaderText = "Fecha devolución";
            dgvPrestamos.Columns["FechaPrestamo"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            dgvPrestamos.Columns["FechaDevolucion"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
        }

        private void CargarAlumnos()
        {
            dgvAlumnos.DataSource = alumnoNegocio.Listar();
            dgvAlumnos.Columns["IdAlumno"].HeaderText = "N°";
            dgvAlumnos.Columns["Dni"].HeaderText = "DNI";
        }

        private void CargarHerramientas()
        {
            dgvHerramientas.DataSource = herramientaNegocio.Listar();
            dgvHerramientas.Columns["IdHerramienta"].HeaderText = "N°";
            dgvHerramientas.Columns["Nombre"].HeaderText = "Herramienta";
            dgvHerramientas.Columns["CantidadTotal"].HeaderText = "Total";
            dgvHerramientas.Columns["Danadas"].HeaderText = "Dañadas";
        }

        private void CargarCombos()
        {
            cmbHerramienta.DataSource = herramientaNegocio.Listar();
            cmbHerramienta.DisplayMember = "Nombre";
            cmbHerramienta.ValueMember = "IdHerramienta";

            cmbHistorial.DataSource = herramientaNegocio.Listar();
            cmbHistorial.DisplayMember = "Nombre";
            cmbHistorial.ValueMember = "IdHerramienta";
        }

        private void CargarDanadas()
        {
            dgvDanadas.DataSource = herramientaNegocio.ReporteDanadas();
            dgvDanadas.Columns["IdHistorial"].Visible = false;
            dgvDanadas.Columns["IdHerramienta"].Visible = false;
            dgvDanadas.Columns["Estado"].Visible = false;
            dgvDanadas.Columns["NombreHerramienta"].HeaderText = "Herramienta";
            dgvDanadas.Columns["Detalle"].HeaderText = "Qué le pasó";
            dgvDanadas.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        // muestra un mensaje de error en pantalla
        private void MostrarError(string mensaje)
        {
            MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void MostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ------------------------------------------------------
        //  BOTONES DE PRESTAMOS
        // ------------------------------------------------------

        private void btnPrestar_Click(object sender, EventArgs e)
        {
            try
            {
                int idHerramienta = 0;
                if (cmbHerramienta.SelectedValue != null)
                {
                    idHerramienta = (int)cmbHerramienta.SelectedValue;
                }

                string mensaje = prestamoNegocio.RegistrarPrestamo(txtDniPrestamo.Text, idHerramienta, txtCantidad.Text);
                MostrarMensaje(mensaje);

                txtDniPrestamo.Clear();
                txtCantidad.Text = "1";
                ActualizarTodo();
            }
            catch (Exception ex)
            {
                MostrarError(ex.Message);
            }
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            if (dgvPrestamos.CurrentRow == null)
            {
                MostrarError("Seleccione un préstamo de la lista");
                return;
            }

            try
            {
                int idPrestamo = (int)dgvPrestamos.CurrentRow.Cells["IdPrestamo"].Value;
                bool vuelveDanada = cmbEstado.Text == "Dañada";

                string mensaje = prestamoNegocio.RegistrarDevolucion(idPrestamo, vuelveDanada, txtObservacion.Text);
                MostrarMensaje(mensaje);

                txtObservacion.Clear();
                cmbEstado.SelectedIndex = 0;
                ActualizarTodo();
            }
            catch (Exception ex)
            {
                MostrarError(ex.Message);
            }
        }

        // ------------------------------------------------------
        //  BOTONES DE ALUMNOS
        // ------------------------------------------------------

        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            try
            {
                alumnoNegocio.Agregar(txtDniAlumno.Text, txtNombre.Text, txtCurso.Text);
                MostrarMensaje("Alumno agregado correctamente");

                txtDniAlumno.Clear();
                txtNombre.Clear();
                txtCurso.Clear();
                ActualizarTodo();
            }
            catch (Exception ex)
            {
                MostrarError(ex.Message);
            }
        }

        private void btnQuitarSancion_Click(object sender, EventArgs e)
        {
            if (dgvAlumnos.CurrentRow == null)
            {
                MostrarError("Seleccione un alumno de la lista");
                return;
            }

            int idAlumno = (int)dgvAlumnos.CurrentRow.Cells["IdAlumno"].Value;
            alumnoNegocio.QuitarSancion(idAlumno);
            MostrarMensaje("Se le quitó la sanción al alumno");
            ActualizarTodo();
        }

        // ------------------------------------------------------
        //  BOTONES DE STOCK Y REPORTES
        // ------------------------------------------------------

        private void btnAgregarHerramienta_Click(object sender, EventArgs e)
        {
            try
            {
                herramientaNegocio.Agregar(txtNombreHerramienta.Text, txtCantHerramienta.Text);
                MostrarMensaje("Herramienta agregada al stock");

                txtNombreHerramienta.Clear();
                txtCantHerramienta.Clear();
                ActualizarTodo();
            }
            catch (Exception ex)
            {
                MostrarError(ex.Message);
            }
        }

        private void btnVerHistorial_Click(object sender, EventArgs e)
        {
            if (cmbHistorial.SelectedValue == null)
            {
                MostrarError("Elija una herramienta");
                return;
            }

            int idHerramienta = (int)cmbHistorial.SelectedValue;
            dgvHistorial.DataSource = herramientaNegocio.VerHistorial(idHerramienta);
            dgvHistorial.Columns["IdHistorial"].Visible = false;
            dgvHistorial.Columns["IdHerramienta"].Visible = false;
            dgvHistorial.Columns["NombreHerramienta"].Visible = false;
            dgvHistorial.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
        }
    }
}

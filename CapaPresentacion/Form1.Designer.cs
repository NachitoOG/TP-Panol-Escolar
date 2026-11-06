namespace CapaPresentacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            tabControl1 = new TabControl();
            tabPrestamos = new TabPage();
            grpDevolucion = new GroupBox();
            btnDevolver = new Button();
            txtObservacion = new TextBox();
            lblObservacion = new Label();
            cmbEstado = new ComboBox();
            lblComoVuelve = new Label();
            dgvPrestamos = new DataGridView();
            grpNuevoPrestamo = new GroupBox();
            btnPrestar = new Button();
            txtCantidad = new TextBox();
            lblCantidad = new Label();
            cmbHerramienta = new ComboBox();
            lblHerramienta = new Label();
            txtDniPrestamo = new TextBox();
            lblDni = new Label();
            tabAlumnos = new TabPage();
            btnQuitarSancion = new Button();
            dgvAlumnos = new DataGridView();
            grpAlumno = new GroupBox();
            btnAgregarAlumno = new Button();
            txtCurso = new TextBox();
            lblCurso = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            txtDniAlumno = new TextBox();
            lblDniAlumno = new Label();
            tabStock = new TabPage();
            dgvHerramientas = new DataGridView();
            grpHerramienta = new GroupBox();
            btnAgregarHerramienta = new Button();
            txtCantHerramienta = new TextBox();
            lblCantHerramienta = new Label();
            txtNombreHerramienta = new TextBox();
            lblNombreHerramienta = new Label();
            tabReportes = new TabPage();
            dgvHistorial = new DataGridView();
            btnVerHistorial = new Button();
            cmbHistorial = new ComboBox();
            lblHistorial = new Label();
            dgvDanadas = new DataGridView();
            lblDanadas = new Label();
            tabControl1.SuspendLayout();
            tabPrestamos.SuspendLayout();
            grpDevolucion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).BeginInit();
            grpNuevoPrestamo.SuspendLayout();
            tabAlumnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            grpAlumno.SuspendLayout();
            tabStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHerramientas).BeginInit();
            grpHerramienta.SuspendLayout();
            tabReportes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDanadas).BeginInit();
            SuspendLayout();
            //
            // lblTitulo
            //
            lblTitulo.BackColor = Color.SteelBlue;
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Arial", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(900, 40);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "PAÑOL ESCOLAR - Gestión de Préstamos";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            //
            // tabControl1
            //
            tabControl1.Controls.Add(tabPrestamos);
            tabControl1.Controls.Add(tabAlumnos);
            tabControl1.Controls.Add(tabStock);
            tabControl1.Controls.Add(tabReportes);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 40);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(900, 500);
            tabControl1.TabIndex = 1;
            //
            // tabPrestamos
            //
            tabPrestamos.Controls.Add(grpDevolucion);
            tabPrestamos.Controls.Add(dgvPrestamos);
            tabPrestamos.Controls.Add(grpNuevoPrestamo);
            tabPrestamos.Location = new Point(4, 24);
            tabPrestamos.Name = "tabPrestamos";
            tabPrestamos.Padding = new Padding(3);
            tabPrestamos.Size = new Size(892, 472);
            tabPrestamos.TabIndex = 0;
            tabPrestamos.Text = "Préstamos";
            tabPrestamos.UseVisualStyleBackColor = true;
            //
            // grpDevolucion
            //
            grpDevolucion.Controls.Add(btnDevolver);
            grpDevolucion.Controls.Add(txtObservacion);
            grpDevolucion.Controls.Add(lblObservacion);
            grpDevolucion.Controls.Add(cmbEstado);
            grpDevolucion.Controls.Add(lblComoVuelve);
            grpDevolucion.Location = new Point(8, 395);
            grpDevolucion.Name = "grpDevolucion";
            grpDevolucion.Size = new Size(874, 65);
            grpDevolucion.TabIndex = 2;
            grpDevolucion.TabStop = false;
            grpDevolucion.Text = "Devolución (seleccione un préstamo de la lista)";
            //
            // btnDevolver
            //
            btnDevolver.BackColor = Color.DarkOrange;
            btnDevolver.ForeColor = Color.White;
            btnDevolver.Location = new Point(680, 22);
            btnDevolver.Name = "btnDevolver";
            btnDevolver.Size = new Size(180, 32);
            btnDevolver.TabIndex = 4;
            btnDevolver.Text = "Registrar devolución";
            btnDevolver.UseVisualStyleBackColor = false;
            btnDevolver.Click += btnDevolver_Click;
            //
            // txtObservacion
            //
            txtObservacion.Location = new Point(345, 27);
            txtObservacion.Name = "txtObservacion";
            txtObservacion.Size = new Size(310, 23);
            txtObservacion.TabIndex = 3;
            //
            // lblObservacion
            //
            lblObservacion.AutoSize = true;
            lblObservacion.Location = new Point(265, 30);
            lblObservacion.Name = "lblObservacion";
            lblObservacion.Size = new Size(75, 15);
            lblObservacion.TabIndex = 2;
            lblObservacion.Text = "Observación:";
            //
            // cmbEstado
            //
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Buen estado", "Dañada" });
            cmbEstado.Location = new Point(100, 27);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(140, 23);
            cmbEstado.TabIndex = 1;
            //
            // lblComoVuelve
            //
            lblComoVuelve.AutoSize = true;
            lblComoVuelve.Location = new Point(12, 30);
            lblComoVuelve.Name = "lblComoVuelve";
            lblComoVuelve.Size = new Size(80, 15);
            lblComoVuelve.TabIndex = 0;
            lblComoVuelve.Text = "Cómo vuelve:";
            //
            // dgvPrestamos
            //
            dgvPrestamos.AllowUserToAddRows = false;
            dgvPrestamos.AllowUserToDeleteRows = false;
            dgvPrestamos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPrestamos.BackgroundColor = Color.White;
            dgvPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrestamos.Location = new Point(8, 82);
            dgvPrestamos.MultiSelect = false;
            dgvPrestamos.Name = "dgvPrestamos";
            dgvPrestamos.ReadOnly = true;
            dgvPrestamos.RowHeadersVisible = false;
            dgvPrestamos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrestamos.Size = new Size(874, 305);
            dgvPrestamos.TabIndex = 1;
            //
            // grpNuevoPrestamo
            //
            grpNuevoPrestamo.Controls.Add(btnPrestar);
            grpNuevoPrestamo.Controls.Add(txtCantidad);
            grpNuevoPrestamo.Controls.Add(lblCantidad);
            grpNuevoPrestamo.Controls.Add(cmbHerramienta);
            grpNuevoPrestamo.Controls.Add(lblHerramienta);
            grpNuevoPrestamo.Controls.Add(txtDniPrestamo);
            grpNuevoPrestamo.Controls.Add(lblDni);
            grpNuevoPrestamo.Location = new Point(8, 8);
            grpNuevoPrestamo.Name = "grpNuevoPrestamo";
            grpNuevoPrestamo.Size = new Size(874, 65);
            grpNuevoPrestamo.TabIndex = 0;
            grpNuevoPrestamo.TabStop = false;
            grpNuevoPrestamo.Text = "Nuevo préstamo";
            //
            // btnPrestar
            //
            btnPrestar.BackColor = Color.ForestGreen;
            btnPrestar.ForeColor = Color.White;
            btnPrestar.Location = new Point(680, 22);
            btnPrestar.Name = "btnPrestar";
            btnPrestar.Size = new Size(180, 32);
            btnPrestar.TabIndex = 6;
            btnPrestar.Text = "Registrar préstamo";
            btnPrestar.UseVisualStyleBackColor = false;
            btnPrestar.Click += btnPrestar_Click;
            //
            // txtCantidad
            //
            txtCantidad.Location = new Point(610, 27);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(50, 23);
            txtCantidad.TabIndex = 5;
            txtCantidad.Text = "1";
            //
            // lblCantidad
            //
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(546, 30);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(58, 15);
            lblCantidad.TabIndex = 4;
            lblCantidad.Text = "Cantidad:";
            //
            // cmbHerramienta
            //
            cmbHerramienta.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHerramienta.FormattingEnabled = true;
            cmbHerramienta.Location = new Point(320, 27);
            cmbHerramienta.Name = "cmbHerramienta";
            cmbHerramienta.Size = new Size(210, 23);
            cmbHerramienta.TabIndex = 3;
            //
            // lblHerramienta
            //
            lblHerramienta.AutoSize = true;
            lblHerramienta.Location = new Point(240, 30);
            lblHerramienta.Name = "lblHerramienta";
            lblHerramienta.Size = new Size(76, 15);
            lblHerramienta.TabIndex = 2;
            lblHerramienta.Text = "Herramienta:";
            //
            // txtDniPrestamo
            //
            txtDniPrestamo.Location = new Point(115, 27);
            txtDniPrestamo.Name = "txtDniPrestamo";
            txtDniPrestamo.Size = new Size(110, 23);
            txtDniPrestamo.TabIndex = 1;
            //
            // lblDni
            //
            lblDni.AutoSize = true;
            lblDni.Location = new Point(12, 30);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(92, 15);
            lblDni.TabIndex = 0;
            lblDni.Text = "DNI del alumno:";
            //
            // tabAlumnos
            //
            tabAlumnos.Controls.Add(btnQuitarSancion);
            tabAlumnos.Controls.Add(dgvAlumnos);
            tabAlumnos.Controls.Add(grpAlumno);
            tabAlumnos.Location = new Point(4, 24);
            tabAlumnos.Name = "tabAlumnos";
            tabAlumnos.Padding = new Padding(3);
            tabAlumnos.Size = new Size(892, 472);
            tabAlumnos.TabIndex = 1;
            tabAlumnos.Text = "Alumnos";
            tabAlumnos.UseVisualStyleBackColor = true;
            //
            // btnQuitarSancion
            //
            btnQuitarSancion.Location = new Point(8, 425);
            btnQuitarSancion.Name = "btnQuitarSancion";
            btnQuitarSancion.Size = new Size(260, 32);
            btnQuitarSancion.TabIndex = 2;
            btnQuitarSancion.Text = "Quitar sanción al alumno seleccionado";
            btnQuitarSancion.UseVisualStyleBackColor = true;
            btnQuitarSancion.Click += btnQuitarSancion_Click;
            //
            // dgvAlumnos
            //
            dgvAlumnos.AllowUserToAddRows = false;
            dgvAlumnos.AllowUserToDeleteRows = false;
            dgvAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlumnos.BackgroundColor = Color.White;
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnos.Location = new Point(8, 82);
            dgvAlumnos.MultiSelect = false;
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.ReadOnly = true;
            dgvAlumnos.RowHeadersVisible = false;
            dgvAlumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlumnos.Size = new Size(874, 335);
            dgvAlumnos.TabIndex = 1;
            //
            // grpAlumno
            //
            grpAlumno.Controls.Add(btnAgregarAlumno);
            grpAlumno.Controls.Add(txtCurso);
            grpAlumno.Controls.Add(lblCurso);
            grpAlumno.Controls.Add(txtNombre);
            grpAlumno.Controls.Add(lblNombre);
            grpAlumno.Controls.Add(txtDniAlumno);
            grpAlumno.Controls.Add(lblDniAlumno);
            grpAlumno.Location = new Point(8, 8);
            grpAlumno.Name = "grpAlumno";
            grpAlumno.Size = new Size(874, 65);
            grpAlumno.TabIndex = 0;
            grpAlumno.TabStop = false;
            grpAlumno.Text = "Alta de alumno";
            //
            // btnAgregarAlumno
            //
            btnAgregarAlumno.Location = new Point(680, 22);
            btnAgregarAlumno.Name = "btnAgregarAlumno";
            btnAgregarAlumno.Size = new Size(180, 32);
            btnAgregarAlumno.TabIndex = 6;
            btnAgregarAlumno.Text = "Agregar alumno";
            btnAgregarAlumno.UseVisualStyleBackColor = true;
            btnAgregarAlumno.Click += btnAgregarAlumno_Click;
            //
            // txtCurso
            //
            txtCurso.Location = new Point(560, 27);
            txtCurso.Name = "txtCurso";
            txtCurso.Size = new Size(90, 23);
            txtCurso.TabIndex = 5;
            //
            // lblCurso
            //
            lblCurso.AutoSize = true;
            lblCurso.Location = new Point(512, 30);
            lblCurso.Name = "lblCurso";
            lblCurso.Size = new Size(41, 15);
            lblCurso.TabIndex = 4;
            lblCurso.Text = "Curso:";
            //
            // txtNombre
            //
            txtNombre.Location = new Point(290, 27);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(210, 23);
            txtNombre.TabIndex = 3;
            //
            // lblNombre
            //
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(175, 30);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(108, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre y apellido:";
            //
            // txtDniAlumno
            //
            txtDniAlumno.Location = new Point(50, 27);
            txtDniAlumno.Name = "txtDniAlumno";
            txtDniAlumno.Size = new Size(110, 23);
            txtDniAlumno.TabIndex = 1;
            //
            // lblDniAlumno
            //
            lblDniAlumno.AutoSize = true;
            lblDniAlumno.Location = new Point(12, 30);
            lblDniAlumno.Name = "lblDniAlumno";
            lblDniAlumno.Size = new Size(30, 15);
            lblDniAlumno.TabIndex = 0;
            lblDniAlumno.Text = "DNI:";
            //
            // tabStock
            //
            tabStock.Controls.Add(dgvHerramientas);
            tabStock.Controls.Add(grpHerramienta);
            tabStock.Location = new Point(4, 24);
            tabStock.Name = "tabStock";
            tabStock.Padding = new Padding(3);
            tabStock.Size = new Size(892, 472);
            tabStock.TabIndex = 2;
            tabStock.Text = "Stock de herramientas";
            tabStock.UseVisualStyleBackColor = true;
            //
            // dgvHerramientas
            //
            dgvHerramientas.AllowUserToAddRows = false;
            dgvHerramientas.AllowUserToDeleteRows = false;
            dgvHerramientas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHerramientas.BackgroundColor = Color.White;
            dgvHerramientas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHerramientas.Location = new Point(8, 82);
            dgvHerramientas.MultiSelect = false;
            dgvHerramientas.Name = "dgvHerramientas";
            dgvHerramientas.ReadOnly = true;
            dgvHerramientas.RowHeadersVisible = false;
            dgvHerramientas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHerramientas.Size = new Size(874, 378);
            dgvHerramientas.TabIndex = 1;
            //
            // grpHerramienta
            //
            grpHerramienta.Controls.Add(btnAgregarHerramienta);
            grpHerramienta.Controls.Add(txtCantHerramienta);
            grpHerramienta.Controls.Add(lblCantHerramienta);
            grpHerramienta.Controls.Add(txtNombreHerramienta);
            grpHerramienta.Controls.Add(lblNombreHerramienta);
            grpHerramienta.Location = new Point(8, 8);
            grpHerramienta.Name = "grpHerramienta";
            grpHerramienta.Size = new Size(874, 65);
            grpHerramienta.TabIndex = 0;
            grpHerramienta.TabStop = false;
            grpHerramienta.Text = "Agregar herramienta al stock";
            //
            // btnAgregarHerramienta
            //
            btnAgregarHerramienta.Location = new Point(680, 22);
            btnAgregarHerramienta.Name = "btnAgregarHerramienta";
            btnAgregarHerramienta.Size = new Size(180, 32);
            btnAgregarHerramienta.TabIndex = 4;
            btnAgregarHerramienta.Text = "Agregar al stock";
            btnAgregarHerramienta.UseVisualStyleBackColor = true;
            btnAgregarHerramienta.Click += btnAgregarHerramienta_Click;
            //
            // txtCantHerramienta
            //
            txtCantHerramienta.Location = new Point(420, 27);
            txtCantHerramienta.Name = "txtCantHerramienta";
            txtCantHerramienta.Size = new Size(60, 23);
            txtCantHerramienta.TabIndex = 3;
            //
            // lblCantHerramienta
            //
            lblCantHerramienta.AutoSize = true;
            lblCantHerramienta.Location = new Point(356, 30);
            lblCantHerramienta.Name = "lblCantHerramienta";
            lblCantHerramienta.Size = new Size(58, 15);
            lblCantHerramienta.TabIndex = 2;
            lblCantHerramienta.Text = "Cantidad:";
            //
            // txtNombreHerramienta
            //
            txtNombreHerramienta.Location = new Point(75, 27);
            txtNombreHerramienta.Name = "txtNombreHerramienta";
            txtNombreHerramienta.Size = new Size(260, 23);
            txtNombreHerramienta.TabIndex = 1;
            //
            // lblNombreHerramienta
            //
            lblNombreHerramienta.AutoSize = true;
            lblNombreHerramienta.Location = new Point(12, 30);
            lblNombreHerramienta.Name = "lblNombreHerramienta";
            lblNombreHerramienta.Size = new Size(54, 15);
            lblNombreHerramienta.TabIndex = 0;
            lblNombreHerramienta.Text = "Nombre:";
            //
            // tabReportes
            //
            tabReportes.Controls.Add(dgvHistorial);
            tabReportes.Controls.Add(btnVerHistorial);
            tabReportes.Controls.Add(cmbHistorial);
            tabReportes.Controls.Add(lblHistorial);
            tabReportes.Controls.Add(dgvDanadas);
            tabReportes.Controls.Add(lblDanadas);
            tabReportes.Location = new Point(4, 24);
            tabReportes.Name = "tabReportes";
            tabReportes.Padding = new Padding(3);
            tabReportes.Size = new Size(892, 472);
            tabReportes.TabIndex = 3;
            tabReportes.Text = "Reportes";
            tabReportes.UseVisualStyleBackColor = true;
            //
            // dgvHistorial
            //
            dgvHistorial.AllowUserToAddRows = false;
            dgvHistorial.AllowUserToDeleteRows = false;
            dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorial.BackgroundColor = Color.White;
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.Location = new Point(8, 245);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.ReadOnly = true;
            dgvHistorial.RowHeadersVisible = false;
            dgvHistorial.Size = new Size(874, 215);
            dgvHistorial.TabIndex = 5;
            //
            // btnVerHistorial
            //
            btnVerHistorial.Location = new Point(530, 208);
            btnVerHistorial.Name = "btnVerHistorial";
            btnVerHistorial.Size = new Size(120, 28);
            btnVerHistorial.TabIndex = 4;
            btnVerHistorial.Text = "Ver historial";
            btnVerHistorial.UseVisualStyleBackColor = true;
            btnVerHistorial.Click += btnVerHistorial_Click;
            //
            // cmbHistorial
            //
            cmbHistorial.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHistorial.FormattingEnabled = true;
            cmbHistorial.Location = new Point(300, 211);
            cmbHistorial.Name = "cmbHistorial";
            cmbHistorial.Size = new Size(220, 23);
            cmbHistorial.TabIndex = 3;
            //
            // lblHistorial
            //
            lblHistorial.AutoSize = true;
            lblHistorial.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblHistorial.Location = new Point(8, 213);
            lblHistorial.Name = "lblHistorial";
            lblHistorial.Size = new Size(283, 19);
            lblHistorial.TabIndex = 2;
            lblHistorial.Text = "Historial de estado de la herramienta:";
            //
            // dgvDanadas
            //
            dgvDanadas.AllowUserToAddRows = false;
            dgvDanadas.AllowUserToDeleteRows = false;
            dgvDanadas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanadas.BackgroundColor = Color.White;
            dgvDanadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanadas.Location = new Point(8, 35);
            dgvDanadas.Name = "dgvDanadas";
            dgvDanadas.ReadOnly = true;
            dgvDanadas.RowHeadersVisible = false;
            dgvDanadas.Size = new Size(874, 160);
            dgvDanadas.TabIndex = 1;
            //
            // lblDanadas
            //
            lblDanadas.AutoSize = true;
            lblDanadas.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDanadas.Location = new Point(8, 10);
            lblDanadas.Name = "lblDanadas";
            lblDanadas.Size = new Size(212, 19);
            lblDanadas.TabIndex = 0;
            lblDanadas.Text = "Reporte de insumos dañados";
            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 540);
            Controls.Add(tabControl1);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema del Pañol Escolar";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPrestamos.ResumeLayout(false);
            grpDevolucion.ResumeLayout(false);
            grpDevolucion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).EndInit();
            grpNuevoPrestamo.ResumeLayout(false);
            grpNuevoPrestamo.PerformLayout();
            tabAlumnos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            grpAlumno.ResumeLayout(false);
            grpAlumno.PerformLayout();
            tabStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHerramientas).EndInit();
            grpHerramienta.ResumeLayout(false);
            grpHerramienta.PerformLayout();
            tabReportes.ResumeLayout(false);
            tabReportes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDanadas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private TabControl tabControl1;
        private TabPage tabPrestamos;
        private TabPage tabAlumnos;
        private TabPage tabStock;
        private TabPage tabReportes;
        private GroupBox grpNuevoPrestamo;
        private Label lblDni;
        private TextBox txtDniPrestamo;
        private Label lblHerramienta;
        private ComboBox cmbHerramienta;
        private Label lblCantidad;
        private TextBox txtCantidad;
        private Button btnPrestar;
        private DataGridView dgvPrestamos;
        private GroupBox grpDevolucion;
        private Label lblComoVuelve;
        private ComboBox cmbEstado;
        private Label lblObservacion;
        private TextBox txtObservacion;
        private Button btnDevolver;
        private GroupBox grpAlumno;
        private Label lblDniAlumno;
        private TextBox txtDniAlumno;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblCurso;
        private TextBox txtCurso;
        private Button btnAgregarAlumno;
        private DataGridView dgvAlumnos;
        private Button btnQuitarSancion;
        private GroupBox grpHerramienta;
        private Label lblNombreHerramienta;
        private TextBox txtNombreHerramienta;
        private Label lblCantHerramienta;
        private TextBox txtCantHerramienta;
        private Button btnAgregarHerramienta;
        private DataGridView dgvHerramientas;
        private Label lblDanadas;
        private DataGridView dgvDanadas;
        private Label lblHistorial;
        private ComboBox cmbHistorial;
        private Button btnVerHistorial;
        private DataGridView dgvHistorial;
    }
}

namespace Final_Programacion_I_V2._0
{
    partial class FormAlumnos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAceptarNombreNuevo = new System.Windows.Forms.Button();
            this.txtNombreNuevo = new System.Windows.Forms.TextBox();
            this.lblModificarNombre = new System.Windows.Forms.Label();
            this.btnModificaciones = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(86, 32);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(106, 23);
            this.txtNombre.TabIndex = 20;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(110, 15);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 15);
            this.lblNombre.TabIndex = 19;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre});
            this.dgvAlumnos.Location = new System.Drawing.Point(11, 286);
            this.dgvAlumnos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.ReadOnly = true;
            this.dgvAlumnos.RowHeadersWidth = 62;
            this.dgvAlumnos.RowTemplate.Height = 33;
            this.dgvAlumnos.Size = new System.Drawing.Size(252, 135);
            this.dgvAlumnos.TabIndex = 26;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 150;
            // 
            // btnAceptarNombreNuevo
            // 
            this.btnAceptarNombreNuevo.Enabled = false;
            this.btnAceptarNombreNuevo.Location = new System.Drawing.Point(100, 110);
            this.btnAceptarNombreNuevo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAceptarNombreNuevo.Name = "btnAceptarNombreNuevo";
            this.btnAceptarNombreNuevo.Size = new System.Drawing.Size(78, 25);
            this.btnAceptarNombreNuevo.TabIndex = 25;
            this.btnAceptarNombreNuevo.Text = "Aceptar";
            this.btnAceptarNombreNuevo.UseVisualStyleBackColor = true;
            this.btnAceptarNombreNuevo.Click += new System.EventHandler(this.btnAceptarNombreNuevo_Click);
            // 
            // txtNombreNuevo
            // 
            this.txtNombreNuevo.Enabled = false;
            this.txtNombreNuevo.Location = new System.Drawing.Point(86, 83);
            this.txtNombreNuevo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreNuevo.Name = "txtNombreNuevo";
            this.txtNombreNuevo.Size = new System.Drawing.Size(106, 23);
            this.txtNombreNuevo.TabIndex = 24;
            this.txtNombreNuevo.TextChanged += new System.EventHandler(this.txtNombreNuevo_TextChanged);
            // 
            // lblModificarNombre
            // 
            this.lblModificarNombre.AutoSize = true;
            this.lblModificarNombre.Enabled = false;
            this.lblModificarNombre.Location = new System.Drawing.Point(100, 66);
            this.lblModificarNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModificarNombre.Name = "lblModificarNombre";
            this.lblModificarNombre.Size = new System.Drawing.Size(92, 15);
            this.lblModificarNombre.TabIndex = 23;
            this.lblModificarNombre.Text = "Nombre Nuevo:";
            this.lblModificarNombre.Click += new System.EventHandler(this.lblModificarNombre_Click);
            // 
            // btnModificaciones
            // 
            this.btnModificaciones.Location = new System.Drawing.Point(15, 228);
            this.btnModificaciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModificaciones.Name = "btnModificaciones";
            this.btnModificaciones.Size = new System.Drawing.Size(248, 33);
            this.btnModificaciones.TabIndex = 29;
            this.btnModificaciones.Text = "Modificar";
            this.btnModificaciones.UseVisualStyleBackColor = true;
            this.btnModificaciones.Click += new System.EventHandler(this.btnModificaciones_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(15, 190);
            this.btnBaja.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(248, 33);
            this.btnBaja.TabIndex = 28;
            this.btnBaja.Text = "Eliminar";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(15, 153);
            this.btnAlta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(248, 33);
            this.btnAlta.TabIndex = 27;
            this.btnAlta.Text = "Agregar";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(11, 442);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(78, 20);
            this.btnLimpiar.TabIndex = 31;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(185, 442);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(78, 20);
            this.btnSalir.TabIndex = 30;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 471);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnModificaciones);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.dgvAlumnos);
            this.Controls.Add(this.btnAceptarNombreNuevo);
            this.Controls.Add(this.txtNombreNuevo);
            this.Controls.Add(this.lblModificarNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormAlumnos";
            this.Text = "FormAlumnos";
            this.Load += new System.EventHandler(this.FormAlumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNombre;
        private Label lblNombre;
        private DataGridView dgvAlumnos;
        private DataGridViewTextBoxColumn Nombre;
        private Button btnAceptarNombreNuevo;
        private TextBox txtNombreNuevo;
        private Label lblModificarNombre;
        private Button btnModificaciones;
        private Button btnBaja;
        private Button btnAlta;
        private Button btnLimpiar;
        private Button btnSalir;
    }
}
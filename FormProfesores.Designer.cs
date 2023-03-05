namespace Final_Programacion_I_V2._0
{
    partial class FormProfesores
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
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnModificaciones = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.dgvProfesores = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAceptarNombreNuevo = new System.Windows.Forms.Button();
            this.txtNombreNuevo = new System.Windows.Forms.TextBox();
            this.lblModificarNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(12, 385);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(78, 22);
            this.btnLimpiar.TabIndex = 42;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(187, 385);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(78, 22);
            this.btnSalir.TabIndex = 41;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnModificaciones
            // 
            this.btnModificaciones.Location = new System.Drawing.Point(10, 197);
            this.btnModificaciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModificaciones.Name = "btnModificaciones";
            this.btnModificaciones.Size = new System.Drawing.Size(253, 33);
            this.btnModificaciones.TabIndex = 40;
            this.btnModificaciones.Text = "Modificar";
            this.btnModificaciones.UseVisualStyleBackColor = true;
            this.btnModificaciones.Click += new System.EventHandler(this.btnModificaciones_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(10, 164);
            this.btnBaja.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(253, 29);
            this.btnBaja.TabIndex = 39;
            this.btnBaja.Text = "Eliminar";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(10, 126);
            this.btnAlta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(253, 34);
            this.btnAlta.TabIndex = 38;
            this.btnAlta.Text = "Agregar";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // dgvProfesores
            // 
            this.dgvProfesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfesores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre});
            this.dgvProfesores.Location = new System.Drawing.Point(10, 246);
            this.dgvProfesores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvProfesores.Name = "dgvProfesores";
            this.dgvProfesores.ReadOnly = true;
            this.dgvProfesores.RowHeadersWidth = 62;
            this.dgvProfesores.RowTemplate.Height = 33;
            this.dgvProfesores.Size = new System.Drawing.Size(252, 135);
            this.dgvProfesores.TabIndex = 37;
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
            this.btnAceptarNombreNuevo.Location = new System.Drawing.Point(98, 98);
            this.btnAceptarNombreNuevo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAceptarNombreNuevo.Name = "btnAceptarNombreNuevo";
            this.btnAceptarNombreNuevo.Size = new System.Drawing.Size(78, 24);
            this.btnAceptarNombreNuevo.TabIndex = 36;
            this.btnAceptarNombreNuevo.Text = "Aceptar";
            this.btnAceptarNombreNuevo.UseVisualStyleBackColor = true;
            this.btnAceptarNombreNuevo.Click += new System.EventHandler(this.btnAceptarNombreNuevo_Click);
            // 
            // txtNombreNuevo
            // 
            this.txtNombreNuevo.Enabled = false;
            this.txtNombreNuevo.Location = new System.Drawing.Point(84, 71);
            this.txtNombreNuevo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreNuevo.Name = "txtNombreNuevo";
            this.txtNombreNuevo.Size = new System.Drawing.Size(106, 23);
            this.txtNombreNuevo.TabIndex = 35;
            // 
            // lblModificarNombre
            // 
            this.lblModificarNombre.AutoSize = true;
            this.lblModificarNombre.Enabled = false;
            this.lblModificarNombre.Location = new System.Drawing.Point(98, 52);
            this.lblModificarNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModificarNombre.Name = "lblModificarNombre";
            this.lblModificarNombre.Size = new System.Drawing.Size(92, 15);
            this.lblModificarNombre.TabIndex = 34;
            this.lblModificarNombre.Text = "Nombre Nuevo:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(84, 20);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(106, 23);
            this.txtNombre.TabIndex = 33;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(108, 3);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 15);
            this.lblNombre.TabIndex = 32;
            this.lblNombre.Text = "Nombre:";
            // 
            // FormProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 418);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnModificaciones);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.dgvProfesores);
            this.Controls.Add(this.btnAceptarNombreNuevo);
            this.Controls.Add(this.txtNombreNuevo);
            this.Controls.Add(this.lblModificarNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormProfesores";
            this.Text = "FormProfesores";
            this.Load += new System.EventHandler(this.FormProfesores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnLimpiar;
        private Button btnSalir;
        private Button btnModificaciones;
        private Button btnBaja;
        private Button btnAlta;
        private DataGridView dgvProfesores;
        private DataGridViewTextBoxColumn Nombre;
        private Button btnAceptarNombreNuevo;
        private TextBox txtNombreNuevo;
        private Label lblModificarNombre;
        private TextBox txtNombre;
        private Label lblNombre;
    }
}
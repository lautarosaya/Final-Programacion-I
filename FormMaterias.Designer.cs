namespace Final_Programacion_I_V2._0
{
    partial class FormMaterias
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
            this.dgvMaterias = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAceptarNombreNuevo = new System.Windows.Forms.Button();
            this.txtNombreNuevo = new System.Windows.Forms.TextBox();
            this.lblModificarNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(11, 446);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(78, 20);
            this.btnLimpiar.TabIndex = 53;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(182, 446);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(78, 20);
            this.btnSalir.TabIndex = 52;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnModificaciones
            // 
            this.btnModificaciones.Location = new System.Drawing.Point(11, 227);
            this.btnModificaciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModificaciones.Name = "btnModificaciones";
            this.btnModificaciones.Size = new System.Drawing.Size(249, 33);
            this.btnModificaciones.TabIndex = 51;
            this.btnModificaciones.Text = "Modificar";
            this.btnModificaciones.UseVisualStyleBackColor = true;
            this.btnModificaciones.Click += new System.EventHandler(this.btnModificaciones_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(13, 190);
            this.btnBaja.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(247, 33);
            this.btnBaja.TabIndex = 50;
            this.btnBaja.Text = "Eliminar";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(13, 153);
            this.btnAlta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(247, 33);
            this.btnAlta.TabIndex = 49;
            this.btnAlta.Text = "Agregar";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // dgvMaterias
            // 
            this.dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre});
            this.dgvMaterias.Location = new System.Drawing.Point(11, 276);
            this.dgvMaterias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvMaterias.Name = "dgvMaterias";
            this.dgvMaterias.ReadOnly = true;
            this.dgvMaterias.RowHeadersWidth = 62;
            this.dgvMaterias.RowTemplate.Height = 33;
            this.dgvMaterias.Size = new System.Drawing.Size(252, 135);
            this.dgvMaterias.TabIndex = 48;
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
            this.btnAceptarNombreNuevo.Location = new System.Drawing.Point(96, 110);
            this.btnAceptarNombreNuevo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAceptarNombreNuevo.Name = "btnAceptarNombreNuevo";
            this.btnAceptarNombreNuevo.Size = new System.Drawing.Size(78, 22);
            this.btnAceptarNombreNuevo.TabIndex = 47;
            this.btnAceptarNombreNuevo.Text = "Aceptar";
            this.btnAceptarNombreNuevo.UseVisualStyleBackColor = true;
            this.btnAceptarNombreNuevo.Click += new System.EventHandler(this.btnAceptarNombreNuevo_Click_1);
            // 
            // txtNombreNuevo
            // 
            this.txtNombreNuevo.Enabled = false;
            this.txtNombreNuevo.Location = new System.Drawing.Point(82, 83);
            this.txtNombreNuevo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreNuevo.Name = "txtNombreNuevo";
            this.txtNombreNuevo.Size = new System.Drawing.Size(106, 23);
            this.txtNombreNuevo.TabIndex = 46;
            // 
            // lblModificarNombre
            // 
            this.lblModificarNombre.AutoSize = true;
            this.lblModificarNombre.Enabled = false;
            this.lblModificarNombre.Location = new System.Drawing.Point(96, 66);
            this.lblModificarNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModificarNombre.Name = "lblModificarNombre";
            this.lblModificarNombre.Size = new System.Drawing.Size(92, 15);
            this.lblModificarNombre.TabIndex = 45;
            this.lblModificarNombre.Text = "Nombre Nuevo:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(82, 32);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(106, 23);
            this.txtNombre.TabIndex = 44;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(106, 15);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 15);
            this.lblNombre.TabIndex = 43;
            this.lblNombre.Text = "Nombre:";
            // 
            // FormMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 473);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnModificaciones);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.dgvMaterias);
            this.Controls.Add(this.btnAceptarNombreNuevo);
            this.Controls.Add(this.txtNombreNuevo);
            this.Controls.Add(this.lblModificarNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMaterias";
            this.Text = "FormMaterias";
            this.Load += new System.EventHandler(this.FormMaterias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnLimpiar;
        private Button btnSalir;
        private Button btnModificaciones;
        private Button btnBaja;
        private Button btnAlta;
        private DataGridView dgvMaterias;
        private DataGridViewTextBoxColumn Nombre;
        private Button btnAceptarNombreNuevo;
        private TextBox txtNombreNuevo;
        private Label lblModificarNombre;
        private TextBox txtNombre;
        private Label lblNombre;
    }
}
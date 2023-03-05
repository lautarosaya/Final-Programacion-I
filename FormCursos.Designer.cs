namespace Final_Programacion_I_V2._0
{
    partial class FormCursos
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
            this.lblMateria = new System.Windows.Forms.Label();
            this.cmbMateria = new System.Windows.Forms.ComboBox();
            this.lblProfesor = new System.Windows.Forms.Label();
            this.cmbProfesor = new System.Windows.Forms.ComboBox();
            this.lblAlumno = new System.Windows.Forms.Label();
            this.cmbAlumno = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dgvCurso = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCurso = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRecargar = new System.Windows.Forms.Button();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.lblCurso2 = new System.Windows.Forms.Label();
            this.txtProfesor = new System.Windows.Forms.TextBox();
            this.lblProfesor2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(27, 13);
            this.lblMateria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(50, 15);
            this.lblMateria.TabIndex = 0;
            this.lblMateria.Text = "Materia:";
            // 
            // cmbMateria
            // 
            this.cmbMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMateria.FormattingEnabled = true;
            this.cmbMateria.Location = new System.Drawing.Point(84, 11);
            this.cmbMateria.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(162, 23);
            this.cmbMateria.TabIndex = 1;
            // 
            // lblProfesor
            // 
            this.lblProfesor.AutoSize = true;
            this.lblProfesor.Location = new System.Drawing.Point(22, 45);
            this.lblProfesor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProfesor.Name = "lblProfesor";
            this.lblProfesor.Size = new System.Drawing.Size(54, 15);
            this.lblProfesor.TabIndex = 2;
            this.lblProfesor.Text = "Profesor:";
            // 
            // cmbProfesor
            // 
            this.cmbProfesor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProfesor.FormattingEnabled = true;
            this.cmbProfesor.Location = new System.Drawing.Point(84, 43);
            this.cmbProfesor.Margin = new System.Windows.Forms.Padding(2);
            this.cmbProfesor.Name = "cmbProfesor";
            this.cmbProfesor.Size = new System.Drawing.Size(162, 23);
            this.cmbProfesor.TabIndex = 3;
            // 
            // lblAlumno
            // 
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.Location = new System.Drawing.Point(22, 111);
            this.lblAlumno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(53, 15);
            this.lblAlumno.TabIndex = 4;
            this.lblAlumno.Text = "Alumno:";
            // 
            // cmbAlumno
            // 
            this.cmbAlumno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlumno.FormattingEnabled = true;
            this.cmbAlumno.Location = new System.Drawing.Point(84, 109);
            this.cmbAlumno.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAlumno.Name = "cmbAlumno";
            this.cmbAlumno.Size = new System.Drawing.Size(162, 23);
            this.cmbAlumno.TabIndex = 5;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(22, 70);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(224, 28);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // dgvCurso
            // 
            this.dgvCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre});
            this.dgvCurso.Location = new System.Drawing.Point(268, 26);
            this.dgvCurso.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCurso.Name = "dgvCurso";
            this.dgvCurso.ReadOnly = true;
            this.dgvCurso.RowHeadersWidth = 62;
            this.dgvCurso.RowTemplate.Height = 33;
            this.dgvCurso.Size = new System.Drawing.Size(252, 150);
            this.dgvCurso.TabIndex = 7;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 150;
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(268, 9);
            this.lblCurso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(38, 15);
            this.lblCurso.TabIndex = 8;
            this.lblCurso.Text = "Curso";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(22, 136);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(113, 40);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar al Curso";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(139, 136);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(107, 40);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar del Curso";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(542, 146);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(177, 31);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnRecargar
            // 
            this.btnRecargar.Location = new System.Drawing.Point(542, 111);
            this.btnRecargar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(177, 31);
            this.btnRecargar.TabIndex = 12;
            this.btnRecargar.Text = "Recargar";
            this.btnRecargar.UseVisualStyleBackColor = true;
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(592, 26);
            this.txtCurso.Margin = new System.Windows.Forms.Padding(2);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(127, 23);
            this.txtCurso.TabIndex = 13;
            // 
            // lblCurso2
            // 
            this.lblCurso2.AutoSize = true;
            this.lblCurso2.Location = new System.Drawing.Point(542, 28);
            this.lblCurso2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurso2.Name = "lblCurso2";
            this.lblCurso2.Size = new System.Drawing.Size(41, 15);
            this.lblCurso2.TabIndex = 14;
            this.lblCurso2.Text = "Curso:";
            // 
            // txtProfesor
            // 
            this.txtProfesor.Location = new System.Drawing.Point(592, 48);
            this.txtProfesor.Margin = new System.Windows.Forms.Padding(2);
            this.txtProfesor.Name = "txtProfesor";
            this.txtProfesor.Size = new System.Drawing.Size(127, 23);
            this.txtProfesor.TabIndex = 15;
            // 
            // lblProfesor2
            // 
            this.lblProfesor2.AutoSize = true;
            this.lblProfesor2.Location = new System.Drawing.Point(530, 48);
            this.lblProfesor2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProfesor2.Name = "lblProfesor2";
            this.lblProfesor2.Size = new System.Drawing.Size(54, 15);
            this.lblProfesor2.TabIndex = 16;
            this.lblProfesor2.Text = "Profesor:";
            // 
            // FormCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 195);
            this.Controls.Add(this.lblProfesor2);
            this.Controls.Add(this.txtProfesor);
            this.Controls.Add(this.lblCurso2);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.btnRecargar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.dgvCurso);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cmbAlumno);
            this.Controls.Add(this.lblAlumno);
            this.Controls.Add(this.cmbProfesor);
            this.Controls.Add(this.lblProfesor);
            this.Controls.Add(this.cmbMateria);
            this.Controls.Add(this.lblMateria);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCursos";
            this.Text = "FormCursos";
            this.Load += new System.EventHandler(this.FormCursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblMateria;
        private ComboBox cmbMateria;
        private Label lblProfesor;
        private ComboBox cmbProfesor;
        private Label lblAlumno;
        private ComboBox cmbAlumno;
        private Button btnAceptar;
        private DataGridView dgvCurso;
        private DataGridViewTextBoxColumn Nombre;
        private Label lblCurso;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnSalir;
        private Button btnRecargar;
        private TextBox txtCurso;
        private Label lblCurso2;
        private TextBox txtProfesor;
        private Label lblProfesor2;
    }
}
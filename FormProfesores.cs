using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Programacion_I_V2._0
{
    public partial class FormProfesores : Form
    {
        public FormProfesores()
        {
            InitializeComponent();
        }

        private void FormProfesores_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader profesoresArchivo = new StreamReader("profesores.txt");
                while (!profesoresArchivo.EndOfStream)
                {
                    string nombre = profesoresArchivo.ReadLine();
                    dgvProfesores.Rows.Add(nombre);
                }
                profesoresArchivo.Close();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                int bandera = 0;
                txtNombreNuevo.Text = "";
                txtNombreNuevo.Enabled = false;
                btnAceptarNombreNuevo.Enabled = false;
                if (!string.IsNullOrEmpty(txtNombre.Text))
                {
                    for (int i = 0; i < dgvProfesores.Rows.Count - 1; i++)
                    {
                        if (txtNombre.Text == dgvProfesores.Rows[i].Cells[0].Value.ToString())
                        {
                            bandera++;
                        }
                    }
                    if (bandera == 0)
                    {
                        dgvProfesores.Rows.Add(txtNombre.Text);
                    }
                    using (TextWriter tw = new StreamWriter("profesores.txt"))
                    {
                        for (int i = 0; i < dgvProfesores.Rows.Count - 1; i++)
                        {
                            for (int j = 0; j < dgvProfesores.Columns.Count; j++)
                            {
                                tw.WriteLine(dgvProfesores.Rows[i].Cells[j].Value.ToString());
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por favor ingrese un nombre en el campo de texto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            try
            {
                txtNombreNuevo.Text = "";
                txtNombreNuevo.Enabled = false;
                btnAceptarNombreNuevo.Enabled = false;
                if (!string.IsNullOrEmpty(txtNombre.Text))
                {
                    for (int i = 0; i < dgvProfesores.Rows.Count - 1; i++)
                    {
                        if (txtNombre.Text == dgvProfesores.Rows[i].Cells[0].Value.ToString())
                        {
                            dgvProfesores.Rows.RemoveAt(i);
                        }
                    }
                    using (TextWriter tw = new StreamWriter("profesores.txt"))
                    {
                        for (int i = 0; i < dgvProfesores.Rows.Count - 1; i++)
                        {
                            for (int j = 0; j < dgvProfesores.Columns.Count; j++)
                            {
                                tw.WriteLine(dgvProfesores.Rows[i].Cells[j].Value.ToString());
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por favor ingrese un nombre en el campo de texto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificaciones_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtNombre.Text))
                {
                    btnAceptarNombreNuevo.Enabled = true;
                    txtNombreNuevo.Enabled = true;
                    lblModificarNombre.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Por favor ingrese un nombre en el campo de texto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAceptarNombreNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                int bandera = 0;
                if (!string.IsNullOrEmpty(txtNombreNuevo.Text))
                {
                    for (int i = 0; i < dgvProfesores.Rows.Count - 1; i++)
                    {
                        if (txtNombreNuevo.Text == dgvProfesores.Rows[i].Cells[0].Value.ToString())
                        {
                            bandera++;
                        }
                    }
                    for (int i = 0; i < dgvProfesores.Rows.Count - 1; i++)
                    {
                        if (txtNombre.Text == dgvProfesores.Rows[i].Cells[0].Value.ToString())
                        {
                            if (bandera == 0)
                            {
                                dgvProfesores.Rows[i].Cells[0].Value = txtNombreNuevo.Text;
                            }
                        }
                    }
                    using (TextWriter tw = new StreamWriter("profesores.txt"))
                    {
                        for (int i = 0; i < dgvProfesores.Rows.Count - 1; i++)
                        {
                            for (int j = 0; j < dgvProfesores.Columns.Count; j++)
                            {
                                tw.WriteLine(dgvProfesores.Rows[i].Cells[j].Value.ToString());
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por favor ingrese un nombre en el campo de texto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtNombreNuevo.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

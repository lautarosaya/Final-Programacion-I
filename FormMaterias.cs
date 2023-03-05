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
    public partial class FormMaterias : Form
    {
        public FormMaterias()
        {
            InitializeComponent();
        }

        private void FormMaterias_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader materiasArchivo = new StreamReader("materias.txt");
                while (!materiasArchivo.EndOfStream)
                {
                    string nombre = materiasArchivo.ReadLine();
                    dgvMaterias.Rows.Add(nombre);
                }
                materiasArchivo.Close();
            }
            catch (Exception ex)
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
                    for (int i = 0; i < dgvMaterias.Rows.Count - 1; i++)
                    {
                        if (txtNombre.Text == dgvMaterias.Rows[i].Cells[0].Value.ToString())
                        {
                            bandera++;
                        }
                    }
                    if (bandera == 0)
                    {
                        dgvMaterias.Rows.Add(txtNombre.Text);
                    }
                    using (TextWriter tw = new StreamWriter("materias.txt"))
                    {
                        for (int i = 0; i < dgvMaterias.Rows.Count - 1; i++)
                        {
                            for (int j = 0; j < dgvMaterias.Columns.Count; j++)
                            {
                                tw.WriteLine(dgvMaterias.Rows[i].Cells[j].Value.ToString());
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
                    for (int i = 0; i < dgvMaterias.Rows.Count - 1; i++)
                    {
                        if (txtNombre.Text == dgvMaterias.Rows[i].Cells[0].Value.ToString())
                        {
                            dgvMaterias.Rows.RemoveAt(i);
                        }
                    }
                    using (TextWriter tw = new StreamWriter("materias.txt"))
                    {
                        for (int i = 0; i < dgvMaterias.Rows.Count - 1; i++)
                        {
                            for (int j = 0; j < dgvMaterias.Columns.Count; j++)
                            {
                                tw.WriteLine(dgvMaterias.Rows[i].Cells[j].Value.ToString());
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

        private void btnAceptarNombreNuevo_Click_1(object sender, EventArgs e)
        {
            try
            {
                int bandera = 0;
                if (!string.IsNullOrEmpty(txtNombreNuevo.Text))
                {
                    for (int i = 0; i < dgvMaterias.Rows.Count - 1; i++)
                    {
                        if (txtNombreNuevo.Text == dgvMaterias.Rows[i].Cells[0].Value.ToString())
                        {
                            bandera++;
                        }
                    }
                    for (int i = 0; i < dgvMaterias.Rows.Count - 1; i++)
                    {
                        if (txtNombre.Text == dgvMaterias.Rows[i].Cells[0].Value.ToString())
                        {
                            if(bandera == 0)
                            {
                                dgvMaterias.Rows[i].Cells[0].Value = txtNombreNuevo.Text;
                            }
                        }
                    }
                    using (TextWriter tw = new StreamWriter("materias.txt"))
                    {
                        for (int i = 0; i < dgvMaterias.Rows.Count - 1; i++)
                        {
                            for (int j = 0; j < dgvMaterias.Columns.Count; j++)
                            {
                                tw.WriteLine(dgvMaterias.Rows[i].Cells[j].Value.ToString());
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

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
    public partial class FormCursos : Form
    {
        public FormCursos()
        {
            InitializeComponent();
        }

        private void FormCursos_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader materiasArchivo = new StreamReader("materias.txt");
                while (!materiasArchivo.EndOfStream)
                {
                    string nombre = materiasArchivo.ReadLine();
                    cmbMateria.Items.Add(nombre);
                }
                materiasArchivo.Close();
                cmbMateria.SelectedIndex = 0;
                StreamReader profesorArchivo = new StreamReader("profesores.txt");
                while (!profesorArchivo.EndOfStream)
                {
                    string nombre = profesorArchivo.ReadLine();
                    cmbProfesor.Items.Add(nombre);
                }
                profesorArchivo.Close();
                cmbProfesor.SelectedIndex = 0;
                StreamReader alumnoArchivo = new StreamReader("alumnos.txt");
                while (!alumnoArchivo.EndOfStream)
                {
                    string nombre = alumnoArchivo.ReadLine();
                    cmbAlumno.Items.Add(nombre);
                }
                alumnoArchivo.Close();
                cmbAlumno.SelectedIndex = 0;
                cmbAlumno.Enabled = false;
                btnAgregar.Enabled = false;
                btnEliminar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Es posible que el error sea provocado al no cargar Alumnos, Profesores y/o Materias");
                this.Close();
            }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                cmbMateria.Enabled = false;
                cmbProfesor.Enabled = false;
                cmbAlumno.Enabled = true;
                btnAceptar.Enabled = false;
                btnAgregar.Enabled = true;
                btnEliminar.Enabled = true;
                if (!File.Exists("Curso de " + cmbMateria.Text + " de " + cmbProfesor.Text + ".txt"))
                {
                    TextWriter curso = new StreamWriter("Curso de " + cmbMateria.Text + " de " + cmbProfesor.Text + ".txt");
                    curso.Close();
                }
                else
                {
                    StreamReader curso = new StreamReader("Curso de " + cmbMateria.Text + " de " + cmbProfesor.Text + ".txt");
                    while (!curso.EndOfStream)
                    {
                        string nombre = curso.ReadLine();
                        dgvCurso.Rows.Add(nombre);
                    }
                    curso.Close();
                }
                lblCurso.Text = "Curso de " + cmbMateria.Text + " de " + cmbProfesor.Text + ":";
                txtCurso.Text = "Curso de " + cmbMateria.Text + " de " + cmbProfesor.Text;
                txtProfesor.Text = cmbProfesor.Text;

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int bandera = 0;
                for (int i = 0; i < dgvCurso.Rows.Count - 1; i++)
                {
                    if (cmbAlumno.Text == dgvCurso.Rows[i].Cells[0].Value.ToString())
                    {
                        bandera++;
                    }
                }
                if (bandera == 0)
                {
                    dgvCurso.Rows.Add(cmbAlumno.Text);
                }
                using (TextWriter tw = new StreamWriter("Curso de " + cmbMateria.Text + " de " + cmbProfesor.Text + ".txt"))
                {
                    for (int i = 0; i < dgvCurso.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dgvCurso.Columns.Count; j++)
                        {
                            tw.WriteLine(dgvCurso.Rows[i].Cells[j].Value.ToString());
                        }
                    }
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dgvCurso.Rows.Count - 1; i++)
                {
                    if (cmbAlumno.Text == dgvCurso.Rows[i].Cells[0].Value.ToString())
                    {
                        dgvCurso.Rows.RemoveAt(i);
                    }
                }
                using (TextWriter tw = new StreamWriter("Curso de " + cmbMateria.Text + " de " + cmbProfesor.Text + ".txt"))
                {
                    for (int i = 0; i < dgvCurso.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dgvCurso.Columns.Count; j++)
                        {
                            tw.WriteLine(dgvCurso.Rows[i].Cells[j].Value.ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dgvCurso.Rows.Count; i++)
                {
                    dgvCurso.Rows.RemoveAt(i);
                }
                for (int i = 0; i < dgvCurso.Rows.Count; i++)
                {
                    dgvCurso.Rows.RemoveAt(i);
                }
                btnAgregar.Enabled = false;
                btnEliminar.Enabled = false;
                btnAceptar.Enabled = true;
                cmbAlumno.Enabled = false;
                cmbProfesor.Enabled = true;
                cmbMateria.Enabled = true;
                lblCurso.Text = "Curso";
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

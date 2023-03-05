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
    public partial class FormAlumnos : Form
    {
        public FormAlumnos()
        {
            InitializeComponent();
        }

        private void FormAlumnos_Load(object sender, EventArgs e)
        {
            //si se hay una excepción mientras se lee el archivo se captura utilizando el "try-catch"
            try
            {
                //se crea una instancia de la clase "StreamReader" para leer los datos de "alumnos.txt" 
                //la variable "alumnosArchivo" se utiliza para hacer referencia al archivo
                StreamReader alumnosArchivo = new StreamReader("alumnos.txt");
                //el codigo se va a ejecutar hasta que llegue al final del archivo
                while (!alumnosArchivo.EndOfStream)
                {
                    //va leyendo linea por linea y va guardando los nombres en la variable "nombres"
                    string nombre = alumnosArchivo.ReadLine();
                    //agrega los nombres leidos a una fila del Data Grid View
                    dgvAlumnos.Rows.Add(nombre);
                }
                //cerramos el archivo
                alumnosArchivo.Close();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            //si se hay una excepción mientras se lee el archivo se captura utilizando el "try-catch"
            try
            {
                //se crea una variable "bandera" y se inicializa su valor en 0//
                int bandera = 0;
                //se borra el contenido del cuadro de texto
                txtNombreNuevo.Text = "";
                //se deshabilita el contenido del cuadro de texto
                txtNombreNuevo.Enabled = false;
                //se deshabilita el botón "btnAceptarNombreNuevo"
                btnAceptarNombreNuevo.Enabled = false;
                //verifica si el "txtNombre" no está vacío
                if (!string.IsNullOrEmpty(txtNombre.Text))
                {
                    //si no esta vacio recorre las filas de "dgvAlumnos"
                    for (int i = 0; i < dgvAlumnos.Rows.Count - 1; i++)
                    {
                        //verifica si el nombre ingresado existe en alguna de las filas
                        if (txtNombre.Text == dgvAlumnos.Rows[i].Cells[0].Value.ToString())
                        {
                            //si el nombre ya existe "bandera" se incrementa en 1
                            bandera++;
                        }
                    }
                    //si "bandera" es igual a 0 quiere decir que el nombre no existe en ninguna fila
                    if (bandera == 0)
                    {
                        //se agrega el nombre a una fila del datagridview
                        dgvAlumnos.Rows.Add(txtNombre.Text);
                    } else
                    {
                        //si no se cumple la condicion quiere decir que el nombre ingresado ya existe
                        MessageBox.Show("El nombre ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //escribe los nombres de todos los alumnos (incluyendo el nuevo si se agregó) en "alumnos.txt"
                    using (TextWriter tw = new StreamWriter("alumnos.txt"))
                    {
                        for (int i = 0; i < dgvAlumnos.Rows.Count - 1; i++)
                        {
                            for (int j = 0; j < dgvAlumnos.Columns.Count; j++)
                            {
                                tw.WriteLine(dgvAlumnos.Rows[i].Cells[j].Value.ToString());
                            }
                        }
                    }
                }
                //si "txtNombre" está vacío se muestra un mensaje de error
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
                    for (int i = 0; i < dgvAlumnos.Rows.Count - 1; i++)
                    {
                        if (txtNombre.Text == dgvAlumnos.Rows[i].Cells[0].Value.ToString())
                        {
                            dgvAlumnos.Rows.RemoveAt(i);
                        }
                    }
                    using (TextWriter tw = new StreamWriter("alumnos.txt"))
                    {
                        for (int i = 0; i < dgvAlumnos.Rows.Count - 1; i++)
                        {
                            for (int j = 0; j < dgvAlumnos.Columns.Count; j++)
                            {
                                tw.WriteLine(dgvAlumnos.Rows[i].Cells[j].Value.ToString());
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
                    for (int i = 0; i < dgvAlumnos.Rows.Count - 1; i++)
                    {
                        if (txtNombreNuevo.Text == dgvAlumnos.Rows[i].Cells[0].Value.ToString())
                        {
                            bandera++;
                        }
                    }
                    for (int i = 0; i < dgvAlumnos.Rows.Count - 1; i++)
                    {
                        if (txtNombre.Text == dgvAlumnos.Rows[i].Cells[0].Value.ToString())
                        {
                            if (bandera == 0)
                            {
                                dgvAlumnos.Rows[i].Cells[0].Value = txtNombreNuevo.Text;
                            }
                        }
                    }
                    using (TextWriter tw = new StreamWriter("alumnos.txt"))
                    {
                        for (int i = 0; i < dgvAlumnos.Rows.Count - 1; i++)
                        {
                            for (int j = 0; j < dgvAlumnos.Columns.Count; j++)
                            {
                                tw.WriteLine(dgvAlumnos.Rows[i].Cells[j].Value.ToString());
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

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void txtNombreNuevo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblModificarNombre_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

namespace Final_Programacion_I_V2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // el constructor verifica si los archivos existen y si no existen los crea
            InitializeComponent();
            if (!File.Exists("alumnos.txt"))
            {
                TextWriter alumnos = new StreamWriter("alumnos.txt");
                alumnos.Close();
            }
            if (!File.Exists("profesores.txt"))
            {
                TextWriter profesores = new StreamWriter("profesores.txt");
                profesores.Close();
            }
            if (!File.Exists("materias.txt"))
            {
                TextWriter materias = new StreamWriter("materias.txt");
                materias.Close();
            }
            if (!File.Exists("curso.txt"))
            {
                TextWriter curso = new StreamWriter("curso.txt");
                curso.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            //se crea una instancia de la clase "FormAlumnos" y se asigna a la variable "formAlumnos"
            FormAlumnos formAlumnos = new FormAlumnos();
            //escondemos el formulario actual con el metodo hide
            this.Hide();
            //se muestra el formulario formAlumnos
            formAlumnos.ShowDialog();
            //cuando se cierra el formulario anterior abre el form inicial
            this.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //cierra el formulario
            this.Close();
        }

        private void btnProfesores_Click(object sender, EventArgs e)
        {
            //crea una instancia de la clase FormProfesores y se le asigna la variable "formProfesores"
            FormProfesores formProfesores = new FormProfesores();
            //escondemos el formulario actual con el metodo hide
            this.Hide();
            //se muestra el formulario "formProfesores"
            formProfesores.ShowDialog();
            //cuando se cierra el formulario anterior abre el form inicial
            this.Show();
        }

        private void btnMaterias_Click(object sender, EventArgs e)
        {
            //creo una instancia de la clase "FormMaterias" y le asigno la variable "formMaterias"
            FormMaterias formMaterias = new FormMaterias();
            //escondo el formulario actual con el metodo hide
            this.Hide();
            //se muestra el formulario "formMaterias"
            formMaterias.ShowDialog();
            //cuando se cierra el formulario anterior abre el form inicial
            this.Show();
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            //creo una instancia de la clase FormCursos y le asigno la variable formCursos
            FormCursos formCursos = new FormCursos();
            //escondo el formulario actual con el metodo hide
            this.Hide();
            //muestro el formulario "formCursos"
            formCursos.ShowDialog();
            //cuando se cierre el form anterior se abre el form inicial
            this.Show();
        }
    }
}
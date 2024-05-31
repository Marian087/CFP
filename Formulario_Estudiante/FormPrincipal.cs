using Libreria_Alumno;
using Alumno;

namespace Formulario_Alumno
{
    public partial class FormPrincipal : Form

    {
        private List<Alumno> alumno;


        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.alumno = new List<Alumno>();
            this.alumno = Alumno.ListaAlumnos();
        }

      

        private void button3_Click(object sender, EventArgs e)
        {
            this.dgv

        }

        private Button button1;
        private Button button2;
    }
}

using static System.Net.Mime.MediaTypeNames;

namespace PrimerFormulario
{
    public partial class FormInicial : Form
    {

        string nombre;
        string apellido;
        string contrase�a;

        public FormInicial()
        {
            InitializeComponent();



        }

        private void FormInicial_Load(object sender, EventArgs e)
        {
            this.nombre = txt_nombre.Text;
            this.apellido = txt_apellido.Text;
            this.contrase�a = txt_contrase�a.Text;


            lst_salida.Items.Add($"El nombre ingresado es: {this.nombre}");
            lst_salida.Items.Add($"El apellido ingresado es: {nombre}");
            lst_salida.Items.Add($"la contrase�a es: {nombre}");

        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {



        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            txt_nombre.Text = string.Empty;
            txt_apellido.Text = string.Empty;
            txt_contrase�a.Text = string.Empty;



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

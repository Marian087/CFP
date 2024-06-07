
using LibreriaAuto;

namespace Form_Auto1
{
    public partial class FormAuto : Form
    {
        List<Auto> misAutos;// declaramos la lista 

        public FormAuto()
        {
            InitializeComponent();

        }
       
        // esto es este evento podemos interartuar con el formulario toma valores previos antes de que sean visibles para el usuario.
        private void FormAuto_Load(object sender, EventArgs e)
        {

            this.misAutos = new List<Auto>(); //instanciamos la lista
            this.cmb_colores.Items.AddRange( Auto.ColoresValidos().ToArray());// agrego el metodo de los colores para el combobox

        }

        private void btnCrear_Click(object sender, EventArgs e) //evento crear
        {
            string marca = this.txt_Marca.Text;
            string cantCombustible = this.txt_CantCombustible.Text;
            string color = this.cmb_colores.Text;

            Auto miAuto = new Auto(marca, cantCombustible, color);

            misAutos.Add(miAuto);

            this.lst_misAutos.Items.Add(miAuto); //corresponde al listBox

            this.Limpiar();
        }
        //metodo Limpiar
        private void Limpiar() //Sirve para que se borren los datos una vez ingresado.
        {
            this.cmb_colores.Text = string.Empty;
            this.txt_CantCombustible.Text = string.Empty;
            this.txt_Marca.Text = string.Empty;

        }

        private void cargarCMB(List<Color> colors)
        {
            foreach (Color color in colors)
            {
                this.cmb_colores.Items.AddRange();

            }
        }


        private void txt_Marca_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Combustible_TextChanged(object sender, EventArgs e)
        {

        }

      
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {




        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {

        }

      
    }
}

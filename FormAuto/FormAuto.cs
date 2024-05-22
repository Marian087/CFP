


namespace FormAuto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_Color.Items.AddRange(Auto.ColoresValidos());
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            this
            this.lst_misAutos.Items.AddRange(misAutos.Toarrays());

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {

            this.lst_misAutos.Items.clear()

        }


        public  bool ConvertirStringEnCombustible(string combustible) 
        {
            bool retorno = false;

            if(double.TryParse(combustible, out double comValido)) 
            {
                this.cantCombustible = comValido;
                retorno = true;           
            
            }

            return retorno;     
               
        
        }


        public static bool ConvertirStringAint (string valorAconvertir)

        private void button1_Click(object sender, EventArgs e)
        {
            string marca = this.txt_marca.Text;
            string combustible = this.txt_combustible.Text;
            string color = this.cmb_colores.Text;
            DialogResult respuesta;

            Auto miAuto = new Auto(marca, combustible, color);

            respuesta = MessageBox.Show("Desea agregar este AUTO?", "Agregar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //if (respuesta == DialogResult.Yes) 
            //{
            //    MessageBox.Show("Auto agregado");
            //}
            //else 
            //{
            //    MessageBox.Show("Auto No agregado");
            //}



            switch (respuesta) 
            {
                case DialogResult.Yes:
                        MessageBox.Show("Apreto el botòn YES");
                    break;
                case DialogResult.No:
                    MessageBox.Show("Apreto el botòn NO");
                    break;
                case DialogResult.Cancel:
                    MessageBox.Show("Apreto el botòn CANCELAR");
                    break;

            }
        }
    }
}

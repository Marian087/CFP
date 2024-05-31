using Libreria_Alumno;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_Alumno
{
    public partial class FormCrear : Form
    {
        private Alumno nuevoAlumno;

        public FormCrear()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            nuevoAlumno = new Alumno(txt_legajo.Text, txt_apellido.Text, txt_nombre.Text);

        }
        public Alumno MiAlumno // properti para crear un nuevo alumno
        {
            get 
            {
                return nuevoAlumno;
            
            
            }
        
        
        }




    }
}

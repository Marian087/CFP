

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


using Libreria_Alumno;
using 
namespace FormRegistrate
{
    public partial class FormPrincipal : Form
    {
        private Ingresantes nuevo;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender,EventArgs e) 
        {
            Ingresantes = new List<Ingresantes>();
        
        }


    }
}

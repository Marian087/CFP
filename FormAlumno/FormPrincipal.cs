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

namespace FormAlumno
{
    public partial class FormPrincipal : Form
    {

        private List<Alumno> alumnos;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.alumnos = new List<Alumno>();
            this.alumnos = Alumno.ListAlumnos();

            this.listBoxAlumnos.DataSource = this.alumnos;
        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
            this.dgv_infotmacion.DataSource = alumnos;

        }
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            FormCrear forAlta = new FormCrear();
            forAlta.ShowDialog();

            if (forAlta.DialogResult == DialogResult.OK && forAlta.MiAlumno is not null)
            {
                //uso prioridad Mialumno para agregarlo a la lista
                alumnos.Add(forAlta.MiAlumno);
                CargarListaAlumnos();

            }

        }
        private void CargarListaAlumnos()
        {
            listBoxAlumnos.DataSource = null;
            listBoxInformacion.DataSource = alumnos;

        }

        private void CargarDgv()// se encarga de cargar la lista de alumnos en el control listaAlumnos
        {
            dgv_informacion.DataSource = null;
            dgv_informacion.DataSorce = alumnos;

        }

        private void btn_Evaluar_Click(object sender, EventArgs e)
        {
            Random ramdom = new Random();

            foreach (Alumno item in alumnos)
            {
                item.NotaPrimerParcial = ramdom.Next(1, 10);
                item.NotaSegundoParcial = ramdom.Next(1, 10);



            }
        }
        private void lbl_Alumnos_Click(object sender, EventArgs e)
        {


        }

        private void btn_Mostrar_Click_1(object sender, EventArgs e)
        {
            if (alumnos != null && alumnos.Count > 0)
            {
                this.dgv_alumnos.DataSource = null;
                this.dgv_alumnos.DataSource = alumnos;

                this.listBoxAlumnos.Items.Clear();

                foreach (var alumno in alumnos)
                {
                    this.listBoxAlumnos.Items.AddRange(alumnos.ToArray());


                }
            }
            else
            {
                MessageBox.Show("No hay alumnos para mostrar");
            }

        }

        private void listBoxInformacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }







        //private void CargarDataGridAlumnos()
        //{
        //    dataGridViewInfo.DataSource = null;
        //    dataGridViewInfo.DataSource = alumnos;
        //}

    }
}

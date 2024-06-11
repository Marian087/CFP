using Libreria_Alumno;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using System.Windows.Forms;

namespace FormRegistrate
{
    public partial class FormAlta : Form
    {
        Ingresantes ingresantes;

        public FormAlta()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            lbl_apellido = new Label();
            num_edad = new NumericUpDown();
            lbl_num = new Label();
            lbl_nombre = new Label();
            txt_nombre = new TextBox();
            txt_apellido = new TextBox();
            gpb_genero = new GroupBox();
            rdt_noBinario = new RadioButton();
            rdt_femenino = new RadioButton();
            rdt_masculino = new RadioButton();
            gpb_cursos = new GroupBox();
            chk_c = new CheckBox();
            chk_javaScrip = new CheckBox();
            chk_angular = new CheckBox();
            chk_nodejs = new CheckBox();
            chk_python = new CheckBox();
            lst_pais = new ListBox();
            btn_cancelar = new Button();
            btn_agregar = new Button();
            lbl_pais = new Label();
            groupBox1.SuspendLayout();
            ((ISupportInitialize)num_edad).BeginInit();
            gpb_genero.SuspendLayout();
            gpb_cursos.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbl_apellido);
            groupBox1.Controls.Add(num_edad);
            groupBox1.Controls.Add(lbl_num);
            groupBox1.Controls.Add(lbl_nombre);
            groupBox1.Controls.Add(txt_nombre);
            groupBox1.Controls.Add(txt_apellido);
            groupBox1.Location = new Point(12, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(216, 186);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // lbl_apellido
            // 
            lbl_apellido.AutoSize = true;
            lbl_apellido.Location = new Point(6, 70);
            lbl_apellido.Name = "lbl_apellido";
            lbl_apellido.Size = new Size(51, 15);
            lbl_apellido.TabIndex = 14;
            lbl_apellido.Text = "Apellido";
            // 
            // num_edad
            // 
            num_edad.Location = new Point(74, 116);
            num_edad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            num_edad.Name = "num_edad";
            num_edad.Size = new Size(120, 23);
            num_edad.TabIndex = 16;
            num_edad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lbl_num
            // 
            lbl_num.AutoSize = true;
            lbl_num.Location = new Point(6, 124);
            lbl_num.Name = "lbl_num";
            lbl_num.Size = new Size(33, 15);
            lbl_num.TabIndex = 15;
            lbl_num.Text = "Edad";
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Location = new Point(6, 38);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(51, 15);
            lbl_nombre.TabIndex = 13;
            lbl_nombre.Text = "Nombre";
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(74, 33);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.PlaceholderText = "Ingrese su Nombre";
            txt_nombre.Size = new Size(142, 23);
            txt_nombre.TabIndex = 5;
            // 
            // txt_apellido
            // 
            txt_apellido.Location = new Point(74, 65);
            txt_apellido.Name = "txt_apellido";
            txt_apellido.Size = new Size(100, 23);
            txt_apellido.TabIndex = 6;
            // 
            // gpb_genero
            // 
            gpb_genero.Controls.Add(rdt_noBinario);
            gpb_genero.Controls.Add(rdt_femenino);
            gpb_genero.Controls.Add(rdt_masculino);
            gpb_genero.Location = new Point(467, 12);
            gpb_genero.Name = "gpb_genero";
            gpb_genero.Size = new Size(232, 114);
            gpb_genero.TabIndex = 1;
            gpb_genero.TabStop = false;
            gpb_genero.Text = "Genero";
            // 
            // rdt_noBinario
            // 
            rdt_noBinario.AutoSize = true;
            rdt_noBinario.Location = new Point(8, 73);
            rdt_noBinario.Name = "rdt_noBinario";
            rdt_noBinario.Size = new Size(81, 19);
            rdt_noBinario.TabIndex = 2;
            rdt_noBinario.TabStop = true;
            rdt_noBinario.Text = "No Binario";
            rdt_noBinario.UseVisualStyleBackColor = true;
            // 
            // rdt_femenino
            // 
            rdt_femenino.AutoSize = true;
            rdt_femenino.Location = new Point(8, 48);
            rdt_femenino.Name = "rdt_femenino";
            rdt_femenino.Size = new Size(78, 19);
            rdt_femenino.TabIndex = 1;
            rdt_femenino.TabStop = true;
            rdt_femenino.Text = "Femenino";
            rdt_femenino.UseVisualStyleBackColor = true;
            // 
            // rdt_masculino
            // 
            rdt_masculino.AutoSize = true;
            rdt_masculino.Location = new Point(8, 25);
            rdt_masculino.Name = "rdt_masculino";
            rdt_masculino.Size = new Size(80, 19);
            rdt_masculino.TabIndex = 0;
            rdt_masculino.TabStop = true;
            rdt_masculino.Text = "Masculino";
            rdt_masculino.UseVisualStyleBackColor = true;
            // 
            // gpb_cursos
            // 
            gpb_cursos.Controls.Add(chk_c);
            gpb_cursos.Controls.Add(chk_javaScrip);
            gpb_cursos.Controls.Add(chk_angular);
            gpb_cursos.Controls.Add(chk_nodejs);
            gpb_cursos.Controls.Add(chk_python);
            gpb_cursos.Location = new Point(446, 140);
            gpb_cursos.Name = "gpb_cursos";
            gpb_cursos.Size = new Size(233, 189);
            gpb_cursos.TabIndex = 1;
            gpb_cursos.TabStop = false;
            gpb_cursos.Text = "Cursos";
            // 
            // chk_c
            // 
            chk_c.AutoSize = true;
            chk_c.FlatAppearance.BorderColor = Color.Red;
            chk_c.Location = new Point(17, 32);
            chk_c.Name = "chk_c";
            chk_c.Size = new Size(41, 19);
            chk_c.TabIndex = 8;
            chk_c.Text = "C#";
            chk_c.UseVisualStyleBackColor = true;
            // 
            // chk_javaScrip
            // 
            chk_javaScrip.AutoSize = true;
            chk_javaScrip.FlatAppearance.BorderColor = Color.Red;
            chk_javaScrip.Location = new Point(19, 136);
            chk_javaScrip.Name = "chk_javaScrip";
            chk_javaScrip.Size = new Size(74, 19);
            chk_javaScrip.TabIndex = 12;
            chk_javaScrip.Text = "JavaScrip";
            chk_javaScrip.UseVisualStyleBackColor = true;
            // 
            // chk_angular
            // 
            chk_angular.AutoSize = true;
            chk_angular.FlatAppearance.BorderColor = Color.Red;
            chk_angular.Location = new Point(18, 57);
            chk_angular.Name = "chk_angular";
            chk_angular.Size = new Size(68, 19);
            chk_angular.TabIndex = 9;
            chk_angular.Text = "Angular";
            chk_angular.UseVisualStyleBackColor = true;
            // 
            // chk_nodejs
            // 
            chk_nodejs.AutoSize = true;
            chk_nodejs.FlatAppearance.BorderColor = Color.Red;
            chk_nodejs.Location = new Point(19, 111);
            chk_nodejs.Name = "chk_nodejs";
            chk_nodejs.Size = new Size(66, 19);
            chk_nodejs.TabIndex = 11;
            chk_nodejs.Text = "Node.js";
            chk_nodejs.UseVisualStyleBackColor = true;
            // 
            // chk_python
            // 
            chk_python.AutoSize = true;
            chk_python.FlatAppearance.BorderColor = Color.Red;
            chk_python.Location = new Point(19, 82);
            chk_python.Name = "chk_python";
            chk_python.Size = new Size(64, 19);
            chk_python.TabIndex = 10;
            chk_python.Text = "Python";
            chk_python.UseVisualStyleBackColor = true;
            // 
            // lst_pais
            // 
            lst_pais.FormattingEnabled = true;
            lst_pais.ItemHeight = 15;
            lst_pais.Location = new Point(28, 251);
            lst_pais.Name = "lst_pais";
            lst_pais.Size = new Size(299, 94);
            lst_pais.TabIndex = 2;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(467, 376);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(75, 23);
            btn_cancelar.TabIndex = 3;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(633, 376);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(75, 23);
            btn_agregar.TabIndex = 4;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // lbl_pais
            // 
            lbl_pais.AutoSize = true;
            lbl_pais.Location = new Point(28, 226);
            lbl_pais.Name = "lbl_pais";
            lbl_pais.Size = new Size(28, 15);
            lbl_pais.TabIndex = 17;
            lbl_pais.Text = "Pais";
            // 
            // FormAlta
            // 
            ClientSize = new Size(763, 457);
            Controls.Add(lbl_pais);
            Controls.Add(btn_agregar);
            Controls.Add(btn_cancelar);
            Controls.Add(lst_pais);
            Controls.Add(gpb_genero);
            Controls.Add(gpb_cursos);
            Controls.Add(groupBox1);
            Name = "FormAlta";
            Load += FormAlta_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((ISupportInitialize)num_edad).EndInit();
            gpb_genero.ResumeLayout(false);
            gpb_genero.PerformLayout();
            gpb_cursos.ResumeLayout(false);
            gpb_cursos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void FormAlta_Load(object sender, EventArgs e)
        {
            lst_pais.DataSource


        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            string nombre = txt_nombre.Text;
            string apellido = txt_apellido.Text;
            int edad = (int) num_edad.Value;

            string genero;
            string pais = lst_pais.Text;
            List<string> cursos = new List<string>();


            foreach ( RadioButton rd in gpb_genero.Controls) 
            {
                if (rd.Checked) 
                {
                    genero = rd.Text;
                    break;
                
                
                }
            
            }

            foreach (CheckBox ck in GroupingDataflowBlockOptions.curso.Controls) 
            {
                if (ck.Checked) 
                {
                    cursos.Add();
                    break;
                
                }
            
            
            }






        }
    }
}

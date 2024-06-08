using Libreria_Alumno;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FormAlumno
{
    public partial class FormCrear : Form
    {

        private Alumno nuevoAlumno;

        public FormCrear()
        {
            InitializeComponent();
        }

        public FormCrear(TextBox txt_Nombre, TextBox txt_Apellido, Button btn_Aceptar, Button btn_Cancelar, Label lbl_Legajo, Label lbl_Nombre, TextBox txt_Legajo, Label lbl_Apellido, Alumno nuevoAlumno)
        {
            this.txt_Nombre = txt_Nombre;
            this.txt_Apellido = txt_Apellido;
            this.btn_Aceptar = btn_Aceptar;
            this.btn_Cancelar = btn_Cancelar;
            this.lbl_Legajo = lbl_Legajo;
            this.lbl_Nombre = lbl_Nombre;
            this.txt_Legajo = txt_Legajo;
            this.lbl_Apellido = lbl_Apellido;
            this.nuevoAlumno = nuevoAlumno;
        }

        private void FormCrear_Load(object sender, EventArgs e)
        {

        }
        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            string nombre = txt_Nombre.Text;
            string apellido = txt_Apellido.Text;

            if (!int.TryParse(txt_Legajo.Text, out int legajo))
            {
                MessageBox.Show("Legajo debe ser un nùmero entero.");

                return;

            }

            nuevoAlumno = new Alumno(nombre,apellido,legajo);
            this.DialogResult = DialogResult.OK;

        }
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public Alumno MiAlumno
        {
            get
            {
                return nuevoAlumno;
            }

        }

        
       
       

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCrear));
            txt_Nombre = new TextBox();
            txt_Apellido = new TextBox();
            btn_Aceptar = new Button();
            btn_Cancelar = new Button();
            lbl_Legajo = new Label();
            lbl_Nombre = new Label();
            txt_Legajo = new TextBox();
            lbl_Apellido = new Label();
            SuspendLayout();
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(12, 97);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(152, 23);
            txt_Nombre.TabIndex = 1;
            // 
            // txt_Apellido
            // 
            txt_Apellido.Location = new Point(12, 164);
            txt_Apellido.Name = "txt_Apellido";
            txt_Apellido.Size = new Size(152, 23);
            txt_Apellido.TabIndex = 2;
            // 
            // btn_Aceptar
            // 
            btn_Aceptar.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 192);
            btn_Aceptar.FlatAppearance.MouseDownBackColor = Color.Blue;
            btn_Aceptar.FlatStyle = FlatStyle.System;
            btn_Aceptar.Location = new Point(12, 326);
            btn_Aceptar.Name = "btn_Aceptar";
            btn_Aceptar.Size = new Size(75, 23);
            btn_Aceptar.TabIndex = 3;
            btn_Aceptar.Text = "Aceptar";
            btn_Aceptar.UseVisualStyleBackColor = true;
            btn_Aceptar.Click += new EventHandler(btn_Aceptar_Click);
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.Location = new Point(142, 326);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(75, 23);
            btn_Cancelar.TabIndex = 4;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = true;
            btn_Cancelar.Click += new EventHandler(btn_Cancelar_Click);

            // 
            // lbl_Legajo
            // 
            lbl_Legajo.AutoSize = true;
            lbl_Legajo.ForeColor = Color.Black;
            lbl_Legajo.Location = new Point(27, 16);
            lbl_Legajo.Name = "lbl_Legajo";
            lbl_Legajo.Size = new Size(42, 15);
            lbl_Legajo.TabIndex = 5;
            lbl_Legajo.Text = "Legajo";
            lbl_Legajo.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.Location = new Point(18, 79);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new Size(51, 15);
            lbl_Nombre.TabIndex = 6;
            lbl_Nombre.Text = "Nombre";
            // 
            // txt_Legajo
            // 
            txt_Legajo.ForeColor = SystemColors.MenuText;
            txt_Legajo.Location = new Point(12, 34);
            txt_Legajo.Name = "txt_Legajo";
            txt_Legajo.Size = new Size(152, 23);
            txt_Legajo.TabIndex = 0;
            // 
            // lbl_Apellido
            // 
            lbl_Apellido.AutoSize = true;
            lbl_Apellido.Location = new Point(18, 146);
            lbl_Apellido.Name = "lbl_Apellido";
            lbl_Apellido.Size = new Size(51, 15);
            lbl_Apellido.TabIndex = 7;
            lbl_Apellido.Text = "Apellido";
            // 
            // FormCrear
            // 
            BackColor = Color.Violet;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(426, 401);
            Controls.Add(lbl_Apellido);
            Controls.Add(lbl_Nombre);
            Controls.Add(lbl_Legajo);
            Controls.Add(btn_Cancelar);
            Controls.Add(btn_Aceptar);
            Controls.Add(txt_Apellido);
            Controls.Add(txt_Nombre);
            Controls.Add(txt_Legajo);
            Name = "FormCrear";
            Load += new EventHandler(FormCrear_Load);
            ResumeLayout(false);
            PerformLayout();

            
        }
    }
}

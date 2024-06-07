

namespace FormAlumno
{
    public partial class FormCrear : Form
    {



        public FormCrear()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCrear));
            txt_Nombre = new TextBox();
            txt_Apellido = new TextBox();
            btn_Cargar = new Button();
            button2 = new Button();
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
            // btn_Cargar
            // 
            btn_Cargar.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 192);
            btn_Cargar.FlatAppearance.MouseDownBackColor = Color.Blue;
            btn_Cargar.FlatStyle = FlatStyle.System;
            btn_Cargar.Location = new Point(12, 326);
            btn_Cargar.Name = "btn_Cargar";
            btn_Cargar.Size = new Size(75, 23);
            btn_Cargar.TabIndex = 3;
            btn_Cargar.Text = "Cargar";
            btn_Cargar.UseVisualStyleBackColor = true;
            btn_Cargar.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(142, 326);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Mostrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
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
            Controls.Add(button2);
            Controls.Add(btn_Cargar);
            Controls.Add(txt_Apellido);
            Controls.Add(txt_Nombre);
            Controls.Add(txt_Legajo);
            Name = "FormCrear";
            Load += FormCrear_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void button1_Click(object sender, EventArgs e)
        {



        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void FormCrear_Load(object sender, EventArgs e)
        {

        }
    }
}

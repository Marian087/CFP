using FormAlumno;

namespace FormAlumno
{
    public partial class FormCrear : Form
    {
        private Alumno nuevoAlumno;


        public FormCrear()
        {
            InitializeComponent();
        }

        private void private void InitializeComponent()
        {
            txtBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // txtBox1
            // 
            txtBox1.Location = new Point(100, 33);
            txtBox1.Name = "txtBox1";
            txtBox1.Size = new Size(152, 23);
            txtBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(89, 92);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(152, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(89, 154);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(152, 23);
            textBox3.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(27, 262);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(166, 262);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // FormCrear
            // 
            ClientSize = new Size(426, 401);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(txtBox1);
            Name = "FormCrear";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

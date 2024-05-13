namespace PrimerFormulario
{
    partial class FormInicial
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textNombre = new TextBox();
            textApellido = new TextBox();
            textContraseña = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            listBox1 = new ListBox();
            textIngresar = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // textNombre
            // 
            textNombre.Location = new Point(120, 51);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(140, 23);
            textNombre.TabIndex = 0;
            // 
            // textApellido
            // 
            textApellido.Location = new Point(120, 105);
            textApellido.Name = "textApellido";
            textApellido.Size = new Size(140, 23);
            textApellido.TabIndex = 1;
            // 
            // textContraseña
            // 
            textContraseña.Location = new Point(120, 166);
            textContraseña.Name = "textContraseña";
            textContraseña.Size = new Size(140, 23);
            textContraseña.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 33);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 3;
            label1.Text = "Nombre";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 87);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 4;
            label2.Text = "Apellido";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(120, 148);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 5;
            label3.Text = "Contraseña";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(399, 39);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(229, 214);
            listBox1.TabIndex = 6;
            // 
            // textIngresar
            // 
            textIngresar.Location = new Point(120, 288);
            textIngresar.Name = "textIngresar";
            textIngresar.Size = new Size(100, 23);
            textIngresar.TabIndex = 7;
            textIngresar.Text = "Ingresar";
            textIngresar.TextChanged += textBox3_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(326, 268);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 8;
            textBox1.Text = "Borrar";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(120, 54);
            label4.Name = "label4";
            label4.Size = new Size(105, 15);
            label4.TabIndex = 9;
            label4.Text = "Ingrese su nombre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(120, 108);
            label5.Name = "label5";
            label5.Size = new Size(105, 15);
            label5.TabIndex = 10;
            label5.Text = "Ingrese su apellido";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(120, 169);
            label6.Name = "label6";
            label6.Size = new Size(121, 15);
            label6.TabIndex = 11;
            label6.Text = "Ingrese su contraseña";
            // 
            // FormInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(textIngresar);
            Controls.Add(listBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textContraseña);
            Controls.Add(textApellido);
            Controls.Add(textNombre);
            Name = "FormInicial";
            Text = "Form1";
            Load += FormInicial_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textNombre;
        private TextBox textApellido;
        private TextBox textContraseña;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox listBox1;
        private TextBox textIngresar;
        private TextBox textBox1;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}

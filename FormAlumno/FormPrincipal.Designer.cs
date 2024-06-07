using Libreria_Alumno;

namespace FormAlumno
{
    partial class FormPrincipal :Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            btn_agregar = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 192, 255);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(45, 36);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 3;
            label1.Text = "Alumnos";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 192, 255);
            label2.FlatStyle = FlatStyle.Popup;
            label2.Location = new Point(280, 36);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 4;
            label2.Text = "Informacion";
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.White;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(32, 72);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 274);
            listBox1.TabIndex = 5;
            // 
            // listBox2
            // 
            listBox2.BackColor = Color.White;
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(250, 72);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(447, 274);
            listBox2.TabIndex = 6;
            // 
            // btn_agregar
            // 
            btn_agregar.BackColor = Color.FromArgb(255, 192, 255);
            btn_agregar.FlatAppearance.BorderColor = Color.Blue;
            btn_agregar.FlatAppearance.MouseDownBackColor = Color.Silver;
            btn_agregar.FlatAppearance.MouseOverBackColor = Color.Gray;
            btn_agregar.FlatStyle = FlatStyle.Popup;
            btn_agregar.Location = new Point(50, 379);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(141, 23);
            btn_agregar.TabIndex = 7;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 192, 255);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(229, 379);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 8;
            button2.Text = "Evaluar";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 192, 255);
            button3.FlatStyle = FlatStyle.Popup;
            button3.Location = new Point(414, 379);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 9;
            button3.Text = "Mostrar";
            button3.UseVisualStyleBackColor = false;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btn_agregar);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormPrincipal";
            Text = "Formulario Principal";
            TransparencyKey = Color.FromArgb(128, 255, 128);
            Load += FormPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private ListBox listBox1;
        private ListBox listBox2;
        private Button btn_agregar;
        private Button button2;
        private Button button3;
    }
}
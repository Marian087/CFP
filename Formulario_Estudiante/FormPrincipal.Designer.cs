namespace Formulario_Alumno

{
    partial class FormPrincipal
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
            Apellido = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            list_alumnos = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Apellido
            // 
            Apellido.AutoSize = true;
            Apellido.Location = new Point(47, 22);
            Apellido.Name = "Apellido";
            Apellido.Size = new Size(55, 15);
            Apellido.TabIndex = 6;
            Apellido.Text = "Alumnos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 332);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(422, 28);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 9;
            label4.Text = "Informacion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(459, 178);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 11;
            // 
            // list_alumnos
            // 
            list_alumnos.FormattingEnabled = true;
            list_alumnos.ItemHeight = 15;
            list_alumnos.Location = new Point(36, 43);
            list_alumnos.Name = "list_alumnos";
            list_alumnos.Size = new Size(120, 259);
            list_alumnos.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new Point(36, 350);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 14;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(165, 350);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 15;
            button2.Text = "Evaluar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(300, 350);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 16;
            button3.Text = "Mostrar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(219, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(447, 245);
            dataGridView1.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(list_alumnos);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(Apellido);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Apellido;
        private Label label2;
        private Label label5;
        private ListBox list_alumnos;
        private Button button1;
        private Button button2;
        public Label label4;
        private Button button3;
        private DataGridView dataGridView1;
    }
}

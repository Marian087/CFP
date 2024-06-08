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
            lbl_Alumnos = new Label();
            lbl_Informacion = new Label();
            listBoxAlumnos = new ListBox();
            listBoxInformacion = new ListBox();
            btn_Agregar = new Button();
            btn_Evaluar = new Button();
            btn_Mostrar = new Button();
            SuspendLayout();
            // 
            // lbl_Alumnos
            // 
            lbl_Alumnos.AutoSize = true;
            lbl_Alumnos.BackColor = Color.FromArgb(255, 192, 255);
            lbl_Alumnos.ForeColor = SystemColors.ControlText;
            lbl_Alumnos.Location = new Point(45, 36);
            lbl_Alumnos.Name = "lbl_Alumnos";
            lbl_Alumnos.Size = new Size(55, 15);
            lbl_Alumnos.TabIndex = 3;
            lbl_Alumnos.Text = "Alumnos";
            // 
            // lbl_Informacion
            // 
            lbl_Informacion.AutoSize = true;
            lbl_Informacion.BackColor = Color.FromArgb(255, 192, 255);
            lbl_Informacion.FlatStyle = FlatStyle.Popup;
            lbl_Informacion.Location = new Point(280, 36);
            lbl_Informacion.Name = "lbl_Informacion";
            lbl_Informacion.Size = new Size(72, 15);
            lbl_Informacion.TabIndex = 4;
            lbl_Informacion.Text = "Informacion";
            // 
            // listBoxAlumnos
            // 
            listBoxAlumnos.BackColor = Color.White;
            listBoxAlumnos.FormattingEnabled = true;
            listBoxAlumnos.ItemHeight = 15;
            listBoxAlumnos.Location = new Point(32, 72);
            listBoxAlumnos.Name = "listBoxAlumnos";
            listBoxAlumnos.Size = new Size(120, 274);
            listBoxAlumnos.TabIndex = 5;
            // 
            // listBoxInformacion
            // 
            listBoxInformacion.BackColor = Color.White;
            listBoxInformacion.FormattingEnabled = true;
            listBoxInformacion.ItemHeight = 15;
            listBoxInformacion.Location = new Point(250, 72);
            listBoxInformacion.Name = "listBoxInformacion";
            listBoxInformacion.Size = new Size(447, 274);
            listBoxInformacion.TabIndex = 6;
            // 
            // btn_Agregar
            // 
            btn_Agregar.BackColor = Color.FromArgb(255, 192, 255);
            btn_Agregar.FlatAppearance.BorderColor = Color.Blue;
            btn_Agregar.FlatAppearance.MouseDownBackColor = Color.Silver;
            btn_Agregar.FlatAppearance.MouseOverBackColor = Color.Gray;
            btn_Agregar.FlatStyle = FlatStyle.Popup;
            btn_Agregar.Location = new Point(50, 379);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(141, 23);
            btn_Agregar.TabIndex = 7;
            btn_Agregar.Text = "Agregar";
            btn_Agregar.UseVisualStyleBackColor = false;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // btn_Evaluar
            // 
            btn_Evaluar.BackColor = Color.FromArgb(255, 192, 255);
            btn_Evaluar.FlatStyle = FlatStyle.Popup;
            btn_Evaluar.Location = new Point(229, 379);
            btn_Evaluar.Name = "btn_Evaluar";
            btn_Evaluar.Size = new Size(75, 23);
            btn_Evaluar.TabIndex = 8;
            btn_Evaluar.Text = "Evaluar";
            btn_Evaluar.UseVisualStyleBackColor = false;
            btn_Evaluar.Click += btn_Evaluar_Click;
            // 
            // btn_Mostrar
            // 
            btn_Mostrar.BackColor = Color.FromArgb(255, 192, 255);
            btn_Mostrar.FlatStyle = FlatStyle.Popup;
            btn_Mostrar.Location = new Point(414, 379);
            btn_Mostrar.Name = "btn_Mostrar";
            btn_Mostrar.Size = new Size(75, 23);
            btn_Mostrar.TabIndex = 9;
            btn_Mostrar.Text = "Mostrar";
            btn_Mostrar.UseVisualStyleBackColor = false;
            btn_Mostrar.Click += btn_Mostrar_Click_1;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Mostrar);
            Controls.Add(btn_Evaluar);
            Controls.Add(btn_Agregar);
            Controls.Add(listBoxInformacion);
            Controls.Add(listBoxAlumnos);
            Controls.Add(lbl_Informacion);
            Controls.Add(lbl_Alumnos);
            Name = "FormPrincipal";
            Text = "Formulario Principal";
            TransparencyKey = Color.FromArgb(128, 255, 128);
            Load += FormPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_Alumnos;
        private Label lbl_Informacion;
        private ListBox listBoxAlumnos;
        private ListBox listBoxInformacion;
        private Button btn_Agregar;
        private Button btn_Evaluar;
        private Button btn_Mostrar;
    }
}
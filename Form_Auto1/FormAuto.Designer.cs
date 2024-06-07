using LibreriaAuto;
using TesteoPrimeraEvaluacion;

namespace Form_Auto1
{
    partial class FormAuto
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
            txt_Marca = new TextBox();
            txt_CantCombustible = new TextBox();
            lbl_Marca = new Label();
            lbl_CantCombustible = new Label();
            lbl_Color = new Label();
            btnCrear = new Button();
            lst_misAutos = new ListBox();
            label1 = new Label();
            btn_Mostrar = new Button();
            btn_Limpiar = new Button();
            cmb_colores = new ComboBox();
            SuspendLayout();
            // 
            // txt_Marca
            // 
            txt_Marca.Location = new Point(70, 43);
            txt_Marca.Name = "txt_Marca";
            txt_Marca.Size = new Size(100, 23);
            txt_Marca.TabIndex = 1;
            txt_Marca.TextChanged += txt_Marca_TextChanged;
            // 
            // txt_CantCombustible
            // 
            txt_CantCombustible.Location = new Point(70, 103);
            txt_CantCombustible.Name = "txt_CantCombustible";
            txt_CantCombustible.Size = new Size(100, 23);
            txt_CantCombustible.TabIndex = 2;
            txt_CantCombustible.TextChanged += txt_Combustible_TextChanged;
            // 
            // lbl_Marca
            // 
            lbl_Marca.AutoSize = true;
            lbl_Marca.Location = new Point(70, 25);
            lbl_Marca.Name = "lbl_Marca";
            lbl_Marca.Size = new Size(40, 15);
            lbl_Marca.TabIndex = 3;
            lbl_Marca.Text = "Marca";
            // 
            // lbl_CantCombustible
            // 
            lbl_CantCombustible.AutoSize = true;
            lbl_CantCombustible.Location = new Point(70, 85);
            lbl_CantCombustible.Name = "lbl_CantCombustible";
            lbl_CantCombustible.Size = new Size(75, 15);
            lbl_CantCombustible.TabIndex = 4;
            lbl_CantCombustible.Text = "Combustible";
            // 
            // lbl_Color
            // 
            lbl_Color.AutoSize = true;
            lbl_Color.Location = new Point(70, 158);
            lbl_Color.Name = "lbl_Color";
            lbl_Color.Size = new Size(36, 15);
            lbl_Color.TabIndex = 5;
            lbl_Color.Text = "Color";
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.FromArgb(192, 255, 192);
            btnCrear.ForeColor = SystemColors.Desktop;
            btnCrear.Location = new Point(63, 368);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(134, 23);
            btnCrear.TabIndex = 4;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // lst_misAutos
            // 
            lst_misAutos.FormattingEnabled = true;
            lst_misAutos.ItemHeight = 15;
            lst_misAutos.Location = new Point(216, 43);
            lst_misAutos.Name = "lst_misAutos";
            lst_misAutos.Size = new Size(472, 274);
            lst_misAutos.TabIndex = 7;
            lst_misAutos.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(293, 9);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 8;
            label1.Text = "Listado de mis autos";
            // 
            // btn_Mostrar
            // 
            btn_Mostrar.BackColor = Color.FromArgb(192, 255, 192);
            btn_Mostrar.ForeColor = SystemColors.Desktop;
            btn_Mostrar.Location = new Point(293, 368);
            btn_Mostrar.Name = "btn_Mostrar";
            btn_Mostrar.Size = new Size(134, 23);
            btn_Mostrar.TabIndex = 5;
            btn_Mostrar.Text = "Mostrar";
            btn_Mostrar.UseVisualStyleBackColor = false;
            // 
            // btn_Limpiar
            // 
            btn_Limpiar.BackColor = Color.FromArgb(192, 255, 192);
            btn_Limpiar.ForeColor = SystemColors.Desktop;
            btn_Limpiar.Location = new Point(481, 368);
            btn_Limpiar.Name = "btn_Limpiar";
            btn_Limpiar.Size = new Size(134, 23);
            btn_Limpiar.TabIndex = 6;
            btn_Limpiar.Text = "Limpiar";
            btn_Limpiar.UseVisualStyleBackColor = false;
            btn_Limpiar.Click += btn_Limpiar_Click;
            // 
            // cmb_colores
            // 
            cmb_colores.FormattingEnabled = true;
            cmb_colores.Location = new Point(70, 176);
            cmb_colores.Name = "cmb_colores";
            cmb_colores.Size = new Size(121, 23);
            cmb_colores.TabIndex = 3;
            // 
            // FormAuto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(cmb_colores);
            Controls.Add(btn_Limpiar);
            Controls.Add(btn_Mostrar);
            Controls.Add(label1);
            Controls.Add(lst_misAutos);
            Controls.Add(btnCrear);
            Controls.Add(lbl_Color);
            Controls.Add(lbl_CantCombustible);
            Controls.Add(lbl_Marca);
            Controls.Add(txt_CantCombustible);
            Controls.Add(txt_Marca);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormAuto";
            Text = "Formulario Auto";
            Load += FormAuto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Marca;
        private TextBox txt_CantCombustible;
        private Label lbl_Marca;
        private Label lbl_CantCombustible;
        private Label lbl_Color;
        private Button btnCrear;
        private ListBox lst_misAutos;
        private Label label1;
        private Button btn_Mostrar;
        private Button btn_Limpiar;
        private ComboBox cmb_colores;
    }
}

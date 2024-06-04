namespace Form_Auto
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
            txt_Combustible = new TextBox();
            txt_Color = new TextBox();
            lbl_Marca = new Label();
            lbl_Combustible = new Label();
            lbl_Color = new Label();
            SuspendLayout();
            // 
            // txt_Marca
            // 
            txt_Marca.Location = new Point(61, 25);
            txt_Marca.Name = "txt_Marca";
            txt_Marca.Size = new Size(100, 23);
            txt_Marca.TabIndex = 0;
            // 
            // txt_Combustible
            // 
            txt_Combustible.Location = new Point(61, 99);
            txt_Combustible.Name = "txt_Combustible";
            txt_Combustible.Size = new Size(100, 23);
            txt_Combustible.TabIndex = 1;
            // 
            // txt_Color
            // 
            txt_Color.Location = new Point(61, 161);
            txt_Color.Name = "txt_Color";
            txt_Color.Size = new Size(100, 23);
            txt_Color.TabIndex = 2;
            // 
            // lbl_Marca
            // 
            lbl_Marca.AutoSize = true;
            lbl_Marca.Location = new Point(67, 8);
            lbl_Marca.Name = "lbl_Marca";
            lbl_Marca.Size = new Size(40, 15);
            lbl_Marca.TabIndex = 3;
            lbl_Marca.Text = "Marca";
            lbl_Marca.Click += this.lbl_Marca_Click;
            // 
            // lbl_Combustible
            // 
            lbl_Combustible.AutoSize = true;
            lbl_Combustible.Location = new Point(67, 81);
            lbl_Combustible.Name = "lbl_Combustible";
            lbl_Combustible.Size = new Size(75, 15);
            lbl_Combustible.TabIndex = 4;
            lbl_Combustible.Text = "Combustible";
            // 
            // lbl_Color
            // 
            lbl_Color.AutoSize = true;
            lbl_Color.Location = new Point(67, 143);
            lbl_Color.Name = "lbl_Color";
            lbl_Color.Size = new Size(36, 15);
            lbl_Color.TabIndex = 5;
            lbl_Color.Text = "Color";
            // 
            // FormAuto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_Color);
            Controls.Add(lbl_Combustible);
            Controls.Add(lbl_Marca);
            Controls.Add(txt_Color);
            Controls.Add(txt_Combustible);
            Controls.Add(txt_Marca);
            Name = "FormAuto";
            Text = "Formulario_Auto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Marca;
        private TextBox txt_Combustible;
        private TextBox txt_Color;
        private Label lbl_Marca;
        private Label lbl_Combustible;
        private Label lbl_Color;
    }
}

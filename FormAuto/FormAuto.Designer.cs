namespace FormAuto
{
    partial class Form1
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
            txt_Color = new ComboBox();
            txt_marca = new TextBox();
            txt_Combustible = new TextBox();
            button1 = new Button();
            btn_mostrar = new Button();
            btn_limpiar = new Button();
            SuspendLayout();
            // 
            // txt_Color
            // 
            txt_Color.FormattingEnabled = true;
            txt_Color.Location = new Point(36, 177);
            txt_Color.Name = "txt_Color";
            txt_Color.Size = new Size(121, 23);
            txt_Color.TabIndex = 0;
            // 
            // txt_marca
            // 
            txt_marca.Location = new Point(36, 39);
            txt_marca.Name = "txt_marca";
            txt_marca.Size = new Size(100, 23);
            txt_marca.TabIndex = 1;
            // 
            // txt_Combustible
            // 
            txt_Combustible.Location = new Point(36, 90);
            txt_Combustible.Name = "txt_Combustible";
            txt_Combustible.Size = new Size(100, 23);
            txt_Combustible.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(36, 270);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Crear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn_mostrar
            // 
            btn_mostrar.Location = new Point(179, 270);
            btn_mostrar.Name = "btn_mostrar";
            btn_mostrar.Size = new Size(75, 23);
            btn_mostrar.TabIndex = 4;
            btn_mostrar.Text = "Mostrar";
            btn_mostrar.UseVisualStyleBackColor = true;
            btn_mostrar.Click += btn_mostrar_Click;
            // 
            // btn_limpiar
            // 
            btn_limpiar.Location = new Point(310, 270);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(75, 23);
            btn_limpiar.TabIndex = 5;
            btn_limpiar.Text = "Limpiar";
            btn_limpiar.UseVisualStyleBackColor = true;
            btn_limpiar.Click += btn_limpiar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_limpiar);
            Controls.Add(btn_mostrar);
            Controls.Add(button1);
            Controls.Add(txt_Combustible);
            Controls.Add(txt_marca);
            Controls.Add(txt_Color);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox txt_Color;
        private TextBox txt_marca;
        private TextBox txt_Combustible;
        private Button button1;
        private Button btn_mostrar;
        private Button btn_limpiar;
    }
}

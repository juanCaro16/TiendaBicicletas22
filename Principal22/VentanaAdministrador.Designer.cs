namespace Principal22
{
    partial class VentanaAdministrador
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
            button1 = new Button();
            button2 = new Button();
            ContenedorProductos = new ListView();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Location = new Point(128, 36);
            button1.Name = "button1";
            button1.Size = new Size(188, 71);
            button1.TabIndex = 0;
            button1.Text = "Insertar Productos";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientActiveCaption;
            button2.Location = new Point(365, 36);
            button2.Name = "button2";
            button2.Size = new Size(161, 71);
            button2.TabIndex = 1;
            button2.Text = "Ver Productos";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // ContenedorProductos
            // 
            ContenedorProductos.Location = new Point(12, 132);
            ContenedorProductos.Name = "ContenedorProductos";
            ContenedorProductos.Size = new Size(776, 306);
            ContenedorProductos.TabIndex = 4;
            ContenedorProductos.UseCompatibleStateImageBehavior = false;
            // 
            // VentanaAdministrador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(ContenedorProductos);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "VentanaAdministrador";
            Text = "Ventana_Administrador";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private ListView ContenedorProductos;
    }
}
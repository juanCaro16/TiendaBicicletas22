
namespace Principal22
{
    partial class VentanaPrincipal
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Location = new Point(117, 103);
            button1.Name = "button1";
            button1.Size = new Size(143, 43);
            button1.TabIndex = 0;
            button1.Text = "Administrador\r\n";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientActiveCaption;
            button2.Location = new Point(305, 103);
            button2.Name = "button2";
            button2.Size = new Size(115, 43);
            button2.TabIndex = 1;
            button2.Text = "Empleados";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.GradientActiveCaption;
            button3.Location = new Point(467, 103);
            button3.Name = "button3";
            button3.Size = new Size(115, 43);
            button3.TabIndex = 2;
            button3.Text = "Login";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // VentanaPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "VentanaPrincipal";
            Text = "Ventana Principal";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VentanaAdministrador ventana_Administrador = new VentanaAdministrador();
            ventana_Administrador.Show();

        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
    }
}

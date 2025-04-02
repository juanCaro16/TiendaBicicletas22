namespace Principal22
{
    partial class VentanaAgregarProductos
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
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 60);
            label1.Name = "label1";
            label1.Size = new Size(141, 20);
            label1.TabIndex = 0;
            label1.Text = "Marca Del Producto";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Location = new Point(297, 344);
            button1.Name = "button1";
            button1.Size = new Size(159, 47);
            button1.TabIndex = 1;
            button1.Text = "Ingresar Producto";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(65, 94);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(248, 27);
            textBox1.TabIndex = 2;
            textBox1.Text = "Ingrese la marca del producto";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(65, 176);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(248, 27);
            textBox2.TabIndex = 4;
            textBox2.Text = "Ingrese el tipo del producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 142);
            label2.Name = "label2";
            label2.Size = new Size(130, 20);
            label2.TabIndex = 3;
            label2.Text = "Tipo Del Producto";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(391, 94);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(248, 27);
            textBox3.TabIndex = 6;
            textBox3.Text = "Ingrese el modelo del producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(391, 60);
            label3.Name = "label3";
            label3.Size = new Size(152, 20);
            label3.TabIndex = 5;
            label3.Text = "Modelo Del Producto";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(391, 176);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(248, 27);
            textBox4.TabIndex = 8;
            textBox4.Text = "Ingrese el tamaño del producto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(391, 142);
            label4.Name = "label4";
            label4.Size = new Size(152, 20);
            label4.TabIndex = 7;
            label4.Text = "Tamaño Del Producto";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(65, 260);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(248, 27);
            textBox5.TabIndex = 10;
            textBox5.Text = "Ingrese el precio del producto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(65, 226);
            label5.Name = "label5";
            label5.Size = new Size(141, 20);
            label5.TabIndex = 9;
            label5.Text = "Precio Del Producto";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(391, 260);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(248, 27);
            textBox6.TabIndex = 12;
            textBox6.Text = "Ingrese el Stock del producto";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(391, 226);
            label6.Name = "label6";
            label6.Size = new Size(212, 20);
            label6.TabIndex = 11;
            label6.Text = "Stock Disponible Del Producto";
            // 
            // VentanaAgregarProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "VentanaAgregarProductos";
            Text = "VentanaAgregarProductos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox6;
        private Label label6;
    }
}
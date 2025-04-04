namespace Principal22
{
    partial class VentanaLogin
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
            textBoxName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxEmail = new TextBox();
            label3 = new Label();
            textBoxPassword = new TextBox();
            label4 = new Label();
            inputRol = new TextBox();
            button2 = new Button();
            textoMuestra = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Location = new Point(256, 349);
            button1.Name = "button1";
            button1.Size = new Size(114, 43);
            button1.TabIndex = 0;
            button1.Text = "Ingresar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(254, 84);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(246, 27);
            textBoxName.TabIndex = 1;
            textBoxName.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(254, 51);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 5;
            label1.Text = "Ingrese Su Nonbre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(254, 123);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 7;
            label2.Text = "Ingrese su Email";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(254, 156);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(246, 27);
            textBoxEmail.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(254, 195);
            label3.Name = "label3";
            label3.Size = new Size(151, 20);
            label3.TabIndex = 9;
            label3.Text = "Ingrese su contraseña";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(254, 228);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(246, 27);
            textBoxPassword.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(254, 267);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 11;
            label4.Text = "Ingrese su rol";
            // 
            // inputRol
            // 
            inputRol.Location = new Point(254, 300);
            inputRol.Name = "inputRol";
            inputRol.Size = new Size(246, 27);
            inputRol.TabIndex = 10;
            inputRol.TextChanged += inputRol_TextChanged;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientActiveCaption;
            button2.Location = new Point(386, 349);
            button2.Name = "button2";
            button2.Size = new Size(114, 43);
            button2.TabIndex = 12;
            button2.Text = "Atras";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textoMuestra
            // 
            textoMuestra.AutoSize = true;
            textoMuestra.Location = new Point(627, 195);
            textoMuestra.Name = "textoMuestra";
            textoMuestra.Size = new Size(21, 20);
            textoMuestra.TabIndex = 13;
            textoMuestra.Text = "--";
            textoMuestra.Click += textoMuestra_Click;
            // 
            // VentanaLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(textoMuestra);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(inputRol);
            Controls.Add(label3);
            Controls.Add(textBoxPassword);
            Controls.Add(label2);
            Controls.Add(textBoxEmail);
            Controls.Add(label1);
            Controls.Add(textBoxName);
            Controls.Add(button1);
            Name = "VentanaLogin";
            Text = "VentanaLogin";
            Load += VentanaLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void TextError_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button button1;
        private TextBox textBoxName;
        private Label label1;
        private Label label2;
        private TextBox textBoxEmail;
        private Label label3;
        private TextBox textBoxPassword;
        private Label label4;
        private TextBox inputRol;
        private Button button2;
        private Label textoMuestra;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;


namespace Principal22
{
    public partial class VentanaLogin : Form
    {
                
        public VentanaLogin()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void VentanaLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (inputRol.Text == "administrador")
            {
                VentanaAdministrador ventanaAdministrador = new VentanaAdministrador();
                ventanaAdministrador.Show();
                this.Close();
            }
            else if (inputRol.Text == "cliente")
            {
                ventanaCliente ventanaUsuarios = new ventanaCliente();
                ventanaUsuarios.Show();
                this.Close();
            }else if (inputRol.Text == "proveedor")
            {
                VentanaProveedor ventanaProveedor = new VentanaProveedor();
                ventanaProveedor.Show();
                this.Close();
            }else if (inputRol.Text == "vendedor")
            {
                VentanaVendedor ventanaVendedor = new VentanaVendedor();
                ventanaVendedor.Show();
                this.Close();
            }
            else
            {
                textoMuestra.Text = "--Ingrese un rol valido";
            }

            

        }

        public void inputRol_TextChanged(object sender, EventArgs e)
        {
            inputRol.Text.ToLower();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void textoMuestra_Click(object sender, EventArgs e)
        {

        }
    }
}

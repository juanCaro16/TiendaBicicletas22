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
using Modelo;
using Modelo.Entities;

namespace Principal22
{
    public partial class VentanaAdministrador : Form
    {
        ProductoController productoController = new ProductoController();
        public VentanaAdministrador()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            ProductoController us = new();
            var productos = us.VerProducto();

            ContenedorProductos.Controls.Clear();

            int yOffset = 10;

            foreach (var producto in productos)
            {
                Label lblProducto = new();

                lblProducto.Text = $"Marca: {producto.marca}, Modelo: {producto.modelo}, Tipo: {producto.tipo}, Tamaño: {producto.tamaño}, Precio: {producto.precio}, Stock: {producto.stock}";
                lblProducto.AutoSize = true;
                lblProducto.Location = new Point(10, yOffset);

                ContenedorProductos.Controls.Add(lblProducto);

                yOffset += lblProducto.Height + 10; // Espacio entre etiquetas
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            VentanaInsetarProductos ventanaInsetarProductos = new VentanaInsetarProductos();
            ventanaInsetarProductos.Show();
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Entities;
using Modelo;
using Modelo.Entities;

namespace Logica
{
    public class ProductoController
    {

        //Metodo para ver los productos
        public List<ProductoEntity> VerProducto()
        {
            BaseDatos db = new BaseDatos();

            List<ProductoEntity> Producto = db.TraerProductos();

            return Producto;
        }

        //Metodo para guardar los productos
        public string GuardarProductoss(string marca, string modelo, string tipo, string tamaño, decimal precio, int stock, string imagen)
        {
            string resultado = "";
            BaseDatos db = new BaseDatos();
            int filasAfectadas = db.GuardarProductos(marca, modelo, tipo, tamaño, precio, stock, imagen);

            if (filasAfectadas > 0)
            {
                resultado = "Producto guardado";
            }
            else
            {
                resultado = "Error al guardar el producto";
            }

            return resultado;
        }

        //Metodo para actualizar el producto

        public string ActualizarProductos(int id, string marca, string modelo, string tipo, string tamaño, decimal precio, int stock, string imagen)
        {
            string resultado = "";
            BaseDatos db = new BaseDatos();
            int filasAfectadas = db.ActualizarProducto(id, marca, modelo, tipo, tamaño, precio, stock, imagen);
            if (filasAfectadas > 0)
            {
                resultado = "Producto actualizado";
            }
            else
            {
                resultado = "Error al actualizar el producto";
            }
            return resultado;
        }

        //Metodo para eliminar el producto

        public string EliminarProductos(int id)
        {
            string resultado = "";
            BaseDatos db = new BaseDatos();
            int filasAfectadas = db.EliminarProducto(id);
            if (filasAfectadas > 0)
            {
                resultado = "Producto eliminado";
            }
            else
            {
                resultado = "Error al eliminar el producto";
            }
            return resultado;
        }
    }
}

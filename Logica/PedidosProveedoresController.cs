using Modelo;
using Modelo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class PedidosProveedoresController
    {

        //Metodo para ver los pedidos
        public List<PedidosProveedoresEntity> VerPedidos()
        {
            BaseDatos db = new BaseDatos();
            List<PedidosProveedoresEntity> Pedidos = db.TraerPedidos();
            return Pedidos;
        }

        //Metodo para guardar pedidos
        public string GuardarPedidosProveedores(DateTime fecha_pedido, string estado, int proveedor_id)
        {
            string resultado = "";
            BaseDatos db = new BaseDatos();
            int filasAfectadas = db.GuardarPedidos_Proveedores(fecha_pedido, estado, proveedor_id);
            if (filasAfectadas > 0)
            {
                resultado = "Pedido guardado";
            }
            else
            {
                resultado = "Error al guardar el pedido";
            }
            return resultado;
        }


        //Metodo para actualizar pedidos

        public string ActualizarPedidosProveedores(int id, DateTime fecha_pedido, string estado, int proveedor_id)
        {
            string resultado = "";
            BaseDatos db = new BaseDatos();
            int filasAfectadas = db.ActualizarPedidos_Proveedores(id, fecha_pedido, estado, proveedor_id);
            if (filasAfectadas > 0)
            {
                resultado = "Pedido actualizado";
            }
            else
            {
                resultado = "Error al actualizar el pedido";
            }
            return resultado;
        }

        //Metodo para eliminar pedidos

        public string EliminarPedidosProveedores(int id)
        {
            string resultado = "";
            BaseDatos db = new BaseDatos();
            int filasAfectadas = db.EliminarPedidos_Proveedores(id);
            if (filasAfectadas > 0)
            {
                resultado = "Pedido eliminado";
            }
            else
            {
                resultado = "Error al eliminar el pedido";
            }
            return resultado;
        }
    }
}

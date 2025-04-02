using Modelo;
using Modelo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Detalles_PedidoController
    {

        //Metodo para ver los detalles de pedido
        public List<DetallesPedidoEntity> VerDetalles_Pedido()
        {
            BaseDatos db = new BaseDatos();
            List<DetallesPedidoEntity> Detalles_Pedido = db.TraerDetallesPedido();
            return Detalles_Pedido;
        }

        //Metodo para guardar detalles de pedido
        public string GuardarDetalles_Pedido(int cantidad, decimal precio_unitario, decimal subtotal, int pedidos_id, int bicicleta_id)
        {
            string resultado = "";
            BaseDatos db = new BaseDatos();
            int filasAfectadas = db.GuardarDetalles_Pedido(cantidad, precio_unitario, subtotal, pedidos_id, bicicleta_id);
            if (filasAfectadas > 0)
            {
                resultado = "Detalle de pedido guardado";
            }
            else
            {
                resultado = "Error al guardar el detalle de pedido";
            }
            return resultado;
        }


        //Metodo para actualizar detalles de pedido

        public string ActualizarDetalles_Pedido(int id, int cantidad, decimal precio_unitario, decimal subtotal, int pedidos_id, int bicicleta_id)
        {
            string resultado = "";
            BaseDatos db = new BaseDatos();
            int filasAfectadas = db.ActualizarDetalles_Pedido(id, cantidad, precio_unitario, subtotal, pedidos_id, bicicleta_id);
            if (filasAfectadas > 0)
            {
                resultado = "Detalle de pedido actualizado";
            }
            else
            {
                resultado = "Error al actualizar el detalle de pedido";
            }
            return resultado;
        }

        //Metodo para eliminar detalles de pedido

        public string EliminarDetalles_Pedido(int id)
        {
            string resultado = "";
            BaseDatos db = new BaseDatos();
            int filasAfectadas = db.EliminarDetalles_Pedido(id);
            if (filasAfectadas > 0)
            {
                resultado = "Detalle de pedido eliminado";
            }
            else
            {
                resultado = "Error al eliminar el detalle de pedido";
            }
            return resultado;
        }
    }
}

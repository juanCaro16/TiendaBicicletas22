using Modelo;
using Modelo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Detalles_VentaController
    {

        //Metodo para ver los detalles de venta
        public List<Detalles_VentaEntity> VerDetalles_Venta()
        {
            BaseDatos db = new BaseDatos();

            List<Detalles_VentaEntity> Detalles_Venta = db.TraerDetallesVenta();

            return Detalles_Venta;
        }

        //Metodo para guardar detalles de venta
        public string GuardarDetalles_Venta(int cantidad, decimal precio_unitario, decimal subtotal, int venta_id, int bicicleta_id)
        {
            string resultado = "";
            BaseDatos db = new BaseDatos();
            int filasAfectadas = db.GuardarDetalles_Venta(cantidad, precio_unitario, subtotal, venta_id, bicicleta_id);
            if (filasAfectadas > 0)
            {
                resultado = "Detalle de venta guardado";
            }
            else
            {
                resultado = "Error al guardar el detalle de venta";
            }
            return resultado;
        }

        //Metodo para actualizar detalles de venta

        public string ActualizarDetalles_Venta(int id, int cantidad, decimal precio_unitario, decimal subtotal, int venta_id, int bicicleta_id)
        {
            string resultado = "";
            BaseDatos db = new BaseDatos();
            int filasAfectadas = db.ActualizarDetalles_Venta(id, cantidad, precio_unitario, subtotal, venta_id, bicicleta_id);
            if (filasAfectadas > 0)
            {
                resultado = "Detalle de venta actualizado";
            }
            else
            {
                resultado = "Error al actualizar el detalle de venta";
            }
            return resultado;
        }


        //Metodo para eliminar detalles de venta

        public string EliminarDetalles_Venta(int id)
        {
            string resultado = "";
            BaseDatos db = new BaseDatos();
            int filasAfectadas = db.EliminarDetalles_Venta(id);
            if (filasAfectadas > 0)
            {
                resultado = "Detalle de venta eliminado";
            }
            else
            {
                resultado = "Error al eliminar el detalle de venta";
            }
            return resultado;
        }
    }
}

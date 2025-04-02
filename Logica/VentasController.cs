using Modelo;
using Modelo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class VentasController
    {

        //Metodo para ver las ventas
        public List<VentasEntity> VerVentas()
        {
            BaseDatos db = new BaseDatos();
            List<VentasEntity> Ventas = db.TraerVentas();
            return Ventas;
        }

        //Metodo para guardar ventas

        public string GuardarVentas(DateTime fecha, decimal total, string metodo_pago, int cliente_id)
        {
            string resultado = "";
            BaseDatos db = new BaseDatos();
            int filasAfectadas = db.GuardarVentas(fecha, total, metodo_pago, cliente_id);
            if (filasAfectadas > 0)
            {
                resultado = "Venta guardada";
            }
            else
            {
                resultado = "Error al guardar la venta";
            }
            return resultado;
        }

        //Metodo para actualizar ventas

        public string ActualizarVentas(int id, DateTime fecha, decimal total, string metodo_pago, int cliente_id)
        {
            string resultado = "";
            BaseDatos db = new BaseDatos();
            int filasAfectadas = db.ActualizarVentas(id, fecha, total, metodo_pago, cliente_id);
            if (filasAfectadas > 0)
            {
                resultado = "Venta actualizada";
            }
            else
            {
                resultado = "Error al actualizar la venta";
            }
            return resultado;
        }

        //Metodo para eliminar ventas

        public string EliminarVentas(int id)
        {
            string resultado = "";
            BaseDatos db = new BaseDatos();
            int filasAfectadas = db.EliminarVentas(id);
            if (filasAfectadas > 0)
            {
                resultado = "Venta eliminada";
            }
            else
            {
                resultado = "Error al eliminar la venta";
            }
            return resultado;
        }
    }
}

using Modelo;
using Modelo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ProveedoresController
    {

        //Metodo para ver los proveedores

        public List<ProveedoresEntity> VerProveedores()
        {
            BaseDatos db = new BaseDatos();
            List<ProveedoresEntity> Proveedores = db.TraerProveedores();
            return Proveedores;
        }


        //Metodo para guardar proveedores
        public string GuardarProveedores(string nombre, string telefono, string email, string direccion)
        {
            string resultado = "";
            BaseDatos db = new BaseDatos();
            int filasAfectadas = db.GuardarProveedores(nombre, telefono, email, direccion);
            if (filasAfectadas > 0)
            {
                resultado = "Proveedor guardado";
            }
            else
            {
                resultado = "Error al guardar el proveedor";
            }
            return resultado;
        }


        //Metodo para actualizar proveedores

        public string ActualizarProveedores(int id, string nombre, string telefono, string email, string direccion)
        {
            string resultado = "";
            BaseDatos db = new BaseDatos();
            int filasAfectadas = db.ActualizarProveedores(id, nombre, telefono, email, direccion);
            if (filasAfectadas > 0)
            {
                resultado = "Proveedor actualizado";
            }
            else
            {
                resultado = "Error al actualizar el proveedor";
            }
            return resultado;
        }


        //Metodo para eliminar proveedores

        public string EliminarProveedores(int id)
        {
            string resultado = "";
            BaseDatos db = new BaseDatos();
            int filasAfectadas = db.EliminarProveedores(id);
            if (filasAfectadas > 0)
            {
                resultado = "Proveedor eliminado";
            }
            else
            {
                resultado = "Error al eliminar el proveedor";
            }
            return resultado;
        }
    }
}

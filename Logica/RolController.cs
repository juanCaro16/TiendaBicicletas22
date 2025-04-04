using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Entities;
using Modelo;

namespace Logica
{
    public class RolController
    {

        // Metodo para ver los roles

        public List<RolEntity> VerRoles()
        {
            BaseDatos db = new BaseDatos();
            List<RolEntity> roles = db.TraerRol();
            return roles;
        }

        // Metodo para guardar un rol

        public string GuardarRol(string nombre)
        {
            string resultado = "";
            BaseDatos db = new BaseDatos();
            int filasAfectadas = db.GuardarRol(nombre);
            if (filasAfectadas > 0)
            {
                resultado = "Rol guardado";
            }
            else
            {
                resultado = "Error al guardar el rol";
            }
            return resultado;
        }

        // Metodo para actualizar un rol

        public string ActualizarRol(int id, string nombre)
        {
            string resultado = "";
            BaseDatos db = new BaseDatos();
            int filasAfectadas = db.ActualizarRol(id, nombre);
            if (filasAfectadas > 0)
            {
                resultado = "Rol actualizado";
            }
            else
            {
                resultado = "Error al actualizar el rol";
            }
            return resultado;
        }

        // Metodo para eliminar un rol

        public string EliminarRol(int id)
        {
            string resultado = "";
            BaseDatos db = new BaseDatos();
            int filasAfectadas = db.EliminarRol(id);
            if (filasAfectadas > 0)
            {
                resultado = "Rol eliminado";
            }
            else
            {
                resultado = "Error al eliminar el rol";
            }
            return resultado;
        }
    }
}

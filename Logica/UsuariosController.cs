using Modelo;
using Modelo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class UsuariosController
    {

        //Metodo para ver los usuarios
        public List<UsuarioEntity> VerUsuarios()
        {
            BaseDatos db = new BaseDatos();
            List<UsuarioEntity> Usuarios = db.TraerUsuario();
            return Usuarios;
        }

        //Metodo para guardar usuarios
        public string GuardarUsuarios(string nombre, string email, string contraseña, string rol)
        {
            string resultado = "";
            BaseDatos db = new BaseDatos();
            int filasAfectadas = db.GuardarUsuarios(nombre, email, contraseña, rol);
            if (filasAfectadas > 0)
            {
                resultado = "Usuario guardado";
            }
            else
            {
                resultado = "Error al guardar el usuario";
            }
            return resultado;
        }


        //Metodo para actualizar usuarios

        public string ActualizarUsuarios(int id, string nombre, string email, string contraseña, string rol)
        {
            string resultado = "";
            BaseDatos db = new BaseDatos();
            int filasAfectadas = db.ActualizarUsuarios(id, nombre, email, contraseña, rol);
            if (filasAfectadas > 0)
            {
                resultado = "Usuario actualizado";
            }
            else
            {
                resultado = "Error al actualizar el usuario";
            }
            return resultado;
        }

        //Metodo para eliminar usuarios

        public string EliminarUsuarios(int id)
        {
            string resultado = "";
            BaseDatos db = new BaseDatos();
            int filasAfectadas = db.EliminarUsuarios(id);
            if (filasAfectadas > 0)
            {
                resultado = "Usuario eliminado";
            }
            else
            {
                resultado = "Error al eliminar el usuario";
            }
            return resultado;
        }
    }
}

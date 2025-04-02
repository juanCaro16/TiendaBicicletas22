using Modelo;
using Modelo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ClientesController
    {

        //Metodo para ver los clientes
        public List<ClientesEntity> VerClientes()
        {
            BaseDatos db = new BaseDatos();
            List<ClientesEntity> Clientes = db.TraerClientes();
            return Clientes;
        }

        //Metodo para guardar clientes

        public string GuardarClientes(string nombre, string apellido, string email, string telefono, string direccion, DateTime fecha_registro)
        {
            string resultado = "";
            BaseDatos db = new BaseDatos();
            int filasAfectadas = db.GuardarClientes(nombre, apellido, email, telefono, direccion, fecha_registro);
            if (filasAfectadas > 0)
            {
                resultado = "Cliente guardado";
            }
            else
            {
                resultado = "Error al guardar el cliente";
            }
            return resultado;
        }


        //Metodo para actualizar clientes

        public string ActualizarClientes(int id, string nombre, string apellido, string email, string telefono, string direccion, DateTime fecha_registro)
        {
            string resultado = "";
            BaseDatos db = new BaseDatos();
            int filasAfectadas = db.ActualizarClientes(id, nombre, apellido, email, telefono, direccion, fecha_registro);
            if (filasAfectadas > 0)
            {
                resultado = "Cliente actualizado";
            }
            else
            {
                resultado = "Error al actualizar el cliente";
            }
            return resultado;
        }


        //Metodo para eliminar clientes

        public string EliminarClientes(int id)
        {
            string resultado = "";
            BaseDatos db = new BaseDatos();
            int filasAfectadas = db.EliminarClientes(id);
            if (filasAfectadas > 0)
            {
                resultado = "Cliente eliminado";
            }
            else
            {
                resultado = "Error al eliminar el cliente";
            }
            return resultado;
        }
    }
}

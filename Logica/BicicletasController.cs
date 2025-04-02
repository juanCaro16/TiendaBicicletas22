using Modelo;
using Modelo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class BicicletasController
    {

        //Metodo para ver las bicicletas
        public List<BicicletasEntity> VerBicicletas()
        {
            BaseDatos db = new BaseDatos();

            List<BicicletasEntity> Bicicletas = db.TraerBicicletas();

            return Bicicletas;
        }

        //Metodo para guardar bicicletas
        public string GuardarBicicletas(string marca, string modelo, string tipo, string tamaño, decimal precio, int stock, string imagen)
        {
            string resultado = "";
            BaseDatos db = new BaseDatos();
            int filasAfectadas = db.GuardarBicicletas(marca, modelo, tipo, tamaño, precio, stock, imagen);

            if (filasAfectadas > 0)
            {
                resultado = "Bicicleta guardada";
            }
            else
            {
                resultado = "Error al guardar la bicicleta";
            }

            return resultado;
        }

        //Metodo para actualizar bicicletas

        public string ActualizarBicicletas(int id, string marca, string modelo, string tipo, string tamaño, decimal precio, int stock, string imagen)
        {
            string resultado = "";
            BaseDatos db = new BaseDatos();
            int filasAfectadas = db.ActualizarBicicletas(id, marca, modelo, tipo, tamaño, precio, stock, imagen);
            if (filasAfectadas > 0)
            {
                resultado = "Bicicleta actualizada";
            }
            else
            {
                resultado = "Error al actualizar la bicicleta";
            }
            return resultado;
        }

        //Metodo para eliminar bicicletas

        public string EliminarBicicletas(int id)
        {
            string resultado = "";
            BaseDatos db = new BaseDatos();
            int filasAfectadas = db.EliminarBicicletas(id);
            if (filasAfectadas > 0)
            {
                resultado = "Bicicleta eliminada";
            }
            else
            {
                resultado = "Error al eliminar la bicicleta";
            }
            return resultado;
        }
    }
}

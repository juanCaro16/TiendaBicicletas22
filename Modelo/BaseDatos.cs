﻿using modelo.Entities;

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class BaseDatos : ConexionMysql
    {
        public List<BicicletasEntity> TraerBicicletas()
        {
            List<BicicletasEntity> Bicicletas = new List<BicicletasEntity>();
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SELECT * FROM Bicicletas";
            MySqlDataReader dr = cmd.ExecuteReader();


            while (dr.Read())
            {
                BicicletasEntity BicicletaActual = new BicicletasEntity();
                BicicletaActual.id = dr.GetInt32(0);
                BicicletaActual.marca = dr.GetString(1);
                BicicletaActual.modelo = dr.GetString(2);
                BicicletaActual.tipo = dr.GetString(3);
                BicicletaActual.tamaño = dr.GetString(4);
                BicicletaActual.precio = dr.GetDecimal(5);
                BicicletaActual.stock = dr.GetInt32(6);
                BicicletaActual.imagen = dr.GetString(6);
                Bicicletas.Add(BicicletaActual);
            }

            return Bicicletas;
        }

        public List<ClientesEntity> TraerClientes()
        {
            List<ClientesEntity> Clientes = new List<ClientesEntity>();
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SELECT * FROM Clientes";
            MySqlDataReader dr = cmd.ExecuteReader();


            while (dr.Read())
            {
                ClientesEntity ClienteActual = new ClientesEntity();
                ClienteActual.id = dr.GetInt32(0);
                ClienteActual.nombre = dr.GetString(1);
                ClienteActual.apellido = dr.GetString(2);
                ClienteActual.email = dr.GetString(3);
                ClienteActual.telefono = dr.GetString(4);
                ClienteActual.direccion = dr.GetString(5);
                ClienteActual.fecha_registro = dr.GetDateTime(6);
                Clientes.Add(ClienteActual);
            }

            return Clientes;
        }

        public List<VentasEntity> TraerVentas()
        {
            List<VentasEntity> Ventas = new List<VentasEntity>();
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SELECT * FROM Ventas";
            MySqlDataReader dr = cmd.ExecuteReader();


            while (dr.Read())
            {
                VentasEntity VentaActual = new VentasEntity();
                VentaActual.id = dr.GetInt32(0);
                VentaActual.fecha = dr.GetDateTime(1);
                VentaActual.total = dr.GetDecimal(2);
                VentaActual.metodo_pago = dr.GetString(3);
                VentaActual.cliente_id = dr.GetInt32(4);
                Ventas.Add(VentaActual);
            }

            return Ventas;
        }

        public List<Detalles_VentaEntity> TraerDetallesVenta()
        {
            List<Detalles_VentaEntity> DetallesVenta = new List<Detalles_VentaEntity>();
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SELECT * FROM Detalles_Ventas";
            MySqlDataReader dr = cmd.ExecuteReader();


            while (dr.Read())
            {
                Detalles_VentaEntity Detalle_VentaActual = new Detalles_VentaEntity();
                Detalle_VentaActual.id = dr.GetInt32(0);
                Detalle_VentaActual.cantidad = dr.GetInt32(1);
                Detalle_VentaActual.precio_unitario = dr.GetDecimal(2);
                Detalle_VentaActual.subtotal = dr.GetDecimal(3);
                Detalle_VentaActual.venta_id = dr.GetInt32(4);
                Detalle_VentaActual.bicicleta_id = dr.GetInt32(5);
                DetallesVenta.Add(Detalle_VentaActual);
            }

            return DetallesVenta;
        }

        public List<ProveedoresEntity> TraerProveedores()
        {
            List<ProveedoresEntity> Proveedores = new List<ProveedoresEntity>();
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SELECT * FROM Proveedores";
            MySqlDataReader dr = cmd.ExecuteReader();


            while (dr.Read())
            {
                ProveedoresEntity ProveedorActual = new ProveedoresEntity();
                ProveedorActual.id = dr.GetInt32(0);
                ProveedorActual.nombre = dr.GetString(1);
                ProveedorActual.telefono = dr.GetString(2);
                ProveedorActual.email = dr.GetString(3);
                ProveedorActual.direccion = dr.GetString(4);
                Proveedores.Add(ProveedorActual);
            }

            return Proveedores;
        }

        public List<PedidosProveedoresEntity> TraerPedidos()
        {
            List<PedidosProveedoresEntity> PedidosProveedores = new List<PedidosProveedoresEntity>();
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SELECT * FROM Pedidos_Proveedores";
            MySqlDataReader dr = cmd.ExecuteReader();


            while (dr.Read())
            {
                PedidosProveedoresEntity PedidPedidosProveedoresActual = new PedidosProveedoresEntity();
                PedidPedidosProveedoresActual.id = dr.GetInt32(0);
                PedidPedidosProveedoresActual.fecha_pedido = dr.GetDateTime(1);
                PedidPedidosProveedoresActual.estado = dr.GetString(2);
                PedidPedidosProveedoresActual.proveedor_id = dr.GetString(3);
                PedidosProveedores.Add(PedidPedidosProveedoresActual);
            }

            return PedidosProveedores;
        }

        public List<DetallesPedidoEntity> TraerDetallesPedido()
        {
            List<DetallesPedidoEntity> DetallesPedidos = new List<DetallesPedidoEntity>();
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SELECT * FROM Detalles_Pedido";
            MySqlDataReader dr = cmd.ExecuteReader();


            while (dr.Read())
            {
                DetallesPedidoEntity DetallesPedidoActual = new DetallesPedidoEntity();
                DetallesPedidoActual.id = dr.GetInt32(0);
                DetallesPedidoActual.cantidad = dr.GetInt32(1);
                DetallesPedidoActual.precio_unitario = dr.GetDecimal(2);
                DetallesPedidoActual.subtotal = dr.GetDecimal(3);
                DetallesPedidoActual.pedido_id = dr.GetInt32(4);
                DetallesPedidoActual.bicicleta_id = dr.GetInt32(5);
                DetallesPedidos.Add(DetallesPedidoActual);
            }

            return DetallesPedidos;
        }

        public List<UsuarioEntity> TraerUsuario()
        {
            List<UsuarioEntity> Usuarios = new List<UsuarioEntity>();
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SELECT * FROM Usuarios";
            MySqlDataReader dr = cmd.ExecuteReader();


            while (dr.Read())
            {
                UsuarioEntity UsuarioActual = new UsuarioEntity();
                UsuarioActual.id = dr.GetInt32(0);
                UsuarioActual.nombre = dr.GetString(1);
                UsuarioActual.email = dr.GetString(2);
                UsuarioActual.contraseña = dr.GetString(3);
                UsuarioActual.rol = dr.GetString(4);
                Usuarios.Add(UsuarioActual);
            }

            return Usuarios;
        }

        public int GuardarBicicletas(string marca, string modelo, string tipo, string tamaño, decimal precio, int stock, string imagen)
        {
            int resultado = 0;

            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "INSERT INTO Bicicletas (marca, modelo, tipo, tamaño, precio, stock, imagen)" +
                " VALUES ('" + marca + "','" + modelo + "','" + tipo + "','" + tamaño + "','" + precio + "','" + stock + "','" + imagen + "', )";
            resultado = cmd.ExecuteNonQuery();

            return resultado;
        }

        public int Guardarclientes(string nombre, string apellido, string email, string telefono, string direccion, DateTime fecha_registro)
        {
            int resultado = 0;

            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "INSERT INTO Clientes (nombre, apellido, email, telefono, direccion, fecha-registro)" +
                " VALUES ('" + nombre + "','" + apellido + "','" + email + "','" + telefono + "','" + direccion + "','" + fecha_registro + "', )";
            resultado = cmd.ExecuteNonQuery();

            return resultado;
        }

        public int GuardarVentas(DateTime fecha, decimal total, string metodo_pago, int cliente_id)
        {
            int resultado = 0;

            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "INSERT INTO Ventas (fecha, total, metodo_pago, cliente_id)" +
                " VALUES ('" + fecha + "','" + total + "','" + metodo_pago + "','" + cliente_id + "',)";
            resultado = cmd.ExecuteNonQuery();

            return resultado;
        }

        public int GuardarDetalles_Venta(int cantidad, decimal precio_unitario, decimal subtotal, int venta_id, int bicicleta_id)
        {
            int resultado = 0;

            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "INSERT INTO Detalles_Venta (cantidad, precio_unitario, subtotal, venta_id, bicicleta_id)" +
                " VALUES ('" + cantidad + "','" + precio_unitario + "','" + subtotal + "','" + venta_id + "','" + bicicleta_id + "',)";
            resultado = cmd.ExecuteNonQuery();

            return resultado;
        }

        public int GuardarProveedores(string nombre, string telefono, string email, string direccion)
        {
            int resultado = 0;

            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "INSERT INTO Proveedores (nombre, telefono, email, direccion)" +
                " VALUES ('" + nombre + "','" + telefono + "','" + email + "','" + direccion + "',)";
            resultado = cmd.ExecuteNonQuery();

            return resultado;
        }

        public int GuardarPedidos_Proveedores(DateTime fecha_pedido, string estado, int proveedor_id)
        {
            int resultado = 0;

            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "INSERT INTO Bicicletas (marca, modelo, tipo, tamaño, precio, stock, imagen)" +
                " VALUES ('" + fecha_pedido + "','" + estado + "','" + proveedor_id + "',)";
            resultado = cmd.ExecuteNonQuery();

            return resultado;
        }
    }
}

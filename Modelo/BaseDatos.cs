using Modelo.Entities;
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
        //traer
        public List<ProductoEntity> TraerProductos()
        {
            List<ProductoEntity> Producto = new List<ProductoEntity>();
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SELECT * FROM Producto";
            MySqlDataReader dr = cmd.ExecuteReader();


            while (dr.Read())
            {
                ProductoEntity ProductoActual = new ProductoEntity();
                ProductoActual.id = dr.GetInt32(0);
                ProductoActual.marca = dr.GetString(1);
                ProductoActual.modelo = dr.GetString(2);
                ProductoActual.tipo = dr.GetString(3);
                ProductoActual.tamaño = dr.GetString(4);
                ProductoActual.precio = dr.GetDecimal(5);
                ProductoActual.stock = dr.GetInt32(6);
                Producto.Add(ProductoActual);
            }

            return Producto;
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
                Detalle_VentaActual.producto_id = dr.GetInt32(5);
                DetallesVenta.Add(Detalle_VentaActual);
            }

            return DetallesVenta;
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
                PedidPedidosProveedoresActual.proveedor_id = dr.GetInt32(3);
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
                DetallesPedidoActual.producto_id = dr.GetInt32(5);
                DetallesPedidos.Add(DetallesPedidoActual);
            }

            return DetallesPedidos;
        }

        public List<UsuariosEntity> TraerUsuarios()
        {
            List<UsuariosEntity> Usuarios = new List<UsuariosEntity>();
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SELECT * FROM Usuarios";
            MySqlDataReader dr = cmd.ExecuteReader();


            while (dr.Read())
            {
                UsuariosEntity UsuarioActual = new UsuariosEntity();
                UsuarioActual.id = dr.GetInt32(0);
                UsuarioActual.nombre = dr.GetString(1);
                UsuarioActual.apellido = dr.GetString(2);
                UsuarioActual.email = dr.GetString(3);
                UsuarioActual.telefono = dr.GetString(4);
                UsuarioActual.direccion = dr.GetString(5);
                UsuarioActual.fecha_registro = dr.GetDateTime(6);
                UsuarioActual.contraseña = dr.GetString(7);
                UsuarioActual.rol_id = dr.GetString(8);
                Usuarios.Add(UsuarioActual);
            }

            return Usuarios;
        }

        public List<RolEntity> TraerRol()
        {
            List<RolEntity> Rol = new List<RolEntity>();
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SELECT * FROM Rol";
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                RolEntity RolActual = new RolEntity();
                RolActual.id = dr.GetInt32(0);
            }

            return Rol;
        }

        //guardar
        public int GuardarProductos(string marca, string modelo, string tipo, string tamaño, decimal precio, int stock, string imagen)
        {
            int resultado = 0;

            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "INSERT INTO Producto (marca, modelo, tipo, tamaño, precio, stock, imagen)" +
                " VALUES ('" + marca + "','" + modelo + "','" + tipo + "','" + tamaño + "','" + precio + "','" + stock + "','" + imagen + "',)";
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

        public int GuardarDetalles_Venta(int cantidad, decimal precio_unitario, decimal subtotal, int venta_id, int producto_id)
        {
            int resultado = 0;

            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "INSERT INTO Detalles_Venta (cantidad, precio_unitario, subtotal, venta_id, bicicleta_id)" +
                " VALUES ('" + cantidad + "','" + precio_unitario + "','" + subtotal + "','" + venta_id + "','" + producto_id + "',)";
            resultado = cmd.ExecuteNonQuery();

            return resultado;
        }

        public int GuardarPedidos_Proveedores(DateTime fecha_pedido, string estado, int proveedor_id)
        {
            int resultado = 0;

            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "INSERT INTO Pedidos_Proveedores (fecha_pedido, estado, proveedor_id)" +
                " VALUES ('" + fecha_pedido + "','" + estado + "','" + proveedor_id + "',)";
            resultado = cmd.ExecuteNonQuery();

            return resultado;
        }

        public int GuardarDetalles_Pedido(int cantidad, decimal precio_unitario, decimal subtotal, int pedidos_id, int producto_id)
        {
            int resultado = 0;

            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "INSERT INTO Detalles_Pedido (cantidad, precio_unitario, subtotal, pedidos_id, bicicleta_id)" +
                " VALUES ('" + cantidad + "','" + precio_unitario + "','" + subtotal + "','" + pedidos_id + "','" + producto_id + "',)";
            resultado = cmd.ExecuteNonQuery();

            return resultado;
        }

        public int GuardarUsuarios(string nombre, string apellidos, string email, string telefono, string direccion, DateTime fecha_registro, string contraseña, string rol_id)
        {
            int resultado = 0;

            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "INSERT INTO Usuarios (nombre, apellidos, email, telefono, direccion, fecha_registro, contraseña, rol_id)" +
                " VALUES ('" + nombre + "','" + apellidos + "','" + email + "','" + telefono + "','" + direccion + "','" + fecha_registro + "','" + contraseña + "','" + rol_id + "',)";
            resultado = cmd.ExecuteNonQuery();

            return resultado;
        }

        public int GuardarRol(string nombre)
        {
            int resultado = 0;
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "INSERT INTO Rol (nombre)" +
                " VALUES ('" + nombre + "',)";
            resultado = cmd.ExecuteNonQuery();
            return resultado;
        }

        //actualizar
        public int ActualizarProducto(int id, string marca, string modelo, string tipo, string tamaño, decimal precio, int stock, string imagen)
        {
            int resultado = 0;
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "UPDATE Producto SET marca = '" + marca + "', modelo = '" + modelo + "', tipo = '" + tipo + "', tamaño = '" + tamaño + "', precio = '" + precio + "', stock = '" + stock + "', imagen = '" + imagen + "' WHERE id = " + id;
            resultado = cmd.ExecuteNonQuery();
            return resultado;
        }

        public int ActualizarVentas(int id, DateTime fecha, decimal total, string metodo_pago, int cliente_id)
        {
            int resultado = 0;
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "UPDATE Ventas SET fecha = '" + fecha + "', total = '" + total + "', metodo_pago = '" + metodo_pago + "', cliente_id = '" + cliente_id + "' WHERE id = " + id;
            resultado = cmd.ExecuteNonQuery();
            return resultado;
        }

        public int ActualizarDetalles_Venta(int id, int cantidad, decimal precio_unitario, decimal subtotal, int venta_id, int producto_id)
        {
            int resultado = 0;
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "UPDATE Detalles_Venta SET cantidad = '" + cantidad + "', precio_unitario = '" + precio_unitario + "', subtotal = '" + subtotal + "', venta_id = '" + venta_id + "', bicicleta_id = '" + producto_id + "' WHERE id = " + id;
            resultado = cmd.ExecuteNonQuery();
            return resultado;
        }

        public int ActualizarPedidos_Proveedores(int id, DateTime fecha_pedido, string estado, int proveedor_id)
        {
            int resultado = 0;
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "UPDATE Pedidos_Proveedores SET fecha_pedido = '" + fecha_pedido + "', estado = '" + estado + "', proveedor_id = '" + proveedor_id + "' WHERE id = " + id;
            resultado = cmd.ExecuteNonQuery();
            return resultado;
        }

        public int ActualizarDetalles_Pedido(int id, int cantidad, decimal precio_unitario, decimal subtotal, int pedidos_id, int producto_id)
        {
            int resultado = 0;
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "UPDATE Detalles_Pedido SET cantidad = '" + cantidad + "', precio_unitario = '" + precio_unitario + "', subtotal = '" + subtotal + "', pedidos_id = '" + pedidos_id + "', bicicleta_id = '" + producto_id + "' WHERE id = " + id;
            resultado = cmd.ExecuteNonQuery();
            return resultado;
        }

        public int ActualizarUsuarios(int id, string nombre, string apellido, string email, string telefono, string direccion, DateTime fecha_registro, string contraseña, string rol_id)
        {
            int resultado = 0;
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "UPDATE Usuarios SET nombre = '" + nombre + "', email = '" + email + "', contraseña = '" + contraseña + "', rol = '" + rol_id + "' WHERE id = " + id;
            resultado = cmd.ExecuteNonQuery();
            return resultado;
        }

        public int ActualizarRol(int id, string nombre)
        {
            int resultado = 0;
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "UPDATE Rol SET nombre = '" + nombre + "' WHERE id = " + id;
            resultado = cmd.ExecuteNonQuery();
            return resultado;
        }


        //eliminar

        public int EliminarProducto(int id)
        {
            int resultado = 0;
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "DELETE FROM Producto WHERE id = " + id;
            resultado = cmd.ExecuteNonQuery();
            return resultado;
        }

        public int EliminarVentas(int id)
        {
            int resultado = 0;
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "DELETE FROM Ventas WHERE id = " + id;
            resultado = cmd.ExecuteNonQuery();
            return resultado;
        }

        public int EliminarDetalles_Venta(int id)
        {
            int resultado = 0;
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "DELETE FROM Detalles_Venta WHERE id = " + id;
            resultado = cmd.ExecuteNonQuery();
            return resultado;
        }

        public int EliminarPedidos_Proveedores(int id)
        {
            int resultado = 0;
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "DELETE FROM Pedidos_Proveedores WHERE id = " + id;
            resultado = cmd.ExecuteNonQuery();
            return resultado;
        }

        public int EliminarDetalles_Pedido(int id)
        {
            int resultado = 0;
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "DELETE FROM Detalles_Pedido WHERE id = " + id;
            resultado = cmd.ExecuteNonQuery();
            return resultado;
        }

        public int EliminarUsuarios(int id)
        {
            int resultado = 0;
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "DELETE FROM Usuarios WHERE id = " + id;
            resultado = cmd.ExecuteNonQuery();
            return resultado;
        }

        public int EliminarRol(int id)
        {
            int resultado = 0;
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "DELETE FROM Rol WHERE id = " + id;
            resultado = cmd.ExecuteNonQuery();
            return resultado;
        }
    }
}

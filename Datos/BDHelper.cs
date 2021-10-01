using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using AppBTS.Negocio;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AppBTS.Datos
{
    class BDHelper
    {
        private SqlConnection conexion = new SqlConnection();
        private SqlCommand comando = new SqlCommand();
        //private string cadenaConexion = @"Data Source=DESKTOP-LK4PK50\SQLEXPRESS;Initial Catalog=BAR_PAV;Integrated Security=True";
        private string cadenaConexion = @"Data Source=localhost;Initial Catalog=BAR_PAV;Integrated Security=True";
        //private string cadenaConexion = @"Data Source=DESKTOP-GO2FK90;Initial Catalog=BAR_PAV;Integrated Security=True";
        public DataTable consultar(string consultaSQL)
        {
            DataTable tabla = new DataTable();
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();

            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = consultaSQL;
            tabla.Load(comando.ExecuteReader());
            
            
            conexion.Close();
            return tabla;
        }

        public int consultaSumaria(string consultaSQL)
        {
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();

            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = consultaSQL;
            int resultado = (int)comando.ExecuteScalar();
            return resultado;
        }

        public void insertarArticulo(Articulo art, string altaSQL)
        {
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();

            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = altaSQL;
            comando.Parameters.AddWithValue("@idArticulo", art.IdSiguiente());
            comando.Parameters.AddWithValue("@nombre", art.Nombre);
            comando.Parameters.AddWithValue("@precioUnitario", art.PrecioUnitario);
            comando.Parameters.AddWithValue("@borrado", false);
            comando.Parameters.AddWithValue("@idTipoArticulo", art.IdTipoArticulo);
            comando.ExecuteNonQuery();

            conexion.Close();
        }

        public void insertarMesa(Mesas mesa, string altaSQL)
        {
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();

            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = altaSQL;
            comando.Parameters.AddWithValue("@nroMesa", mesa.NroMesa);
            comando.Parameters.AddWithValue("@cantidadSillas", mesa.CantidadSillas);
            comando.Parameters.AddWithValue("@borrado", false);
            comando.ExecuteNonQuery();

            conexion.Close();
        }
        public void actualizar(string consulta) {
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();

            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = consulta;
            
            comando.ExecuteNonQuery();
            
            conexion.Close();
        }
        public void insertarReserva(Reservas res, string altaSQL)
        {
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();

            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = altaSQL;
            comando.Parameters.AddWithValue("@nroReserva", res.NroReserva);
            comando.Parameters.AddWithValue("@nroMesa", res.NroMesa);
            comando.Parameters.AddWithValue("@fechaReserva", res.FechaReserva);
            comando.Parameters.AddWithValue("@horaReserva", res.HoraReserva);
            comando.Parameters.AddWithValue("@nombreCliente", res.NombreCliente);
            comando.Parameters.AddWithValue("@telefono", res.Telefono);
            comando.Parameters.AddWithValue("@cantidadComensales", res.CantidadComensales);
            comando.Parameters.AddWithValue("@borrado", false);
            comando.ExecuteNonQuery();

            conexion.Close();
        }
        public void actualizar(string consulta) {
            //conexion.ConnectionString = cadenaConexion;
            //conexion.Open();

            //comando.Connection = conexion;
            //comando.CommandType = CommandType.Text;
            //comando.CommandText = consulta;
            //comando.ExecuteNonQuery();
            //conexion.Close();
        }

        public void insertarMenu(Menus menu, string altaSQL)
        {
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();

            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = altaSQL;
            comando.Parameters.AddWithValue("@idMenu", menu.IdMenu);
            comando.Parameters.AddWithValue("@nombre", menu.Nombre);
            comando.Parameters.AddWithValue("@pcioUnitario", menu.PrecioUnitario);
            comando.Parameters.AddWithValue("@borrado", menu.Borrado);
            comando.ExecuteNonQuery();

            conexion.Close();
        }
        public void insertarDetalleMenu(DetalleMenu detalle, string altaSQL)
        {
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();

            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = altaSQL;
            comando.Parameters.AddWithValue("@idMenu", detalle.IdMenu);
            comando.Parameters.AddWithValue("@idArticulo", detalle.IdArticulo);
            comando.Parameters.AddWithValue("@cantidad", detalle.Cantidad);
            comando.Parameters.AddWithValue("@borrado", detalle.Borrado);
            comando.ExecuteNonQuery();

            conexion.Close();
        }
    }
}



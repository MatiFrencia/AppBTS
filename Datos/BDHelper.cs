using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppBTS.Negocio;
namespace AppBTS.Datos
{
    class BDHelper
    {
        private SqlConnection conexion = new SqlConnection();
        private SqlCommand comando = new SqlCommand();
        private string cadenaConexion = @"Data Source=DESKTOP-LK4PK50\SQLEXPRESS;Initial Catalog=BAR_PAV;Integrated Security=True";
        //private string cadenaConexion = @"Data Source=DESKTOP-GO2FK90;Initial Catalog=BAR_PAV;Integrated Security=True";
        //private string cadenaConexion = @"Data Source=localhost;Initial Catalog=BAR_PAV;Integrated Security=True";
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
        public void insertarMesa(Mesas mesa, string altaSQL)

        public void insertarArticulo(Articulo art, string altaSQL)
        {
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();

            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = altaSQL;
            comando.Parameters.AddWithValue("@nroMesa", mesa.NroMesa);
            comando.Parameters.AddWithValue("@cantidadSillas", mesa.CantidadSillas);
            comando.Parameters.AddWithValue("@borrado", false);
            comando.Parameters.AddWithValue("@idArticulo", art.IdSiguiente());
            comando.Parameters.AddWithValue("@nombre", art.Nombre);
            comando.Parameters.AddWithValue("@precioUnitario", art.PrecioUnitario);
            comando.Parameters.AddWithValue("@borrado", false);
            comando.Parameters.AddWithValue("@idTipoArticulo", art.IdTipoArticulo);
            comando.ExecuteNonQuery();

            conexion.Close();
        }
    }
}


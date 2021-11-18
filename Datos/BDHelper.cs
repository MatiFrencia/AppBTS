using System;
using System.Collections.Generic;
using System.Data;
using AppBTS.Negocio;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AppBTS.Datos
{
    class BDHelper
    {
        private static BDHelper instancia;
        private SqlConnection conexion;
        private SqlCommand comando;
        private string cadenaConexion;
        private SqlTransaction dbTransaction;
        private BDHelper()
        {
            conexion = new SqlConnection();
            comando = new SqlCommand();
            //cadenaConexion = @"Data Source=DESKTOP-LK4PK50\SQLEXPRESS;Initial Catalog=BAR_PAV;Integrated Security=True";
            //cadenaConexion = @"Data Source=localhost;Initial Catalog=BAR_PAV;Integrated Security=True";
            cadenaConexion = @"Data Source=DESKTOP-GO2FK90;Initial Catalog=BAR_PAV;Integrated Security=True";
        }
        public static BDHelper obtenerInstancia()
        {
            if (instancia == null)
                instancia = new BDHelper();
            return instancia;
        }
        public void BeginTransaction()
        {
            if (conexion.State == ConnectionState.Open)
                dbTransaction = conexion.BeginTransaction();
        }
        public void Commit()
        {
            if (dbTransaction != null)
                dbTransaction.Commit();
        }

        public void Rollback()
        {
            if (dbTransaction != null)
                dbTransaction.Rollback();
        }
        public void Open()
        {
            if (conexion.State != ConnectionState.Open)
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
            }
        }

        public void Close()
        {
            if (conexion.State != ConnectionState.Closed)
                conexion.Close();
        }

        public DataTable consultar(string consultaSQL)
        {
            DataTable tabla = new DataTable();
            this.Open();

            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = consultaSQL;
            tabla.Load(comando.ExecuteReader());


            this.Close();
            return tabla;
        }
        public object ConsultaSQLScalar(string strSql)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {;
                cmd.Connection = conexion;
                cmd.Transaction = dbTransaction;
                cmd.CommandType = CommandType.Text;
                // Establece la instrucción a ejecutar
                cmd.CommandText = strSql;
                object scalar = cmd.ExecuteScalar();;
                return scalar;

            }
            catch (SqlException ex)
            {
                throw (ex);
            }
        }
        public int EjecutarSQLCONPARAMETROS(string strSql, Dictionary<string, object> parametros = null)
        {
            // Se utiliza para sentencias SQL del tipo “Insert/Update/Delete”

            SqlCommand cmd = new SqlCommand();

            int rtdo = 0;

            // Try Catch Finally
            // Trata de ejecutar el código contenido dentro del bloque Try - Catch
            // Si hay error lo capta a través de una excepción
            // Si no hubo error
            try
            {
                cmd.Connection = conexion;
                cmd.Transaction = dbTransaction;
                cmd.CommandType = CommandType.Text;
                // Establece la instrucción a ejecutar
                cmd.CommandText = strSql;

                //Agregamos a la colección de parámetros del comando los filtros recibidos
                foreach (var item in parametros)
                {
                    cmd.Parameters.AddWithValue(item.Key, item.Value);
                }


                // Retorna el resultado de ejecutar el comando
                rtdo = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return rtdo;
        }
        public int consultaSumaria(string consultaSQL)
        {
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();
            int resultado = 0;
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = consultaSQL;
            if (comando.ExecuteScalar().ToString() != "") 
            {
                resultado = (int)comando.ExecuteScalar();
            }
            conexion.Close();
            return resultado;
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
        public void actualizar(string consulta) 
        {
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
    }
}



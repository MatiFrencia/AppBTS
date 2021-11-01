using AppBTS.Datos;
using AppBTS.Datos.Daos;
using AppBTS.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Servicios
{
    class TipoArticuloService
    {
        private ITipoArticulo dao;
        public TipoArticuloService()
        {
            dao = new TipoArticuloDao();
        }
        public DataTable RecuperarTodos()
        {
            string consulta = "SELECT t.idTipoArticulo,t.nombre FROM TipoArticulo t";
            return BDHelper.obtenerInstancia().consultar(consulta);
        }

        public int RecuperarPorNombre(string nombre)
        {
            string consulta = "SELECT t.idTipoArticulo FROM TipoArticulo t WHERE t.nombre='" + nombre + "'";
            DataTable tabla = BDHelper.obtenerInstancia().consultar(consulta);
            return Convert.ToInt32(tabla.Rows[0][0]);
        }
        public string RecuperarPorId(int id)
        {
            string consulta = "SELECT t.nombre FROM TipoArticulo t WHERE t.idTipoArticulo = " + id.ToString();
            DataTable tabla = BDHelper.obtenerInstancia().consultar(consulta);
            return tabla.Rows[0][0].ToString();
        }
    }
}

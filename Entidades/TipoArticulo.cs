using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using AppBTS.Datos;
using System.Threading.Tasks;

namespace AppBTS.Negocio
{
    class TipoArticulo
    {
        private int idTipoArticulo;
        private string nombre;

        public int IdTipoArticulo { get; set; }
        public string Nombre { get; set; }

        public DataTable RecuperarTodos()
        {
            string consulta = "SELECT t.idTipoArticulo,t.nombre FROM TipoArticulo t";
            //BDHelper oDatos = new BDHelper();
            return BDHelper.obtenerInstancia().consultar(consulta);
        }

        public int RecuperarPorNombre(string nombre)
        {
            string consulta = "SELECT t.idTipoArticulo FROM TipoArticulo t WHERE t.nombre='" + nombre + "'";
           // BDHelper oDatos = new BDHelper();
            DataTable tabla = BDHelper.obtenerInstancia().consultar(consulta);
            return Convert.ToInt32(tabla.Rows[0][0]);
        }
        public string RecuperarPorId(int id)
        {
            string consulta = "SELECT t.nombre FROM TipoArticulo t WHERE t.idTipoArticulo = " + id.ToString();
           // BDHelper oDatos = new BDHelper();
            DataTable tabla = BDHelper.obtenerInstancia().consultar(consulta);
            return tabla.Rows[0][0].ToString();
        }
    }
}

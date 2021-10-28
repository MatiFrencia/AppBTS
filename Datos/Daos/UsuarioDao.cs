using AppBTS.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Datos.Daos
{
    class UsuarioDao: IUsuario
    {
        public int validarUsuario(string nombre, string clave)
        {
            string consulta = "SELECT * FROM Usuarios WHERE usuario='" + nombre + "' AND password='" + clave + "'";

            //BDHelper oDatos = new BDHelper();
            DataTable tabla = BDHelper.obtenerInstancia().consultar(consulta);
            if (tabla.Rows.Count > 0)
                return (int)tabla.Rows[0][0];
            else
                return 0;
        }
        public DataTable RecuperarTodos()
        {
            string consulta = "SELECT * FROM Usuarios WHERE borrado = 0 order by usuario";

            //BDHelper oDatos = new BDHelper();
            return BDHelper.obtenerInstancia().consultar(consulta);
        }
    }
}

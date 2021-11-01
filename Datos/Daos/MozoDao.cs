using AppBTS.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Datos.Daos
{
    class MozoDao : IMozo
    {
        public DataTable traerTodos()
        {
            string consulta = "SELECT m.idMozo,m.nombre,m.apellido FROM Mozos m WHERE m.borrado=0";
            //BDHelper oDatos = new BDHelper();
            DataTable tabla = BDHelper.obtenerInstancia().consultar(consulta);
            return tabla;
        }

        public DataTable traerSegunId(int id)
        {
            string consulta = "SELECT m.idMozo,m.nombre,m.apellido FROM Mozos m WHERE m.idMozo=" + id + " AND m.borrado=0";
            //BDHelper oDatos = new BDHelper();
            DataTable tabla = BDHelper.obtenerInstancia().consultar(consulta);
            return tabla;
        }
        public void Eliminar(int id)
        {
            string baja = "UPDATE Mozos SET borrado = 1 WHERE idMozo=" + id.ToString();
            //BDHelper oBaja = new BDHelper();
            BDHelper.obtenerInstancia().actualizar(baja);
        }
        public void Modificar(int id, string nombre, string apellido)
        {
            string modificacion = "UPDATE Mozos SET nombre = '" + nombre + "' ,apellido = '" + apellido + "' WHERE idMozo= '" + id.ToString() + "'";
            //BDHelper oModificacion = new BDHelper();
            BDHelper.obtenerInstancia().actualizar(modificacion);
        }
        public void Insertar(int id, string nombre, string apellido)
        {
            string modificacion = "INSERT INTO Mozos VALUES('" + id.ToString() + "','" + nombre + "','" + apellido + "',0)";
            //BDHelper oModificacion = new BDHelper();
            BDHelper.obtenerInstancia().actualizar(modificacion);
        }
        public int IdSiguiente()
        {
            string consulta = "SELECT m.idMozo FROM Mozos m ORDER BY m.idMozo DESC";
            //BDHelper oDatos = new BDHelper();
            DataTable ids = BDHelper.obtenerInstancia().consultar(consulta);
            int ultimo;
            if (ids.Rows.Count == 0)
            {
                ultimo = 0;
            }
            else
            {
                ultimo = Convert.ToInt32(ids.Rows[0][0]);
            }
            return ultimo + 1;
        }
    }
}

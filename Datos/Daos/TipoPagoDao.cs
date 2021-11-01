using AppBTS.Datos.Interfaces;
using AppBTS.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Datos.Daos
{
    class TipoPagoDao: ITipoPago
    {
        public void Registrar(TipoPago Tpago)
        {
            string alta = "INSERT INTO TipoPago([idTipoPago],[nombre],[descripcion]) " +
                          "VALUES(" + Tpago.IdTipoPago.ToString() + ",'"
                                    + Tpago.Nombre + "','"
                                    + Tpago.Descripcion + "',)";
            //BDHelper oAlta = new BDHelper(); Se cambia en vez de crear una instancia de BDHELPER para cada vez que queremos acceder
            // usamos la misma instancia si es que existe y si no existe la creamos 1 sola vez.
            BDHelper.obtenerInstancia().actualizar(alta);
        }
        public void Modificar(string nombre, string descripcion, TipoPago Tpago)
        {
            string modificacion = "UPDATE TipoPago SET nombre = '" + nombre + "', descripcion = '" + descripcion + "' WHERE idMenu = " + Tpago.IdTipoPago.ToString();
            //BDHelper oModificacion = new BDHelper();
            BDHelper.obtenerInstancia().actualizar(modificacion);
        }
        public DataTable RecuperarTodos()
        {
            string consulta = "SELECT t.idTipoPago,t.nombre,t.descripcion FROM TipoPago t ";
            //BDHelper oDatos = new BDHelper();
            DataTable tabla = BDHelper.obtenerInstancia().consultar(consulta);
            return tabla;
        }
    }
}

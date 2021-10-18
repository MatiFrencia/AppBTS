using AppBTS.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppBTS.Negocio;

namespace AppBTS.Datos.Daos
{
    class ArticuloDao : IArticulo

    {
        public void Registrar(Articulo art)
        {
            string alta = "INSERT INTO Articulos([idArticulo],[nombre],[pcioUnitario],[borrado],[idTipoArticulo]) " +
                          "VALUES(" + art.IdArticulo.ToString() + ",'" 
                                    + art.Nombre + "',"
                                    + art.PrecioUnitario.ToString() + "," 
                                    + "0,"
                                    + art.IdTipoArticulo.ToString() + ")";
            //BDHelper oAlta = new BDHelper(); Se cambia en vez de crear una instancia de BDHELPER para cada vez que queremos acceder
            // usamos la misma instancia si es que existe y si no existe la creamos 1 sola vez.
            BDHelper.obtenerInstancia().actualizar(alta);
        }

        public int IdSiguiente()
        {
            string consulta = "SELECT a.idArticulo FROM Articulos a ORDER BY a.idArticulo DESC";
            //BDHelper oDatos = new BDHelper();
            int ultimo = 0;
            DataTable ids = BDHelper.obtenerInstancia().consultar(consulta);
            if (ids.Rows.Count != 0)
            {
                ultimo = Convert.ToInt32(ids.Rows[0][0]);
            }
            return ultimo + 1;
        }

        public double RecuperarPrecio(string idArticulo)
        {
            string consulta = "SELECT pcioUnitario FROM Articulos WHERE idArticulo=" + idArticulo;
            //BDHelper oDatos = new BDHelper();
            DataTable pcio = BDHelper.obtenerInstancia().consultar(consulta);
            double precio = Convert.ToDouble(pcio.Rows[0]["pcioUnitario"]);
            return precio;
        }

        public DataTable RecuperarFiltrados(string idArticulo, string nombre, string idTipoArticulo)
        {
            string consulta = "SELECT a.idArticulo,a.nombre,a.pcioUnitario,t.nombre AS nombreTipo FROM Articulos a,TipoArticulo t WHERE a.borrado=0" +
                              " AND a.idTipoArticulo=t.idTipoArticulo";
            if (idArticulo != "")
                consulta += " AND a.idArticulo=" + idArticulo;
            if (nombre != "")
                consulta += " AND a.nombre LIKE '%" + nombre + "%'";
            if (idTipoArticulo != "")
                consulta += " AND a.idTipoArticulo=" + idTipoArticulo;
            //BDHelper oDatos = new BDHelper();
            DataTable tabla = BDHelper.obtenerInstancia().consultar(consulta);
            return tabla;
        }
        public void Modificar(bool mNombre, bool mPrecio, bool mTipo, Articulo art)
        {
            string modificacion = "UPDATE Articulos SET ";
            if (mNombre)
            {
                modificacion += "nombre = '" + art.Nombre + "'";
                if (mPrecio || mTipo)
                    modificacion += ", ";
            }
            if (mPrecio)
            {
                modificacion += "pcioUnitario = " + art.PrecioUnitario.ToString();
                if (mTipo)
                    modificacion += ", ";
            }
            if (mTipo)
                modificacion += "idTipoArticulo = " + art.IdTipoArticulo.ToString();
            modificacion += " WHERE idArticulo=" + art.IdArticulo.ToString();
            //BDHelper oModificacion = new BDHelper();
            BDHelper.obtenerInstancia().actualizar(modificacion);
        }
        public DataTable RecuperarTodos()
        {
            string consulta = "SELECT a.idArticulo,a.nombre,a.pcioUnitario,t.nombre AS nombreTipo FROM Articulos a,TipoArticulo t WHERE a.borrado=0" +
                              " AND a.idTipoArticulo=t.idTipoArticulo";
            //BDHelper oDatos = new BDHelper();
            DataTable tabla = BDHelper.obtenerInstancia().consultar(consulta);
            return tabla;
        }
        public void Eliminar(int idArticulo)
        {
            string baja = "UPDATE Articulos SET borrado = 1 WHERE idArticulo=" + idArticulo.ToString();
            //BDHelper oBaja = new BDHelper();
            BDHelper.obtenerInstancia().actualizar(baja);
        }
    }
}

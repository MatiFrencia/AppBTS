using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AppBTS.Datos;

namespace AppBTS.Negocio
{
    public class Articulo
    {
        public int IdArticulo { get; set; }
        public string Nombre { get; set; }
        public double PrecioUnitario { get; set; }
        public bool Borrado { get; set; }
        public int IdTipoArticulo { get; set; }

        public void Registrar()
        {
            string alta = "INSERT INTO Articulos VALUES(@idArticulo,@nombre,@precioUnitario,@borrado,@idTipoArticulo)";
            BDHelper oAlta = new BDHelper();
            oAlta.insertarArticulo(this, alta);
        }

        public int IdSiguiente()
        {
            string consulta = "SELECT a.idArticulo FROM Articulos a ORDER BY a.idArticulo DESC";
            BDHelper oDatos = new BDHelper();
            DataTable ids = oDatos.consultar(consulta);
            int ultimo = Convert.ToInt32(ids.Rows[0][0]);
            return ultimo + 1;
        }

        public double RecuperarPrecio(string idArticulo)
        {
            string consulta = "SELECT pcioUnitario FROM Articulos WHERE idArticulo=" + idArticulo;
            BDHelper oDatos = new BDHelper();
            DataTable pcio = oDatos.consultar(consulta);
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
            BDHelper oDatos = new BDHelper();
            DataTable tabla = oDatos.consultar(consulta);
            return tabla;
        }
        public void Modificar(bool mNombre, bool mPrecio, bool mTipo)
        {
            string modificacion = "UPDATE Articulos SET ";
            if (mNombre)
            {
                modificacion += "nombre = '" + Nombre + "'";
                if (mPrecio||mTipo)
                    modificacion += ", ";
            }
            if (mPrecio)
            {
                modificacion += "pcioUnitario = " + PrecioUnitario.ToString();
                if (mTipo)
                    modificacion += ", ";
            }
            if (mTipo)
                modificacion += "idTipoArticulo = " + IdTipoArticulo.ToString();
            modificacion += " WHERE idArticulo=" + IdArticulo.ToString();
            BDHelper oModificacion = new BDHelper();
            oModificacion.actualizar(modificacion);
        }
        public DataTable RecuperarTodos()
        {
            string consulta = "SELECT a.idArticulo,a.nombre,a.pcioUnitario,t.nombre AS nombreTipo FROM Articulos a,TipoArticulo t WHERE a.borrado=0" +
                              " AND a.idTipoArticulo=t.idTipoArticulo";
            BDHelper oDatos = new BDHelper();
            DataTable tabla = oDatos.consultar(consulta);
            return tabla;
        }
        public void Eliminar()
        {
            string baja = "UPDATE Articulos SET borrado = 1 WHERE idArticulo=" + IdArticulo.ToString();
            BDHelper oBaja = new BDHelper();
            oBaja.actualizar(baja);
        }
    }
}

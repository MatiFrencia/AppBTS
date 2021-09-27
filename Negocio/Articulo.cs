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
        private int idArticulo;
        private string nombre;
        private double precioUnitario;
        private bool borrado;
        private int idTipoArticulo;

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
    }
}

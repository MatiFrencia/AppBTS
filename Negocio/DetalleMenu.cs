using System;
using System.Collections.Generic;
using System.Linq;
using AppBTS.Datos;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace AppBTS.Negocio
{
    public class DetalleMenu
    {
        public int IdMenu { get; set; }
        public int IdArticulo { get; set; }
        public int Cantidad { get; set; }
        public bool Borrado { get; set; }

        public void Registrar()
        {
            string alta = "INSERT INTO DetallesMenu VALUES(@idMenu,@idArticulo,@cantidad,@borrado)";
            BDHelper oAlta = new BDHelper();
            oAlta.insertarDetalleMenu(this, alta);
        }

        public DataTable RecuperarPorMenu(string idMenu)
        {
            string consulta = "SELECT t.nombre AS nombreTipo,a.nombre AS nombreArticulo,d.cantidad FROM TipoArticulo t INNER JOIN Articulos a ON " +
                "t.idTipoArticulo=a.idTipoArticulo INNER JOIN DetallesMenu d ON a.idArticulo=d.idArticulo WHERE d.idMenu=" + idMenu;
            BDHelper oDatos = new BDHelper();
            DataTable tabla = oDatos.consultar(consulta);
            return tabla;
        }
    }
}

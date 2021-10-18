using AppBTS.Datos.Interfaces;
using AppBTS.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Datos.Daos
{
    class DetalleMenuDao : IDetalleMenu
    {
        public void Registrar(DetalleMenu dMenu)
        {
            string alta = "INSERT INTO [dbo].[DetallesMenu] ([idMenu],[idArticulo],[cantidad],[borrado])" +
                " VALUES(" + dMenu.IdMenu.ToString() + "," 
                           + dMenu.IdArticulo.ToString() + "," 
                           + dMenu.Cantidad.ToString() + "," 
                           + "0)";
            //BDHelper oAlta = new BDHelper();
            BDHelper.obtenerInstancia().actualizar(alta);
        }

        public DataTable RecuperarPorMenu(string idMenu)
        {
            string consulta = "SELECT t.nombre AS nombreTipo,a.nombre AS nombreArticulo,d.cantidad FROM TipoArticulo t INNER JOIN Articulos a ON " +
                "t.idTipoArticulo=a.idTipoArticulo INNER JOIN DetallesMenu d ON a.idArticulo=d.idArticulo WHERE d.idMenu=" + idMenu;
            //BDHelper oDatos = new BDHelper();
            DataTable tabla = BDHelper.obtenerInstancia().consultar(consulta);
            return tabla;
        }
    }
}

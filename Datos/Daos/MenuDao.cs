using AppBTS.Datos.Interfaces;
using AppBTS.Negocio;
using AppBTS.Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Datos.Daos
{
    class MenuDao : IMenu
    {
        private DetalleMenuService miGestor = new DetalleMenuService();
        public void Registrar(Menus menu)
        {
            string alta = "INSERT INTO [dbo].[Menus]([idMenu],[nombre],[pcioUnitario],[borrado]) " +
                "VALUES (" + menu.IdMenu.ToString() + ",'" 
                           + menu.Nombre + "'," 
                           + menu.PrecioUnitario.ToString() 
                           + ",0)";
            //BDHelper oAlta = new BDHelper();
            BDHelper.obtenerInstancia().actualizar(alta);
            foreach (DetalleMenu detalle in menu.DetallesMenu)
            {
                miGestor.Registrar(detalle);
            }
        }
        public int IdSiguiente()
        {
            string consulta = "SELECT MAX(idMenu) AS MaxId FROM Menus";
            //BDHelper oDatos = new BDHelper();
            int maxId = BDHelper.obtenerInstancia().consultaSumaria(consulta);
            return maxId + 1;
        }
        public DataTable RecuperarTodos()
        {
            string consulta = "SELECT m.idMenu,m.nombre,m.pcioUnitario FROM Menus m WHERE m.borrado=0";
            //BDHelper oDatos = new BDHelper();
            DataTable tabla = BDHelper.obtenerInstancia().consultar(consulta);
            return tabla;
        }
        public DataTable RecuperarFiltrados(string idMenu, string nombre, string idTipoArticulo, string idArticulo)
        {
            string consulta = "SELECT DISTINCT m.idMenu,m.nombre,m.pcioUnitario";
            if (idArticulo != "")
                consulta += " FROM Menus m INNER JOIN DetallesMenu d ON m.idMenu=d.idMenu WHERE m.borrado=0 AND idArticulo = " + idArticulo;
            else
            {
                if (idTipoArticulo != "")
                    consulta += " FROM Menus m INNER JOIN DetallesMenu d ON m.idMenu=d.idMenu INNER JOIN Articulos a ON d.idArticulo=a.idArticulo WHERE m.borrado=0";
                else
                    consulta += " FROM Menus m WHERE m.borrado=0";
            }
            if (idMenu != "")
                consulta += " AND m.idMenu=" + idMenu;
            if (nombre != "")
                consulta += " AND m.nombre LIKE '%" + nombre + "%'";
            if (idTipoArticulo != "")
            {
                if (idArticulo != "")
                    consulta += " AND d.idArticulo=" + idArticulo;
                else
                    consulta += " AND a.idTipoArticulo=" + idTipoArticulo;
            }
            //BDHelper oDatos = new BDHelper();
            DataTable tabla = BDHelper.obtenerInstancia().consultar(consulta);
            return tabla;
        }

        public void Eliminar(Menus menu)
        {
            string baja = "UPDATE Menus SET borrado = 1 WHERE idMenu=" + menu.IdMenu.ToString();
            //BDHelper oBaja = new BDHelper();
            BDHelper.obtenerInstancia().actualizar(baja);
        }
        public void Modificar(int idMenu, string nombre, int pcioUnitario)
        {
            string modificacion = "UPDATE Menus SET nombre = '" + nombre + "', pcioUnitario = " + pcioUnitario.ToString() + " WHERE idMenu = " + idMenu.ToString();
            //BDHelper oModificacion = new BDHelper();
            BDHelper.obtenerInstancia().actualizar(modificacion);
        }
    }
}

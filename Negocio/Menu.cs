using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AppBTS.Datos;
using System.Data;
using System.Threading.Tasks;

namespace AppBTS.Negocio
{
    public class Menus
    {
        public int IdMenu { get; set; }
        public string Nombre { get; set; }
        public double PrecioUnitario { get; set; }
        public bool Borrado { get; set; }
        public DetalleMenu[] DetallesMenu { get; set; }

        public void Registrar()
        {
            string alta = "INSERT INTO Menus VALUES(@idMenu,@nombre,@pcioUnitario,@borrado)";
            BDHelper oAlta = new BDHelper();
            oAlta.insertarMenu(this, alta);
            foreach (DetalleMenu detalle in DetallesMenu)
            {
                detalle.Registrar();
            }
        }
        public int IdSiguiente()
        {
            string consulta = "SELECT MAX(idMenu) AS MaxId FROM Menus";
            BDHelper oDatos = new BDHelper();
            int maxId = oDatos.consultaSumaria(consulta);
            return maxId + 1;
        }
        public DataTable RecuperarTodos()
        {
            string consulta = "SELECT m.idMenu,m.nombre,m.pcioUnitario FROM Menus m WHERE m.borrado=0";
            BDHelper oDatos = new BDHelper();
            DataTable tabla = oDatos.consultar(consulta);
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
            BDHelper oDatos = new BDHelper();
            DataTable tabla = oDatos.consultar(consulta);
            return tabla;
        }

        public void Eliminar()
        {
            string baja = "UPDATE Menus SET borrado = 1 WHERE idMenu=" + IdMenu.ToString();
            BDHelper oBaja = new BDHelper();
            oBaja.actualizar(baja);
        }
        public void Modificar(int idMenu, string nombre, int pcioUnitario)
        {
            string modificacion = "UPDATE Menus SET nombre = '" + nombre + "', pcioUnitario = " + pcioUnitario.ToString() + " WHERE idMenu = " + idMenu.ToString();
            BDHelper oModificacion = new BDHelper();
            oModificacion.actualizar(modificacion);
        }
    }
}

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
    class DetallesTicketDao: IDetallesTicket
    {
        public void Registrar(DetallesTicket detallesTicket)
        {
            string alta = "INSERT INTO DetallesTicket([nroTicket],[orden],[idMenu],[cantidad],[pcioUnitario],[borrado],[descuento]) " +
                          "VALUES(" + detallesTicket.NroTicket.ToString() + ","
                                    + detallesTicket.Orden + ","
                                    + detallesTicket.IdMenu + ","
                                    + detallesTicket.Cantidad + "," 
                                    + detallesTicket.PcioUnitario + ","
                                    + "0" + ","
                                    + detallesTicket.Descuento + ")";
            //BDHelper oAlta = new BDHelper(); Se cambia en vez de crear una instancia de BDHELPER para cada vez que queremos acceder
            // usamos la misma instancia si es que existe y si no existe la creamos 1 sola vez.
            BDHelper.obtenerInstancia().actualizar(alta);
        }
        public DataTable RecuperarTodos()
        {
            string consulta = "SELECT d.nroTicket,d.orden,d.idMenu, d.cantidad, d.pcioUnitario, d.borrado, d.descuento FROM DetallesTicket d ";
            DataTable tabla = BDHelper.obtenerInstancia().consultar(consulta);
            return tabla;
        }
        public DataTable RecuperarTodosConParametros(string idMenu, string fechaDesde, string fechaHasta)
        {
            string consulta = "SET DATEFORMAT 'YMD' \nSELECT t.fecha as fechaT,d.orden,m.nombre as nombreM, d.cantidad, d.pcioUnitario, d.borrado, d.descuento " +
                " FROM DetallesTicket d, Tickets t, Menus m" +
                " WHERE d.nroTicket = t.nroTicket" +
                " AND d.idMenu = m.idMenu";
            consulta += " AND t.fecha BETWEEN '" + fechaDesde + "' AND '" + fechaHasta + "'";
            if (idMenu != "")
                consulta += " AND d.idMenu=" + idMenu;
            consulta += " ORDER BY d.nroTicket DESC";
            DataTable tabla = BDHelper.obtenerInstancia().consultar(consulta);
            return tabla;
        }
    }
}

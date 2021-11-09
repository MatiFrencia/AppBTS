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
    class TicketDao: ITicket
    {
        public void Registrar(Ticket ticket)
        {
            BDHelper dm = BDHelper.obtenerInstancia();
            try
            {
                dm.Open();
                dm.BeginTransaction();

                string sql = string.Concat("INSERT INTO [dbo].[Tickets] ",
                                            "           ([fecha]         ",
                                            "           ,[hora]      ",
                                            "           ,[idMozo]   ",
                                            "           ,[nroMesa]   ",
                                            "           ,[borrado]    ",
                                            "           ,[idTipoPago]    ",
                                            "           ,[total])      ",
                                            "     VALUES                 ",
                                            "           (@fecha         ",
                                            "           ,@hora        ",
                                            "           ,@idMozo    ",
                                            "           ,@nroMesa     ",
                                            "           ,@borrado     ",
                                            "           ,@idTipoPago     ",
                                            "           ,@total)       ");


                var parametros = new Dictionary<string, object>();
                
                
                parametros.Add("fecha", ticket.Fecha);
                parametros.Add("hora", ticket.Hora);
                parametros.Add("idMozo", ticket.IdMozo);
                parametros.Add("nroMesa", ticket.NroMesa);
                parametros.Add("borrado", false);
                parametros.Add("idTipoPago", ticket.IdTipoPago);
                parametros.Add("total", ticket.Total);

                dm.EjecutarSQLCONPARAMETROS(sql, parametros);
                var newId = dm.ConsultaSQLScalar(" SELECT @@IDENTITY");
                if (newId != null)
                {
                    ticket.NroTicket = Convert.ToInt32(newId);
                }
                else
                {
                    ticket.NroTicket = 1;
                }

                foreach (var itemDetalle in ticket.DetallesTickets)
                {
                    string sqlDetalle = string.Concat("INSERT INTO [dbo].[DetallesTicket] ",
                                            "           ([nroTicket]         ",
                                            "           ,[idMenu]      ",
                                            "           ,[cantidad]   ",
                                            "           ,[pcioUnitario]   ",
                                            "           ,[borrado]    ",
                                            "           ,[descuento])      ",
                                            "     VALUES                 ",
                                            "           (@nroTicket         ",
                                            "           ,@idMenu        ",
                                            "           ,@cantidad    ",
                                            "           ,@pcioUnitario     ",
                                            "           ,@borrado     ",
                                            "           ,@descuento)       ");


                    var paramDetalle = new Dictionary<string, object>();


                    paramDetalle.Add("nroTicket", ticket.NroTicket);
                    paramDetalle.Add("idMenu", itemDetalle.IdMenu);
                    paramDetalle.Add("cantidad", itemDetalle.Cantidad);
                    paramDetalle.Add("pcioUnitario", itemDetalle.PcioUnitario);
                    paramDetalle.Add("borrado", false);
                    paramDetalle.Add("descuento", itemDetalle.Descuento);

                    dm.EjecutarSQLCONPARAMETROS(sqlDetalle, paramDetalle);
                }

                dm.Commit();

            }
            catch (Exception ex)
            {
                dm.Rollback();
                throw ex;
            }
            finally
            {
                // Cierra la conexión 
                dm.Close();
            }
        }
        public DataTable RecuperarTodos()
        {
            string consulta = "SELECT t.nroTicket,t.fecha,t.hora,o.nombre as nombreM,m.nroMesa,p.nombre as nombreP,t.total"
                                        + " FROM Tickets t, Mesas m, TipoPago p, Mozos o"
                                        + " WHERE t.nroTicket=t.nroTicket"
                                        + " AND t.nroMesa=m.nroMesa"
                                        + " AND t.idMozo=o.idMozo"
                                        + " AND t.idTipoPago=p.idTipoPago"
                                        + " AND t.borrado=0";
            //BDHelper oDatos = new BDHelper();
            DataTable tabla = BDHelper.obtenerInstancia().consultar(consulta);
            return tabla;
        }
        public DataTable RecuperarTodosConParametros(string nroTicket, string fechaDesde, string fechaHasta, string horaDesde, string horaHasta, string idMozo, string nroMesa, string idTipoPago, string Totaldesde, string Totalhasta)
        {
            string consulta = "SELECT t.nroTicket,t.fecha,t.hora,o.nombre as nombreM,m.nroMesa,p.nombre as nombreP,t.total"
                                        + " FROM Tickets t, Mesas m, TipoPago p, Mozos o"
                                        + " WHERE t.nroTicket=t.nroTicket"
                                        + " AND t.nroMesa=m.nroMesa"
                                        + " AND t.idMozo=o.idMozo"
                                        + " AND t.idTipoPago=p.idTipoPago"
                                        + " AND t.borrado=0";
            consulta += " AND t.fecha BETWEEN '" + fechaDesde + "' AND '" + fechaHasta + "'";
            consulta += " AND t.hora BETWEEN '" + horaDesde + "' AND '" + horaHasta + "'";
            consulta += " AND t.total BETWEEN " + Totaldesde + " AND " + Totalhasta;

            if (nroTicket != "")
                consulta += " AND t.nroTicket=" + nroTicket;
            if (nroMesa != "")
                consulta += " AND t.nroMesa=" + nroMesa;
            if (idMozo != string.Empty)
                consulta += " AND t.idMozo= '" + idMozo + "'";
            if (idTipoPago != "")
                consulta += " AND t.idTipoPago=" + idTipoPago;
            consulta += " ORDER BY t.fecha DESC";
            return BDHelper.obtenerInstancia().consultar(consulta);
        }
        
        public int CantidadTicketsPorHorario(string horaDesde, string horaHasta, string fechaDesde, string fechaHasta)
        {
            string consulta = "SELECT COUNT(nroTicket) FROM Tickets WHERE hora BETWEEN '" + horaDesde + "' AND '" + horaHasta + "' AND fecha BETWEEN '"
                                + fechaDesde + "' AND '" + fechaHasta + "'";
            BDHelper dm = BDHelper.obtenerInstancia();
            dm.Open();
            int valor = (int)dm.consultar(consulta).Rows[0][0];
            dm.Close();
            return valor;
        }

        public double VentasPorHorario(string horaDesde, string horaHasta, string fechaDesde, string fechaHasta)
        {
            string consulta = "SELECT SUM(total) FROM Tickets WHERE hora BETWEEN '" + horaDesde + "' AND '" + horaHasta + "' AND fecha BETWEEN '"
                                + fechaDesde + "' AND '" + fechaHasta + "'";
            double valor;
            if (BDHelper.obtenerInstancia().consultar(consulta).Rows[0][0].ToString() != "")
            {
                valor = Convert.ToDouble(BDHelper.obtenerInstancia().consultar(consulta).Rows[0][0]);
            }
            else
            {
                valor = 0;
            }

            return valor;
        }
    }
}

using AppBTS.Datos.Daos;
using AppBTS.Datos.Interfaces;
using AppBTS.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Servicios
{
    class TicketService
    {
        private ITicket dao;
        public TicketService()
        {
            dao = new TicketDao();
        }
        public void Registrar(Ticket ticket)
        {
            dao.Registrar(ticket);
        }
        public DataTable RecuperarTodos()
        {
            return dao.RecuperarTodos();
        }
        public DataTable RecuperarTodosConParametros(string nroTicket, string fechaDesde, string fechaHasta, string horaDesde, string horaHasta, string idMozo, string nroMesa, string idTipoPago, string Totaldesde, string Totalhasta)
        {
            return dao.RecuperarTodosConParametros(nroTicket, fechaDesde, fechaHasta, horaDesde, horaHasta, idMozo, nroMesa, idTipoPago, Totaldesde, Totalhasta);
        }
    }
}

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
    class DetallesTicketService
    {
        private IDetallesTicket dao;
        public DetallesTicketService()
        {
            dao = new DetallesTicketDao();
        }
        public void Registrar(DetallesTicket Dticket)
        {
            dao.Registrar(Dticket);
        }
        public DataTable RecuperarTodos()
        {
            return dao.RecuperarTodos();
        }
        public DataTable RecuperarTodosConParametros(string _idMenu, string fechaDesde, string fechaHasta)
        {
            return dao.RecuperarTodosConParametros(_idMenu, fechaDesde, fechaHasta);
        }
    }
}

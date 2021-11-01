using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppBTS.Entidades;
using AppBTS.Negocio;

namespace AppBTS.Datos.Interfaces
{
    interface ITicket
    {
        DataTable RecuperarTodos();
        void Registrar(Ticket ticket);

        DataTable RecuperarTodosConParametros(string nroTicket, string fechaDesde, string fechaHasta, string horaDesde, string horaHasta, string idMozo, string nroMesa, string idTipoPago, string Totaldesde, string Totalhasta);
    }
}

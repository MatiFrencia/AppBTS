using AppBTS.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Datos.Interfaces
{
    interface IDetallesTicket
    {
        DataTable RecuperarTodos();
        DataTable RecuperarTodosConParametros(string idMenu, string fechaDesde, string fechaHasta);
        void Registrar(DetallesTicket detallesTicket);
    }
}

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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Entidades
{
    class Ticket
    {
        public int NroTicket { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public int IdMozo { get; set; }
        public int NroMesa { get; set; }
        public int IdTipoPago { get; set; }
        public double Total { get; set; }
        public bool Borrado { get; set; }
        public IList<DetallesTicket> DetallesTickets { get; set; }
    }
}

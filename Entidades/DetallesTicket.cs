using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Entidades
{
    class DetallesTicket
    {
        public int NroTicket { get; set; }
        public double PcioUnitario { get; set; }
        public int Orden { get; set; }
        public int IdMenu { get; set; }
        public int Descuento { get; set; }
        public int Cantidad { get; set; }
        public bool Borrado { get; set; }
    }
}

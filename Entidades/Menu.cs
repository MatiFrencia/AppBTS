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
    }
}

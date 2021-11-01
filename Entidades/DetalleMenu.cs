using System;
using System.Collections.Generic;
using System.Linq;
using AppBTS.Datos;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace AppBTS.Negocio
{
    public class DetalleMenu
    {
        public int IdMenu { get; set; }
        public int IdArticulo { get; set; }
        public int Cantidad { get; set; }
        public bool Borrado { get; set; }
    }
}

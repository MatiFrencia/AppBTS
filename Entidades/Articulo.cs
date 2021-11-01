using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AppBTS.Datos;

namespace AppBTS.Negocio
{
    public class Articulo
    {
        public int IdArticulo { get; set; }
        public string Nombre { get; set; }
        public double PrecioUnitario { get; set; }
        public bool Borrado { get; set; }
        public int IdTipoArticulo { get; set; }
    }
}

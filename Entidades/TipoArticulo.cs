using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using AppBTS.Datos;
using System.Threading.Tasks;

namespace AppBTS.Negocio
{
    class TipoArticulo
    {
        private int idTipoArticulo;
        private string nombre;
        public int IdTipoArticulo { get; set; }
        public string Nombre { get; set; }  
    }
}

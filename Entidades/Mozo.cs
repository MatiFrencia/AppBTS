using AppBTS.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AppBTS.Negocio
{
    class Mozo
    {
        public int idMozo { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public bool Borrado { get; set; }
    }
}

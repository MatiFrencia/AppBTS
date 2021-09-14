using AppBTS.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Negocio
{
    class Mesas
    {
        public int NroMesa { get; set; }
        public string CantidadSillas { get; set; }
        public bool Borrado { get; set; }

        public DataTable RecuperarTodos()
        {
            string consulta = "SELECT * FROM Mesas WHERE borrado = 0 order by nroMesa";

            BDHelper oDatos = new BDHelper();
            return oDatos.consultar(consulta);
        }
    }
}

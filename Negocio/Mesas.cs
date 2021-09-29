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

        public void AgregarMesa()
        {
            string alta = "INSERT INTO Mesas"
                            + " VALUES"
                            + " (@nroMesa, + @cantidadSillas, @borrado)";
            BDHelper oAlta = new BDHelper();
            oAlta.insertarMesa(this, alta);
        }
        public void Borrar(string mesaClickeada)
        {
            string consulta = " UPDATE Mesas"
                            + " SET borrado = 1"
                            + " WHERE nroMesa = " + mesaClickeada;

            BDHelper oDatos = new BDHelper();
            oDatos.consultar(consulta);


        }
    }
}

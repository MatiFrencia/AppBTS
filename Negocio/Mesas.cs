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

        public DataTable RecuperarBorrados()
        {
            string consulta = "SELECT * FROM Mesas WHERE borrado = 1 order by nroMesa";

            BDHelper oDatos = new BDHelper();
            return oDatos.consultar(consulta);
        }

        public void AgregarMesa(string nroMesa)
        {
            if (VerificarExistencia(nroMesa).Rows.Count == 0) 
            { 
                string alta = "INSERT INTO Mesas"
                                + " VALUES"
                                + " (" + nroMesa + ", @cantidadSillas, @borrado)";
                BDHelper oAlta = new BDHelper();
                oAlta.insertarMesa(this, alta);
            }
            else
            {
                LevantarMesa(nroMesa);
            }
        }

        public DataTable VerificarExistencia(string nroMesa)
        { 
            string verificacion = "SELECT 1 FROM Mesas WHERE nroMesa = " + nroMesa;
            BDHelper oVerificacion = new BDHelper();
            return oVerificacion.consultar(verificacion);
        }
        public void LevantarMesa(string nroMesa)
        {
            string consulta = " UPDATE Mesas"
                            + " SET borrado = 0"
                            + " WHERE nroMesa = " + nroMesa;

            BDHelper oDatos = new BDHelper();
            oDatos.consultar(consulta);
        }
        public void Borrar(string mesaClickeada)
        {
            string consulta = " UPDATE Mesas"
                            + " SET borrado = 1"
                            + " WHERE nroMesa = " + mesaClickeada;

            BDHelper oDatos = new BDHelper();
            oDatos.consultar(consulta);
        }

        public int IdSiguiente()
        {
            string consulta = "SELECT MAX(nroMesa) FROM Mesas WHERE borrado = 0";
            BDHelper oDatos = new BDHelper();
            DataTable idmax = oDatos.consultar(consulta);
            int id = Convert.ToInt32(idmax.Rows[0][0].ToString());
            return id + 1;
        }
    }
}

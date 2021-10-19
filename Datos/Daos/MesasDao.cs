using AppBTS.Datos.Interfaces;
using AppBTS.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Datos.Daos
{
    class MesasDao : IMesas
    {
        public DataTable RecuperarTodos()
        {
            string consulta = "SELECT * FROM Mesas WHERE borrado = 0 order by nroMesa";

            //BDHelper oDatos = new BDHelper();
            return BDHelper.obtenerInstancia().consultar(consulta);
        }

        public DataTable RecuperarBorrados()
        {
            string consulta = "SELECT * FROM Mesas WHERE borrado = 1 order by nroMesa";

            //BDHelper oDatos = new BDHelper();
            return BDHelper.obtenerInstancia().consultar(consulta);
        }

        public void AgregarMesa(Mesas mesa)
        {
            if (VerificarExistencia(mesa.NroMesa.ToString()).Rows.Count == 0)
            {
                string alta = "INSERT INTO Mesas"
                                + " VALUES"
                                + " (" + mesa.NroMesa.ToString() + ", @cantidadSillas, @borrado)";
                //BDHelper oAlta = new BDHelper();
                BDHelper.obtenerInstancia().insertarMesa(mesa, alta);
            }
            else
            {
                LevantarMesa(mesa.NroMesa.ToString());
            }
        }

        public DataTable VerificarExistencia(string nroMesa)
        {
            string verificacion = "SELECT 1 FROM Mesas WHERE nroMesa = " + nroMesa;
            //BDHelper oVerificacion = new BDHelper();
            return BDHelper.obtenerInstancia().consultar(verificacion);
        }
        public void LevantarMesa(string nroMesa)
        {
            string consulta = " UPDATE Mesas"
                            + " SET borrado = 0"
                            + " WHERE nroMesa = " + nroMesa;

            //BDHelper oDatos = new BDHelper();
            BDHelper.obtenerInstancia().consultar(consulta);
        }
        public void Borrar(string mesaClickeada)
        {
            string consulta = " UPDATE Mesas"
                            + " SET borrado = 1"
                            + " WHERE nroMesa = " + mesaClickeada;

            // BDHelper oDatos = new BDHelper();
            BDHelper.obtenerInstancia().consultar(consulta);
        }

        public int IdSiguiente()
        {
            string consulta = "SELECT MAX(nroMesa) FROM Mesas WHERE borrado = 0";
            //BDHelper oDatos = new BDHelper();
            DataTable idmax = BDHelper.obtenerInstancia().consultar(consulta);
            int id = 0;
            if (idmax.Rows[0][0].ToString() != "")
            {
                id = Convert.ToInt32(idmax.Rows[0][0].ToString());
            }
            return id + 1;
        }
    }
}

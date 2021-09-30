using AppBTS.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBTS.Negocio
{
    class Reservas
    {
        private int nroReserva;
        private int nroMesa;
        private DateTime fechaReserva;
        private TimeSpan horaReserva;
        private string  nombreCliente;
        private string telefono;
        private int cantidadComensales;
        private bool borrado;

        public int NroReserva { get => nroReserva; set => nroReserva = value; }
        public int NroMesa { get => nroMesa; set => nroMesa = value; }
        public DateTime FechaReserva { get => fechaReserva; set => fechaReserva = value; }
        public TimeSpan HoraReserva { get => horaReserva; set => horaReserva = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public int CantidadComensales { get => cantidadComensales; set => cantidadComensales = value; }
        public bool Borrado { get => borrado; set => borrado = value; }

        public DataTable RecuperarTodos()
        {
            string consulta = "SELECT r.nroReserva,m.nroMesa,r.fechaReserva,r.horaReserva,r.nombreCliente,r.telefono,r.cantidadComensales"
                            + " FROM Reservas r, Mesas m"
                            + " WHERE r.nroReserva=r.nroReserva" +
                            " AND r.nroMesa= m.nroMesa" +
                            " AND r.fechaReserva= r.fechaReserva" +
                            " AND r.horaReserva=r.horaReserva" +
                            " AND r.nombreCliente=r.nombreCliente" +
                            " AND r.telefono=r.telefono" +
                            " AND r.cantidadComensales=r.cantidadComensales"
                            + " AND r.borrado=0"
                            + " ORDER BY r.fechaReserva DESC";
            BDHelper oDatos = new BDHelper();
            return oDatos.consultar(consulta);
        }
        public DataTable RecuperarFiltrados(string desde, string hasta, string nroReserva, string nroMesa, string telefono, string comensales, string nombreCliente, string horaReserva)
        {
            string consulta = "SELECT r.nroReserva,m.nroMesa,r.fechaReserva,r.horaReserva,r.nombreCliente,r.telefono,r.cantidadComensales"
                                        + " FROM Reservas r, Mesas m"
                                        + " WHERE r.nroReserva=r.nroReserva"
                                        + " AND r.nroMesa=m.nroMesa"
                                        + " AND r.borrado=0";
            consulta += " AND r.fechaReserva BETWEEN '" + desde + "' AND '" + hasta + "'";

            if (nroReserva != "")
                consulta += " AND r.nroReserva=" + nroReserva;
            if (nroMesa != "")
                consulta += " AND r.nroMesa=" + nroMesa;
            if (nombreCliente != string.Empty)
                consulta += " AND r.nombreCliente= '" + nombreCliente + "'";
            if (telefono != "")
                consulta += " AND r.telefono=" + telefono;
            if (comensales != "")
                consulta += " AND r.cantidadComensales=" + comensales;
            if (horaReserva != "")
                consulta += " AND r.horaReserva='" + horaReserva + "'";

            consulta += " ORDER BY r.fechaReserva DESC";
            BDHelper oDatos = new BDHelper();
            return oDatos.consultar(consulta);
        }

        public DataTable RecuperarTodosConParametro( string filtro)
        {
            string consulta = "SELECT r." + filtro +" FROM Reservas r WHERE borrado = 0 order by " + filtro;

            BDHelper oDatos = new BDHelper();
            return oDatos.consultar(consulta);
        }

        public void Borrar(string nroReserva)
        {
            string consulta = " UPDATE Reservas"
                            + " SET borrado = 1"
                            + " WHERE nroReserva = " + nroReserva;

            BDHelper oDatos = new BDHelper();
            oDatos.consultar(consulta);
  

        }
        public void Modificar(int numReserva, int numMesa, string dateReserva, string hourReserva, string cliente, string tel, int cantComensales)
        {
            string modificacion = "UPDATE Reservas SET nroMesa = " + numMesa.ToString() + ", fechaReserva = '" + dateReserva + "', horaReserva = '" + hourReserva + "', nombreCliente = '" + cliente + "', telefono = " + tel + ", cantidadComensales = " + cantComensales.ToString() + " WHERE nroReserva = " + numReserva.ToString();
            BDHelper oModificacion = new BDHelper();
            oModificacion.actualizarArticulo(modificacion);
        }

        public void AgregarReserva(string nroReserva)
        {
            if (VerificarExistencia(nroReserva).Rows.Count == 0)
            {
                string alta = "INSERT INTO Reservas"
                                + " VALUES"
                                + " (" + Convert.ToInt32(nroReserva) + ", @nroMesa, @fechaReserva, @horaReserva, @nombreCliente, @telefono, @cantidadComensales, @borrado)";
                BDHelper oAlta = new BDHelper();
                oAlta.insertarReserva(this, alta);
            }
            else
            {
                if (MessageBox.Show("Actualmente existe una reserva borrada con dicho número de Reserva, desea crearla nuevamente?", "Reserva existente", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                        LevantarReserva(nroReserva);
            }
        }

        public DataTable VerificarExistencia(string nroReserva)
        {
            string verificacion = "SELECT 1 FROM Reservas WHERE nroReserva = " + nroReserva;
            BDHelper oVerificacion = new BDHelper();
            return oVerificacion.consultar(verificacion);
        }
        public void LevantarReserva(string nroReserva)
        {
            string consulta = " UPDATE Reservas"
                            + " SET borrado = 0"
                            + " WHERE nroReserva = " + nroReserva;

            BDHelper oDatos = new BDHelper();
            oDatos.consultar(consulta);
        }
        public int IdSiguiente()
        {
            string consulta = "SELECT MAX(nroReserva) FROM Reservas WHERE borrado = 0";
            BDHelper oDatos = new BDHelper();
            DataTable idmax = oDatos.consultar(consulta);
            int id = Convert.ToInt32(idmax.Rows[0][0].ToString());
            return id + 1;
        }
    }   
    
}


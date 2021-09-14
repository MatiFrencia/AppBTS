using AppBTS.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Negocio
{
    class Reservas
    {
        private int nroReserva;
        private int nroMesa;
        private DateTime fechaReserva;
        private TimeSpan horaReserva;
        private string  nombreCliente;
        private int telefono;
        private int cantidadComensales;
        private bool borrado;

        public int NroReserva { get => nroReserva; set => nroReserva = value; }
        public int NroMesa { get => nroMesa; set => nroMesa = value; }
        public DateTime FechaReserva { get => fechaReserva; set => fechaReserva = value; }
        public TimeSpan HoraReserva { get => horaReserva; set => horaReserva = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public int Telefono { get => telefono; set => telefono = value; }
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
    }
}


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
        private string nombreCliente;
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
    }   
}


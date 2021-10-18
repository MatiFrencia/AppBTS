using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppBTS.Datos.Daos;
using AppBTS.Datos.Interfaces;
using AppBTS.Negocio;

namespace AppBTS.Servicios
{
    class ReservaService
    {
        private IReserva dao;
        public ReservaService()
        {
            dao = new ReservaDao();
        }
        public DataTable RecuperarTodos()
        {
            return dao.RecuperarTodos();
        }
        public DataTable RecuperarFiltrados(string desde, string hasta, string nroReserva, string nroMesa, string telefono, string comensales, string nombreCliente, string horaReserva)
        {
            return dao.RecuperarFiltrados(desde, hasta, nroReserva, nroMesa, telefono, comensales, nombreCliente, horaReserva);
        }
        public DataTable RecuperarTodosConParametro(string filtro)
        {
            return dao.RecuperarTodosConParametro(filtro);
        }
        public void Borrar(string nroReserva)
        {
            dao.Borrar(nroReserva);
        }
        public void Modificar(int numReserva, int numMesa, string dateReserva, string hourReserva, string cliente, string tel, int cantComensales)
        {
            dao.Modificar(numReserva, numMesa, dateReserva, hourReserva, cliente, tel, cantComensales);
        }
        public void AgregarReserva(Reservas reserva)
        {
            dao.AgregarReserva(reserva);
        }
        public DataTable VerificarExistencia(string nroReserva)
        {
            return dao.VerificarExistencia(nroReserva);
        }
        public void LevantarReserva(string nroReserva)
        {
            dao.LevantarReserva(nroReserva);
        }
        public int IdSiguiente()
        {
            return dao.IdSiguiente();
        }
    }
}

using AppBTS.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Datos.Interfaces
{
    interface IReserva
    {
        DataTable RecuperarTodos();
        DataTable RecuperarFiltrados(string desde, string hasta, string nroReserva, string nroMesa, string telefono, string comensales, string nombreCliente, string horaReserva);
        DataTable RecuperarTodosConParametro(string filtro);
        void Borrar(string nroReserva);
        void Modificar(int numReserva, int numMesa, string dateReserva, string hourReserva, string cliente, string tel, int cantComensales);      
        void AgregarReserva(Reservas reserva);
        DataTable VerificarExistencia(string nroReserva);   
        void LevantarReserva(string nroReserva);
        int IdSiguiente();
    }
}

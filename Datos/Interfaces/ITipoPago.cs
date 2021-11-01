using AppBTS.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Datos.Interfaces
{
    interface ITipoPago
    {
        DataTable RecuperarTodos();
        void Registrar(TipoPago tipoPago);
        void Modificar(string nombre, string descripcion, TipoPago Tpago);
    }
}

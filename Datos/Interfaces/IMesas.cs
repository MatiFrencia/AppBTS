using AppBTS.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Datos.Interfaces
{
    interface IMesas
    {
        DataTable RecuperarTodos();
        DataTable RecuperarBorrados();
        void AgregarMesa(Mesas mesa);
        DataTable VerificarExistencia(string nroMesa);
        void LevantarMesa(string nroMesa);
        void Borrar(string mesaClickeada);
        int IdSiguiente();
    }
}

using AppBTS.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Datos.Interfaces
{
    interface IMenu
    {
        void Registrar(Menus menu);
        int IdSiguiente();
        DataTable RecuperarTodos();
        DataTable RecuperarFiltrados(string idMenu, string nombre, string idTipoArticulo, string idArticulo);
        void Eliminar(Menus menu);
        void Modificar(int idMenu, string nombre, int pcioUnitario);
    }
}

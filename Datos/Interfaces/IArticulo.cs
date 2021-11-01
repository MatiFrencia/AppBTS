using AppBTS.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Datos.Interfaces
{
    interface IArticulo
    {
        void Registrar(Articulo art);
        int IdSiguiente();
        double RecuperarPrecio(string idArticulo);
        DataTable RecuperarFiltrados(string idArticulo, string nombre, string idTipoArticulo);
        void Modificar(bool mNombre, bool mPrecio, bool mTipo, Articulo art);
        DataTable RecuperarTodos();
        void Eliminar(int idArticulo);
    }
}

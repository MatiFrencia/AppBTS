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
    class ArticuloService
    {
        private IArticulo dao;
        public ArticuloService()
        {
            dao = new ArticuloDao();
        }

        public void Registrar(Articulo art)
        {
            dao.Registrar(art);
        }
        public int IdSiguiente()
        {
            return dao.IdSiguiente();
        }
        public double RecuperarPrecio(string idArticulo)
        {
            return dao.RecuperarPrecio(idArticulo);
        }
        public DataTable RecuperarFiltrados(string idArticulo, string nombre, string idTipoArticulo)
        {
            return dao.RecuperarFiltrados(idArticulo, nombre, idTipoArticulo);
        }
        public void Modificar(bool mNombre, bool mPrecio, bool mTipo, Articulo art)
        {
            dao.Modificar(mNombre, mPrecio, mTipo, art);
        }
        public DataTable RecuperarTodos()
        {
            return dao.RecuperarTodos();
        }
        public void Eliminar(int idArticulo)
        {
            dao.Eliminar(idArticulo);
        }
    }
}

using AppBTS.Datos.Daos;
using AppBTS.Datos.Interfaces;
using AppBTS.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Servicios
{
    class MenuService
    {
        private IMenu dao;
        public MenuService()
        {
            dao = new MenuDao();
        }
        public void Registrar(Menus menu)
        {
            dao.Registrar(menu);
        }
        public int IdSiguiente()
        {
            return dao.IdSiguiente();
        }
        public DataTable RecuperarTodos()
        {
            return dao.RecuperarTodos();
        }
        public DataTable RecuperarFiltrados(string idMenu, string nombre, string idTipoArticulo, string idArticulo)
        {
            return dao.RecuperarFiltrados(idMenu, nombre, idTipoArticulo, idArticulo);
        }
        public void Eliminar(Menus menu)
        {
            dao.Eliminar(menu);
        }
        public void Modificar(int idMenu, string nombre, int pcioUnitario)
        {
            dao.Modificar(idMenu, nombre, pcioUnitario);
        }
    }
}

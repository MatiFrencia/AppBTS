using AppBTS.Datos.Daos;
using AppBTS.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Servicios
{
    class UsuarioService
    {
        private IUsuario dao;
        public UsuarioService()
        {
            dao = new UsuarioDao();
        }
        public int validarUsuario(string nombre, string clave)
        {
            return dao.validarUsuario(nombre, clave);
        }
        public DataTable RecuperarTodos()
        {
            return dao.RecuperarTodos();
        }
    }
}

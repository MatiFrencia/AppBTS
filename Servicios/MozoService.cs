using AppBTS.Datos;
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
    class MozoService
    {
        private IMozo dao;
        public MozoService()
        {
            dao = new MozoDao();
        }
        public DataTable traerTodos()
        {
            return dao.traerTodos();
        }

        public DataTable traerSegunId(int id)
        {
            return dao.traerSegunId(id);
        }
        public void Eliminar(int id)
        {
            dao.Eliminar(id);
        }
        public void Modificar(int id, string nombre, string apellido)
        {
            dao.Modificar(id, nombre, apellido);
        }
        public void Insertar(int id, string nombre, string apellido)
        {
            dao.Insertar(id, nombre, apellido);
        }
        public int IdSiguiente()
        {
            return dao.IdSiguiente();
        }
    }
}

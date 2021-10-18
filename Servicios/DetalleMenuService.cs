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
    class DetalleMenuService
    {
        private IDetalleMenu dao;
        public DetalleMenuService()
        {
            dao = new DetalleMenuDao();
        }
        public void Registrar(DetalleMenu dMenu)
        {
            dao.Registrar(dMenu);
        }
        public DataTable RecuperarPorMenu(string idMenu)
        {
            return dao.RecuperarPorMenu(idMenu);
        }
    }
}

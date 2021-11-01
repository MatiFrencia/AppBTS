using AppBTS.Datos.Daos;
using AppBTS.Datos.Interfaces;
using AppBTS.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Servicios
{
    class TipoPagoService
    {
        private ITipoPago dao;
        public TipoPagoService()
        {
            dao = new TipoPagoDao();
        }
        public void Registrar(TipoPago Tpago)
        {
            dao.Registrar(Tpago);
        }
        public void Modificar(string nombre, string descripcion, TipoPago Tpago)
        {
            dao.Modificar(nombre, descripcion, Tpago);
        }
        public DataTable RecuperarTodos()
        {
            return dao.RecuperarTodos();
        }
    }
}

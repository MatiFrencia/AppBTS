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
    class MesasService
    {
        private IMesas dao;
        public MesasService()
        {
            dao = new MesasDao();
        }
        public DataTable RecuperarTodos()
        {
            return dao.RecuperarTodos();
        }
        public DataTable RecuperarBorrados()
        {
            return dao.RecuperarBorrados();
        }
        public void AgregarMesa(Mesas mesa)
        {
            dao.AgregarMesa(mesa);
        }
        public DataTable VerificarExistencia(string nroMesa)
        {
            return dao.VerificarExistencia(nroMesa);
        }
        public void LevantarMesa(string nroMesa)
        {
            dao.LevantarMesa(nroMesa);
        }
        public void Borrar(string mesaClickeada)
        {
            dao.Borrar(mesaClickeada);
        }
        public int IdSiguiente()
        {
            return dao.IdSiguiente();
        }
    }
}

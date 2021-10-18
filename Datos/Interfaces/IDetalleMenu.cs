using AppBTS.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Datos.Interfaces
{
    interface IDetalleMenu
    {
        void Registrar(DetalleMenu dMenu);
        DataTable RecuperarPorMenu(string idMenu);
    }
}

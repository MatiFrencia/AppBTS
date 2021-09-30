using System;
using System.Collections.Generic;
using System.Linq;
using AppBTS.Datos;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Negocio
{
    class DetalleMenu
    {
        public int IdMenu { get; set; }
        public int IdArticulo { get; set; }
        public int Cantidad { get; set; }
        public bool Borrado { get; set; }

        public void Registrar()
        {
            string alta = "INSERT INTO DetallesMenu VALUES(@idMenu,@idArticulo,@cantidad,@borrado)";
            BDHelper oAlta = new BDHelper();
            oAlta.insertarDetalleMenu(this, alta);
        }
    }
}

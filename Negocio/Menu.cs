using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AppBTS.Datos;
using System.Data;
using System.Threading.Tasks;

namespace AppBTS.Negocio
{
    class Menus
    {
        public int IdMenu { get; set; }
        public string Nombre { get; set; }
        public double PrecioUnitario { get; set; }
        public bool Borrado { get; set; }
        public DetalleMenu[] DetallesMenu { get; set; }

        public void Registrar()
        {
            string alta = "INSERT INTO Menus VALUES(@idMenu,@nombre,@pcioUnitario,@borrado)";
            BDHelper oAlta = new BDHelper();
            oAlta.insertarMenu(this, alta);
            foreach (DetalleMenu detalle in DetallesMenu)
            {
                detalle.Registrar();
            }
        }
        public int IdSiguiente()
        {
            string consulta = "SELECT MAX(idMenu) AS MaxId FROM Menus";
            BDHelper oDatos = new BDHelper();
            int maxId = oDatos.consultaSumaria(consulta);
            return maxId + 1;
        }
    }
}

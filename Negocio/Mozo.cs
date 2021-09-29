using AppBTS.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AppBTS.Negocio
{
    class Mozo
    {
        public int idMozo { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public bool Borrado { get; set; }
        public DataTable traerTodos() {
            string consulta = "SELECT m.idMozo,m.nombre,m.apellido FROM Mozos m WHERE m.borrado=0";
            BDHelper oDatos = new BDHelper();
            DataTable tabla = oDatos.consultar(consulta);
            return tabla;
        }

        public DataTable traerSegunId(int id)
        {
            string consulta = "SELECT m.idMozo,m.nombre,m.apellido FROM Mozos m WHERE m.idMozo=" + id + " AND m.borrado=0";
            BDHelper oDatos = new BDHelper();
            DataTable tabla = oDatos.consultar(consulta);
            return tabla;
        }
        public void Eliminar()
        {
            string baja = "UPDATE Mozos SET borrado = 1 WHERE idMozo=" + idMozo.ToString();
            BDHelper oBaja = new BDHelper();
            oBaja.actualizarArticulo(baja);
        }
    }
}

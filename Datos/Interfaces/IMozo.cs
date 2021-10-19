using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Datos.Interfaces
{
    interface IMozo
    {
        DataTable traerTodos();
        DataTable traerSegunId(int id);
        void Eliminar(int id);
        void Modificar(int id, string nombre, string apellido);
        void Insertar(int id, string nombre, string apellido);
        int IdSiguiente();
    }
}

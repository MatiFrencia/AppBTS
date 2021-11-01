using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Datos.Interfaces
{
    interface ITipoArticulo
    {
        DataTable RecuperarTodos();
        int RecuperarPorNombre(string nombre);
        string RecuperarPorId(int id);
    }
}

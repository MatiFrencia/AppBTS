using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBTS
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmPrincipal());
            //Application.Run(new AppBTS.Presentacion.frmConsultaReservas());
            //Application.Run(new AppBTS.Presentacion.frmConsultarArticulo());
            //Application.Run(new AppBTS.Presentacion.frmReporteHoras());
            //Application.Run(new AppBTS.Presentacion.frmMesas());
            //Application.Run(new AppBTS.Presentacion.frmConsultarArticulo());
            //Application.Run(new AppBTS.Presentacion.frmMozos());
            //Application.Run(new AppBTS.Presentacion.frmAltaMenu());
        }
    }
}

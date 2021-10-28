using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppBTS.Negocio;
using AppBTS.Servicios;

namespace AppBTS.Presentacion
{
    public partial class frmRecuperarMesas : Form
    {
        MesasService miGestorMesas = new MesasService();
        public frmRecuperarMesas()
        {
            InitializeComponent();
        }

        Mesas oMesas = new Mesas();
        public class Global
        {
            private static string idMesa;
            public static string IdMesa { get => idMesa; set => idMesa = value; }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            miGestorMesas.LevantarMesa(oMesas.NroMesa.ToString());
            this.CargarGrilla(dgvMesasBorradas, miGestorMesas.RecuperarBorrados());
        }

        private void CargarGrilla(DataGridView grilla, DataTable tabla)
        {
            grilla.Rows.Clear();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["nroMesa"],
                                tabla.Rows[i]["cantidadSillas"],
                                tabla.Rows[i]["borrado"]);
            }

        }

        private void frmRecuperarMesas_Load(object sender, EventArgs e)
        {
            this.CargarGrilla(dgvMesasBorradas, miGestorMesas.RecuperarBorrados());
        }

        private void dgvMesasBorradas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        oMesas.NroMesa = Convert.ToInt32(dgvMesasBorradas.Rows[e.RowIndex].Cells[0].Value);

        }
    }
}

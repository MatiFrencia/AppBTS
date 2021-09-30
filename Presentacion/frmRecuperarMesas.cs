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

namespace AppBTS.Presentacion
{
    public partial class frmRecuperarMesas : Form
    {
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
            oMesas.LevantarMesa(Global.IdMesa);
            this.CargarGrilla(dgvMesasBorradas, oMesas.RecuperarBorrados());
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
            this.CargarGrilla(dgvMesasBorradas, oMesas.RecuperarBorrados());
        }

        private void dgvMesasBorradas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        Global.IdMesa = dgvMesasBorradas.Rows[e.RowIndex].Cells[0].Value.ToString();

        }
    }
}

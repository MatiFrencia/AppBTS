using AppBTS.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBTS
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            this.Opacity = 0;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            frmLogin fl;
            fl = new frmLogin();
            fl.ShowDialog();

            if (fl.MiUsuario.Id_usuario == 0) {
                this.Dispose();
            }
            else { 
                this.Text += " - Usuario: " + fl.MiUsuario.Nombre;
                fl.Dispose();
                this.Opacity = 100;
            }
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaReservas fcb = new frmConsultaReservas();
            fcb.ShowDialog();
            fcb.Dispose();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Está seguro que desea Salir?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void mesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMesas fcb = new frmMesas();
            fcb.ShowDialog();
            fcb.Dispose();
        }

        private void registrarReservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaReserva far = new frmAltaReserva();
            far.ShowDialog();
            far.Dispose();
        }

        private void articuloToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRegistrarArticulo fra = new frmRegistrarArticulo();
            fra.ShowDialog();
            fra.Dispose();
        }

        private void artículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarArticulo fca = new frmConsultarArticulo();
            fca.ShowDialog();
            fca.Dispose();
        }
    }
}

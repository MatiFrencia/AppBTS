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
        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Está seguro que desea Salir?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void btnMesas_Click(object sender, EventArgs e)
        {
            frmMesas fcb = new frmMesas();
            fcb.ShowDialog();
            fcb.Dispose();
        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {
            frmConsultarArticulo fra = new frmConsultarArticulo();
            fra.ShowDialog();
            fra.Dispose();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmConsultarMenus fcm = new frmConsultarMenus();
            fcm.ShowDialog();
            fcm.Dispose();
        }

        private void btnMozos_Click(object sender, EventArgs e)
        {
            frmMozos fm = new frmMozos();
            fm.ShowDialog();
            fm.Dispose();
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            frmConsultaReservas fcb = new frmConsultaReservas();
            fcb.ShowDialog();
            fcb.Dispose();
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            frmAgregarDetalles fat = new frmAgregarDetalles();
            fat.ShowDialog();
            fat.Dispose();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reportes");
            //frmReporteTickets frt = new frmReporteTickets();
            //frt.ShowDialog();
            //frt.Dispose();
            //frmReporteMenus frm = new frmReporteMenus();
            //frm.ShowDialog();
            //frm.Dispose();
            //frmReporteHoras frh = new frmReporteHoras();
            //frh.ShowDialog();
            //frh.Dispose();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
 }


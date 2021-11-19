using AppBTS.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBTS.Presentacion
{
    public partial class frmReporteMenus : Form
    {
        public frmReporteMenus()
        {
            InitializeComponent();
        }
        MenuService miGestorMenus = new MenuService();
        DetallesTicketService miGestorDtickets = new DetallesTicketService();
        private void frmReporteMenus_Load(object sender, EventArgs e)
        {
            visualizar(true);
            CargarCombo(cboMenu, miGestorMenus.RecuperarTodos(), 1);
            //no debe cargarlo al iniciar el frm para optimizar el tiempo de carga del mismo
            //this.reportViewer1.RefreshReport();
        }
        private void btnAño_Click(object sender, EventArgs e)
        {
            visualizar(false);
            this.dtpFechaDesde.Value = DateTime.Today.AddYears(-1);
            this.dtpFechaHasta.Value = DateTime.Today;
        }

        private void btnMes_Click(object sender, EventArgs e)
        {
            visualizar(false);
            this.dtpFechaDesde.Value = DateTime.Today.AddMonths(-1);
            this.dtpFechaHasta.Value = DateTime.Today;
        }

        private void btnSemana_Click(object sender, EventArgs e)
        {
            visualizar(false);
            this.dtpFechaDesde.Value = DateTime.Today.AddDays(-7);
            this.dtpFechaHasta.Value = DateTime.Today;
        }

        private void btnDia_Click(object sender, EventArgs e)
        {
            visualizar(false);
            this.dtpFechaDesde.Value = DateTime.Today.AddDays(-1);
            this.dtpFechaHasta.Value = DateTime.Today;
        }

        private void btnPerso_Click(object sender, EventArgs e)
        {
            visualizar(true);
        }

        private void CargarCombo(ComboBox combo, DataTable tabla, int i)
        {
            combo.DataSource = tabla;
            combo.DisplayMember = tabla.Columns[i].ColumnName;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void limpiar()
        {
            this.dtpFechaHasta.Value = DateTime.Today;
            this.cboMenu.SelectedIndex = -1;
        }
        private void visualizar(bool x)
        {
            this.dtpFechaDesde.Enabled = x;
            this.dtpFechaHasta.Enabled = x;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string _nroMenu;
            _nroMenu = string.Empty;
            if (dtpFechaDesde.Value > dtpFechaHasta.Value)
            {
                MessageBox.Show("Fechas erroneas!!!");
                dtpFechaDesde.Focus();
                return;
            }
            if (cboMenu.SelectedIndex != -1)
                _nroMenu = cboMenu.SelectedValue.ToString();
            this.dsDetallesTicketBindingSource.DataSource = miGestorDtickets.RecuperarTodosConParametros(_nroMenu,
                                                    dtpFechaDesde.Value.ToString("yyyy/MM/dd"), dtpFechaHasta.Value.ToString("yyyy/MM/dd"));
            this.reportViewer1.RefreshReport();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

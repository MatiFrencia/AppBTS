using AppBTS.Entidades;
using AppBTS.Negocio;
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
    public partial class frmReporteTickets : Form
    {
        public frmReporteTickets()
        {
            InitializeComponent();
        }

        private void frmReporteTickets_Load(object sender, EventArgs e)
        {
            limpiar();
            this.dtpFechaDesde.Value = DateTime.Today.AddYears(-1);
            this.dtpFechaHasta.Value = DateTime.Today;
            this.dtpHoraDesde.Format = DateTimePickerFormat.Custom;
            this.dtpHoraDesde.CustomFormat = "HH':'mm";
            this.dtpHoraDesde.ShowUpDown = true;
            this.dtpHoraHasta.Format = DateTimePickerFormat.Custom;
            this.dtpHoraHasta.CustomFormat = "HH':'mm";
            this.dtpHoraHasta.ShowUpDown = true;

            this.CargarCombo(cboNroTicket, miGestorTickets.RecuperarTodos(),0);
            this.CargarCombo(cboNroMesa, miGestorMesas.RecuperarTodos(),0);
            this.CargarCombo(cboMozo, miGestorMozos.traerTodos(),1);
            this.CargarCombo(cboTipoPago, miGestorTpago.RecuperarTodos(),1);

            this.btnConsultar.Enabled = true;
            this.btnSalir.Enabled = true;
            this.dtTicketsBindingSource.DataSource = miGestorTickets.RecuperarTodos();
            this.reportViewer1.RefreshReport();
        }
        TicketService miGestorTickets = new TicketService();
        MesasService miGestorMesas = new MesasService();
        MozoService miGestorMozos = new MozoService();
        TipoPagoService miGestorTpago = new TipoPagoService();
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
            this.cboNroTicket.SelectedIndex = -1;
            this.cboNroMesa.SelectedIndex = -1;
            this.cboTipoPago.SelectedIndex = -1;
            this.cboMozo.SelectedIndex = -1;
            this.txtDesde.Text = "0";
            this.txtHasta.Text = "0";
        }
        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnConsultar_Click_1(object sender, EventArgs e)
        {
            

            string _nroTicket, _nroMesa, _idMozo, _idTipoPago;
            _nroTicket = _nroMesa = _idMozo = _idTipoPago = string.Empty;
            if (dtpFechaDesde.Value > dtpFechaHasta.Value)
            {
                MessageBox.Show("Fechas erroneas!!!");
                dtpFechaDesde.Focus();
                return;
            }
            if (cboNroTicket.SelectedIndex != -1)
                _nroTicket = cboNroTicket.SelectedValue.ToString();
            if (cboMozo.SelectedIndex != -1)
                _idMozo = cboMozo.SelectedValue.ToString();
            if (cboTipoPago.SelectedIndex != -1)
                _idTipoPago = cboTipoPago.SelectedValue.ToString();
            if (cboNroMesa.SelectedIndex != -1)
                _nroMesa = cboNroMesa.SelectedValue.ToString();
            if (dtpHoraDesde.Value > dtpHoraHasta.Value)
            {
                MessageBox.Show("Horas erroneas!!!");
                dtpHoraDesde.Focus();
                return;
            }
            if (Convert.ToInt32(txtDesde.Text) > Convert.ToInt32(txtHasta.Text))
            {
                MessageBox.Show("Valores $ erroneos!!!");
                txtDesde.Focus();
                return;
            }

            if (Convert.ToInt32(txtHasta.Text) == 0)
            {
                MessageBox.Show("Valores $ erroneos!!!");
                txtDesde.Focus();
                return;
            }
            this.dtTicketsBindingSource.DataSource = miGestorTickets.RecuperarTodosConParametros(_nroTicket,
                                                    dtpFechaDesde.Value.ToString("yyyy/MM/dd"), dtpFechaHasta.Value.ToString("yyyy/MM/dd"),
                                                    dtpHoraDesde.Value.ToString("HH:mm"),dtpHoraHasta.Value.ToString("HH:mm"),
                                                    _idMozo, _nroMesa, _idTipoPago,
                                                    txtDesde.Text.ToString(),txtHasta.Text.ToString());
            this.reportViewer1.RefreshReport();
            limpiar();
        }

        private void btnAño_Click(object sender, EventArgs e)
        {
            this.dtpFechaDesde.Enabled = false;
            this.dtpFechaHasta.Enabled = false;
            this.dtpFechaDesde.Value = DateTime.Today.AddYears(-1);
            this.dtpFechaHasta.Value = DateTime.Today;
        }

        private void btnMes_Click(object sender, EventArgs e)
        {
            this.dtpFechaDesde.Enabled = false;
            this.dtpFechaHasta.Enabled = false;
            this.dtpFechaDesde.Value = DateTime.Today.AddMonths(-1);
            this.dtpFechaHasta.Value = DateTime.Today;
        }

        private void btnSemana_Click(object sender, EventArgs e)
        {
            this.dtpFechaDesde.Enabled = false;
            this.dtpFechaHasta.Enabled = false;
            this.dtpFechaDesde.Value = DateTime.Today.AddDays(-7);
            this.dtpFechaHasta.Value = DateTime.Today;
        }

        private void btnDia_Click(object sender, EventArgs e)
        {
            this.dtpFechaDesde.Enabled = false;
            this.dtpFechaHasta.Enabled = false;
            this.dtpFechaDesde.Value = DateTime.Today.AddDays(-1);
            this.dtpFechaHasta.Value = DateTime.Today;
        }

        private void btnPerso_Click(object sender, EventArgs e)
        {
            this.dtpFechaDesde.Enabled = true;
            this.dtpFechaHasta.Enabled = true;
        }
    }
}
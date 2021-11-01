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
            this.dtTicketBindingSource.DataSource = miGestorTickets.RecuperarTodos();
            this.reportViewer1.RefreshReport();
        }
        Ticket oTicket = new Ticket();
        Mesas oMesas = new Mesas();
        Usuario oUsuario = new Usuario();
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
            this.nmrDesde.Value = 0;
            this.nmrHasta.Value = 0;
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
            this.reportViewer1.RefreshReport();

            //string _nroTicket, _nroMesa, _idMozo, _cantidadComensales, _nombreCliente, _horaReserva;
            //_nroReserva = _nroMesa = _cantidadComensales = _telefono = _nombreCliente = _horaReserva = string.Empty;
            //if (dtpFechaDesde.Value > dtpFechaHasta.Value)
            //{
            //    MessageBox.Show("Fechas erroneas!!!");
            //    dtpFechaDesde.Focus();
            //    return;
            //}
            //if (cboNroReserva.SelectedIndex != -1)
            //    _nroReserva = cboNroReserva.SelectedValue.ToString();
            //if (cboTelefono.SelectedIndex != -1)
            //    _telefono = cboTelefono.SelectedValue.ToString();
            //if (cboComensales.SelectedIndex != -1)
            //    _cantidadComensales = cboComensales.SelectedValue.ToString();
            //if (cboNroMesa.SelectedIndex != -1)
            //    _nroMesa = cboNroMesa.SelectedValue.ToString();
            //if (cboNombreCliente.SelectedIndex != -1)
            //    _nombreCliente = cboNombreCliente.SelectedValue.ToString();
            //if (dtpHoraDesde.Value > dtpHoraHasta.Value)
            //{
            //    MessageBox.Show("Horas erroneas!!!");
            //    dtpHoraDesde.Focus();
            //    return;
            //}
            //this.dtTicketBindingSource.DataSource = miGestorTickets.RecuperarTodosConParametros(cboNroTicket.SelectedValue.ToString(), );
            limpiar();
        }
    }
}
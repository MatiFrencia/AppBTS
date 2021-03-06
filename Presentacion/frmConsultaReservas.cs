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
    public partial class frmConsultaReservas : Form
    {
        Reservas oReservas = new Reservas();
        Mesas oMesas = new Mesas();
        Usuario oUsuario = new Usuario();
        private ReservaService miGestorReservas = new ReservaService();
        MesasService miGestorMesas = new MesasService();


        public frmConsultaReservas()
        {
            InitializeComponent();
        }

        public class Global
        {
            private static string idReserva;
            public static string IdReserva { get => idReserva; set => idReserva = value; }
        }


        private void frmConsultaReservas_Load(object sender, EventArgs e)
        {

            limpiar();
            // TODO: esta línea de código carga datos en la tabla 'masterDataSet.Bugs' Puede moverla o quitarla según sea necesario.
            this.dtpFechaDesde.Value = DateTime.Today.AddYears(-1);
            this.dtpFechaHasta.Value = DateTime.Today;
            this.dtpHoraDesde.Format = DateTimePickerFormat.Custom;
            this.dtpHoraDesde.CustomFormat = "HH':'mm";
            this.dtpHoraDesde.ShowUpDown = true;
            this.dtpHoraDesde.Value = Convert.ToDateTime("00:00");
            this.dtpHoraHasta.Format = DateTimePickerFormat.Custom;
            this.dtpHoraHasta.CustomFormat = "HH':'mm";
            this.dtpHoraHasta.ShowUpDown = true;

            this.CargarCombo(cboNroReserva, miGestorReservas.RecuperarTodosConParametro("nroReserva"));
            this.CargarCombo(cboNroMesa, miGestorMesas.RecuperarTodos());
            this.CargarCombo(cboNombreCliente, miGestorReservas.RecuperarTodosConParametro("nombreCliente"));
            this.CargarCombo(cboTelefono, miGestorReservas.RecuperarTodosConParametro("telefono"));
            this.CargarCombo(cboComensales, miGestorReservas.RecuperarTodosConParametro("cantidadComensales"));

            botones(false);
            this.btnConsultar.Enabled = true;
            this.btnNuevo.Enabled = true;
            this.btnAsignar.Enabled = false;
            this.btnSalir.Enabled = true;
            //deshabilitado para no retardar la carga de formulario (profe)
            //this.CargarGrilla(dgvReservas, oReservas.RecuperarTodos());
        }

        private void CargarGrilla(DataGridView grilla, DataTable tabla)
        {
            grilla.Rows.Clear();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["nroReserva"],
                                tabla.Rows[i]["nroMesa"],
                                tabla.Rows[i]["fechaReserva"],
                                tabla.Rows[i]["horaReserva"],
                                tabla.Rows[i]["nombreCliente"],
                                tabla.Rows[i]["telefono"],
                                tabla.Rows[i]["cantidadComensales"]);
            }

        }

        private void CargarCombo(ComboBox combo, DataTable tabla)
        {
            combo.DataSource = tabla;
            combo.DisplayMember = tabla.Columns[0].ColumnName;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            consultar();
        }

        private void consultar()
        {
            botones(false);
            string _nroReserva, _nroMesa, _telefono, _cantidadComensales, _nombreCliente, _horaReserva;
            _nroReserva = _nroMesa = _cantidadComensales = _telefono = _nombreCliente = _horaReserva = string.Empty;
            if (dtpFechaDesde.Value > dtpFechaHasta.Value)
            {
                MessageBox.Show("Fechas erroneas!!!");
                dtpFechaDesde.Focus();
                return;
            }
            if (cboNroReserva.SelectedIndex != -1)
                _nroReserva = cboNroReserva.SelectedValue.ToString();
            if (cboTelefono.SelectedIndex != -1)
                _telefono = cboTelefono.SelectedValue.ToString();
            if (cboComensales.SelectedIndex != -1)
                _cantidadComensales = cboComensales.SelectedValue.ToString();
            if (cboNroMesa.SelectedIndex != -1)
                _nroMesa = cboNroMesa.SelectedValue.ToString();
            if (cboNombreCliente.SelectedIndex != -1)
                _nombreCliente = cboNombreCliente.SelectedValue.ToString();
            if (dtpHoraDesde.Value > dtpHoraHasta.Value)
            {
                MessageBox.Show("Horas erroneas!!!");
                dtpHoraDesde.Focus();
                return;
            }

            this.CargarGrilla(dgvReservas, miGestorReservas.RecuperarFiltrados(dtpFechaDesde.Value.ToString("yyyy/MM/dd"),
                                                              dtpFechaHasta.Value.ToString("yyyy/MM/dd"),
                                                              _nroReserva,
                                                              _nroMesa,
                                                              _telefono,
                                                              _cantidadComensales,
                                                              _nombreCliente,
                                                              dtpHoraDesde.Value.ToString("HH:mm"),
                                                              dtpHoraHasta.Value.ToString("HH:mm")));
        }

        private void limpiar()
        {
            this.dtpFechaHasta.Value = DateTime.Today;
            this.cboNroReserva.SelectedIndex = -1;
            this.cboNroMesa.SelectedIndex = -1;
            this.cboTelefono.SelectedIndex = -1;
            this.cboComensales.SelectedIndex = -1;
            this.cboNombreCliente.SelectedIndex = -1;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            frmDetalleReserva far = new frmDetalleReserva();
            far.Tipos = "New";
            far.ShowDialog();
            far.Dispose();
            consultar();
        }

        private void botones(bool x) {
            btnBorrar.Enabled = x;
            btnEditar.Enabled = x;
            btnDetalle.Enabled = x;
        }
        private void dgvReservas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvReservas.Rows.Count != 0)
            {
                Global.IdReserva = dgvReservas.SelectedCells[0].Value.ToString();
                botones(true);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar esta reserva?", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                miGestorReservas.Borrar(Global.IdReserva);
                botones(false);
            string _nroReserva, _nroMesa, _telefono, _cantidadComensales, _nombreCliente, _horaReserva;
            _nroReserva = _nroMesa = _cantidadComensales = _telefono = _nombreCliente = _horaReserva = string.Empty;
            if (dtpFechaDesde.Value > dtpFechaHasta.Value)
            {
                MessageBox.Show("Fechas erroneas!!!");
                dtpFechaDesde.Focus();
                return;
            }

            if (cboNroReserva.SelectedIndex != -1)
                _nroReserva = cboNroReserva.SelectedValue.ToString();
            if (cboTelefono.SelectedIndex != -1)
                _telefono = cboTelefono.SelectedValue.ToString();
            if (cboComensales.SelectedIndex != -1)
                _cantidadComensales = cboComensales.SelectedValue.ToString();
            if (cboNroMesa.SelectedIndex != -1)
                _nroMesa = cboNroMesa.SelectedValue.ToString();
            if (cboNombreCliente.SelectedIndex != -1)
                _nombreCliente = cboNombreCliente.SelectedValue.ToString();
            if (dtpHoraDesde.Value > dtpHoraHasta.Value)
            {
                MessageBox.Show("Horas erroneas!!!");
                dtpHoraDesde.Focus();
                return;
            }

            this.CargarGrilla(dgvReservas, miGestorReservas.RecuperarFiltrados(dtpFechaDesde.Value.ToString("yyyy/MM/dd"),
                                                              dtpFechaHasta.Value.ToString("yyyy/MM/dd"),
                                                              _nroReserva,
                                                              _nroMesa,
                                                              _telefono,
                                                              _cantidadComensales,
                                                              _nombreCliente,
                                                              dtpHoraDesde.Value.ToString("HH:mm"),
                                                              dtpHoraHasta.Value.ToString("HH:mm")));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            frmDetalleReserva far = new frmDetalleReserva();
            far.Tipos = "Edit";
            far.NumReserva = (int)dgvReservas.CurrentRow.Cells[0].Value;
            far.NumMesa = (int)dgvReservas.CurrentRow.Cells[1].Value;
            far.FechaReserva = (DateTime)dgvReservas.CurrentRow.Cells[2].Value;
            far.HoraReserva = (TimeSpan)dgvReservas.CurrentRow.Cells[3].Value;
            far.NomCliente = dgvReservas.CurrentRow.Cells[4].Value.ToString();
            far.TelCliente = dgvReservas.CurrentRow.Cells[5].Value.ToString();
            far.CantComensales = (int)dgvReservas.CurrentRow.Cells[6].Value;
            far.ShowDialog();
            far.Dispose();
            consultar();
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            frmDetalleReserva far = new frmDetalleReserva();
            far.Tipos = "Detail";
            far.NumReserva = (int)dgvReservas.CurrentRow.Cells[0].Value;
            far.NumMesa = (int)dgvReservas.CurrentRow.Cells[1].Value;
            far.FechaReserva = (DateTime)dgvReservas.CurrentRow.Cells[2].Value;
            far.HoraReserva = (TimeSpan)dgvReservas.CurrentRow.Cells[3].Value;
            far.NomCliente = dgvReservas.CurrentRow.Cells[4].Value.ToString();
            far.TelCliente = dgvReservas.CurrentRow.Cells[5].Value.ToString();
            far.CantComensales = (int)dgvReservas.CurrentRow.Cells[6].Value;
            far.ShowDialog();
            far.Dispose();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}

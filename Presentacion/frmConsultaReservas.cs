using AppBTS.Negocio;
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
        Mesas oMesas= new Mesas();
        Usuario oUsuario = new Usuario();
        public class Global
        {
            private static string idReserva;
            public static string IdReserva { get => idReserva; set => idReserva = value; }
        }

        public frmConsultaReservas()
        {
            InitializeComponent();
        }

        private void frmConsultaReservas_Load(object sender, EventArgs e)
        {
            limpiar();
            // TODO: esta línea de código carga datos en la tabla 'masterDataSet.Bugs' Puede moverla o quitarla según sea necesario.
            this.dtpFechaDesde.Value = DateTime.Today.AddDays(-7);
            this.dtpFechaHasta.Value = DateTime.Today;

            this.CargarCombo(cboNroReserva, oReservas.RecuperarTodosConParametro( "nroReserva"));
            this.CargarCombo(cboNroMesa, oMesas.RecuperarTodos());
            this.CargarCombo(cboNombreCliente, oReservas.RecuperarTodosConParametro("nombreCliente"));
            this.CargarCombo(cboTelefono, oReservas.RecuperarTodosConParametro("telefono"));
            this.CargarCombo(cboComensales, oReservas.RecuperarTodosConParametro("cantidadComensales"));
            this.CargarCombo(cboHora, oReservas.RecuperarTodosConParametro("horaReserva"));

            this.btnConsultar.Enabled = true;
            this.btnNuevo.Enabled = true;
            this.btnBorrar.Enabled = false;
            this.btnEditar.Enabled = false;
            this.btnDetalle.Enabled = false;
            this.btnSalir.Enabled = true;

            //this.dgvReservas.DataSource = oReservas.RecuperarTodos();
            this.CargarGrilla(dgvReservas, oReservas.RecuperarTodos());
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
        private void CargarCombo(ComboBox combo, DataTable tabla,string campoMostrar,string campoValor)
        {
            combo.DataSource = tabla;
            combo.DisplayMember = campoMostrar;
            combo.ValueMember = campoValor;
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            
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
            if (cboHora.SelectedIndex != -1)
                _horaReserva = cboHora.SelectedValue.ToString();

            this.CargarGrilla(dgvReservas, oReservas.RecuperarFiltrados(dtpFechaDesde.Value.ToString("yyyy/MM/dd"),
                                                              dtpFechaHasta.Value.ToString("yyyy/MM/dd"),
                                                              _nroReserva,
                                                              _nroMesa,
                                                              _telefono,
                                                              _cantidadComensales,
                                                              _nombreCliente,
                                                              _horaReserva));

            limpiar();
        }


        private void limpiar()
        {
            this.dtpFechaHasta.Value = DateTime.Today;
            this.cboNroReserva.SelectedIndex = -1;
            this.cboNroMesa.SelectedIndex = -1;
            this.cboTelefono.SelectedIndex = -1;
            this.cboComensales.SelectedIndex = -1;
            this.cboNombreCliente.SelectedIndex = -1;
            this.cboHora.SelectedIndex = -1;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmAltaReserva far = new frmAltaReserva();
            far.ShowDialog();
            far.Dispose();
        }


        private void dgvReservas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Global.IdReserva = dgvReservas.Rows[e.RowIndex].Cells[0].Value.ToString();
            btnBorrar.Enabled = true;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            oReservas.Borrar(Global.IdReserva);
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
            if (cboHora.SelectedIndex != -1)
                _horaReserva = cboHora.SelectedValue.ToString();

            this.CargarGrilla(dgvReservas, oReservas.RecuperarFiltrados(dtpFechaDesde.Value.ToString("yyyy/MM/dd"),
                                                              dtpFechaHasta.Value.ToString("yyyy/MM/dd"),
                                                              _nroReserva,
                                                              _nroMesa,
                                                              _telefono,
                                                              _cantidadComensales,
                                                              _nombreCliente,
                                                              _horaReserva));

            limpiar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
    }
}

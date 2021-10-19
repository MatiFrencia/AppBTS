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
    public partial class frmDetalleReserva : Form
    {
        private int numReserva;
        private int numMesa;
        private DateTime fechaReserva;
        private TimeSpan horaReserva;
        private string nomCliente;
        private string telCliente;
        private int cantComensales;
        private string tipos;

        public string Tipos { get => tipos; set => tipos = value; }
        public int NumReserva { get => numReserva; set => numReserva = value; }
        public int NumMesa { get => numMesa; set => numMesa = value; }
        public DateTime FechaReserva { get => fechaReserva; set => fechaReserva = value; }
        public TimeSpan HoraReserva { get => horaReserva; set => horaReserva = value; }
        public string NomCliente { get => nomCliente; set => nomCliente = value; }
        public string TelCliente { get => telCliente; set => telCliente = value; }
        public int CantComensales { get => cantComensales; set => cantComensales = value; }
        private ReservaService miGestorReservas = new ReservaService();

        public frmDetalleReserva()
        {
            InitializeComponent();
        }

        Reservas oReserva = new Reservas();
        private void frmAltaReserva_Load(object sender, EventArgs e)
        {
            frmConsultaReservas frm = new frmConsultaReservas();
            frmPrincipal frmp = new frmPrincipal();
            this.dtpHoraReserva.Format = DateTimePickerFormat.Custom;
            this.dtpHoraReserva.CustomFormat = "HH':'mm";
            this.dtpHoraReserva.ShowUpDown = true;
            if (tipos == "New")
            {
                this.lbTitulo.Text = "Crear Reserva";
                limpiar();
                campos(true);
                this.txtbNumeroReserva.Enabled = false;
                string numReserva = miGestorReservas.IdSiguiente().ToString();
                this.txtbNumeroReserva.Text = numReserva;
                
            }
            if (tipos == "Edit")
            {
                this.lbTitulo.Text = "Editar Reserva";
                campos(true);
                actualizarCampos();
                this.txtbNumeroReserva.Enabled = false;
            }
            if (tipos == "Detail")
            {
                this.lbTitulo.Text = "Detalle Reserva";
                campos(false);
                actualizarCampos();
            }
        }
        private void campos(bool x)
        { 
                this.txtbNumeroReserva.Enabled = x;
                this.txtbNumeroMesa.Enabled = x;
                this.dtpFechaReserva.Enabled = x;
                this.dtpHoraReserva.Enabled = x;
                this.txtbCliente.Enabled = x;
                this.txtbTelefono.Enabled = x;
                this.txtbCantidadComensales.Enabled = x;
        }
        private void actualizarCampos()
        {
            this.txtbNumeroReserva.Text = numReserva.ToString();
            this.txtbNumeroMesa.Text = numMesa.ToString();
            this.dtpFechaReserva.Value = fechaReserva;
            this.dtpHoraReserva.Text = horaReserva.ToString();
            this.txtbCliente.Text = nomCliente;
            this.txtbTelefono.Text = telCliente.ToString();
            this.txtbCantidadComensales.Text = cantComensales.ToString();
        }

        private void limpiar() {
            this.txtbNumeroReserva.Text = "";
            this.txtbNumeroMesa.Text = "";
            this.dtpFechaReserva.Value = DateTime.Today;
            this.dtpHoraReserva.Value = DateTime.Now;
            this.txtbCliente.Text = "";
            this.txtbTelefono.Text = "";
            this.txtbCantidadComensales.Text = "";
        }
        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            if (tipos == "Edit")
            {
                miGestorReservas.Modificar(numReserva,Convert.ToInt32(txtbNumeroMesa.Text),dtpFechaReserva.Value.ToString("yyyy-MM-dd"), dtpHoraReserva.Value.ToString("HH:mm:ss"),
                                   txtbCliente.Text,txtbTelefono.Text,Convert.ToInt32(txtbCantidadComensales.Text));
            }

            if (tipos == "New")
            {
                oReserva.NroReserva = Convert.ToInt32(txtbNumeroReserva.Text);
                oReserva.NroMesa = Convert.ToInt32(txtbNumeroMesa.Text);
                oReserva.FechaReserva = dtpFechaReserva.Value;
                oReserva.HoraReserva = TimeSpan.Parse(dtpHoraReserva.Value.ToString("HH:mm"));
                oReserva.NombreCliente = txtbCliente.Text;
                oReserva.Telefono = txtbTelefono.Text;
                oReserva.CantidadComensales = Convert.ToInt32(txtbCantidadComensales.Text);
                numReserva = Convert.ToInt32(txtbNumeroReserva.Text);
                miGestorReservas.AgregarReserva(oReserva);
            }

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {   if (tipos != "Detail")
                if (MessageBox.Show("Está seguro que desea Salir?", "ATENCION, NO se guardaran los cambios", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

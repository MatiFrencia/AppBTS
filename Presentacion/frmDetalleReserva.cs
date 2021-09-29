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
    public partial class frmDetalleReserva : Form
    {
        private int numReserva;
        private int numMesa;
        private DateTime fechaReserva;
        private TimeSpan horaReserva;
        private string nomCliente;
        private string telCliente;
        private int cantComensales;

        public int NumReserva { get => numReserva; set => numReserva = value; }
        public int NumMesa { get => numMesa; set => numMesa = value; }
        public DateTime FechaReserva { get => fechaReserva; set => fechaReserva = value; }
        public TimeSpan HoraReserva { get => horaReserva; set => horaReserva = value; }
        public string NomCliente { get => nomCliente; set => nomCliente = value; }
        public string TelCliente { get => telCliente; set => telCliente = value; }
        public int CantComensales { get => cantComensales; set => cantComensales = value; }

        public frmDetalleReserva()
        {
            InitializeComponent();
        }

        private void frmAltaReserva_Load(object sender, EventArgs e)
        {
            this.txtbNumeroReserva.Enabled = false;
            this.txtbNumeroMesa.Enabled = false;
            this.txtbFechaReserva.Enabled = false;
            this.txtbHoraReserva.Enabled = false;
            this.txtbCliente.Enabled = false;
            this.txtbTelefono.Enabled = false;
            this.txtbCantidadComensales.Enabled = false;
            actualizarCampos();
        }
        private void actualizarCampos() {
            this.txtbNumeroReserva.Text = numReserva.ToString();
            this.txtbNumeroMesa.Text = numMesa.ToString();
            this.txtbFechaReserva.Text = fechaReserva.ToString();
            this.txtbHoraReserva.Text = horaReserva.ToString();
            this.txtbCliente.Text = nomCliente;
            this.txtbTelefono.Text = telCliente.ToString();
            this.txtbCantidadComensales.Text = cantComensales.ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

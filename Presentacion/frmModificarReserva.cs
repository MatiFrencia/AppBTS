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
    public partial class frmModificarReserva : Form
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

        public frmModificarReserva()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro que desea Salir?", "ATENCION: No se guardaran los cambios", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                this.Close();
        }

        private void frmAltaReserva_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bAR_PAVDataSet.Reservas' Puede moverla o quitarla según sea necesario.
            this.reservasTableAdapter.Fill(this.bAR_PAVDataSet.Reservas);
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
            if (this.txtbNumeroReserva.Text == "" || this.txtbNumeroMesa.Text == "" || this.txtbFechaReserva.Text == "" || this.txtbHoraReserva.Text == "" || this.txtbCliente.Text == "" || this.txtbTelefono.Text == "" || this.txtbCantidadComensales.Text == "")
                MessageBox.Show("Por favor, no deje campos en blanco.", "Datos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {

                MessageBox.Show("Cambios registrados con éxito.", "Modificar Reserva", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}

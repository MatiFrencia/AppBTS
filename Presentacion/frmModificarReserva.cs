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
        Reservas reserva;

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
            //this.reservasTableAdapter.Fill(this.bAR_PAVDataSet.Reservas);
            actualizarCampos();
        }
        private void actualizarCampos() {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.txtbNumeroReserva.Text == "" || this.txtbNumeroMesa.Text == "" || this.txtbFechaReserva.Text == "" || this.txtbHoraReserva.Text == "" || this.txtbCliente.Text == "" || this.txtbTelefono.Text == "" || this.txtbCantidadComensales.Text == "")
                MessageBox.Show("Por favor, no deje campos en blanco.", "Datos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {

            }
        }
    }
}

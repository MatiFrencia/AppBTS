﻿using System;
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
        private string tipos;

        public string Tipos { get => tipos; set => tipos = value; }
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

        Reservas oReserva = new Reservas();
        private void frmAltaReserva_Load(object sender, EventArgs e)
        {
            frmConsultaReservas frm = new frmConsultaReservas();
            frmPrincipal frmp = new frmPrincipal();
            if (tipos == "New")
            {
                this.lbTitulo.Text = "Crear Reserva";
                limpiar();
                campos(true);
                this.txtbNumeroReserva.Enabled = false;
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
                this.txtbFechaReserva.Enabled = x;
                this.txtbHoraReserva.Enabled = x;
                this.txtbCliente.Enabled = x;
                this.txtbTelefono.Enabled = x;
                this.txtbCantidadComensales.Enabled = x;
        }
        private void actualizarCampos()
        {
            this.txtbNumeroReserva.Text = numReserva.ToString();
            this.txtbNumeroMesa.Text = numMesa.ToString();
            this.txtbFechaReserva.Text = fechaReserva.ToString("yyyy/MM/dd");
            this.txtbHoraReserva.Text = horaReserva.ToString();
            this.txtbCliente.Text = nomCliente;
            this.txtbTelefono.Text = telCliente.ToString();
            this.txtbCantidadComensales.Text = cantComensales.ToString();
        }

        private void limpiar() {
            this.txtbNumeroReserva.Text = "";
            this.txtbNumeroMesa.Text = "";
            this.txtbFechaReserva.Text = "";
            this.txtbHoraReserva.Text = "";
            this.txtbCliente.Text = "";
            this.txtbTelefono.Text = "";
            this.txtbCantidadComensales.Text = "";
        }
        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            if (tipos == "Edit")
            {
                oReserva.Modificar(numReserva,Convert.ToInt32(txtbNumeroMesa.Text),txtbFechaReserva.Text, txtbHoraReserva.Text,
                                   txtbCliente.Text,txtbTelefono.Text,Convert.ToInt32(txtbCantidadComensales.Text));
            }
            this.Close();
        }

        private void btnConfirmarMesa_Click(object sender, EventArgs e)
        {
            /*string nroMesa = oReservas.IdSiguiente().ToString();
            string nroSillas = nmrNroSillas.Text;
            if (nroMesa == "" || nroSillas == "")
                MessageBox.Show("Por favor, complete todos los campos requeridos.", "Datos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else
            {
                oMesas.NroMesa = Convert.ToInt32(nroMesa);
                oMesas.CantidadSillas = nroSillas;
                oMesas.AgregarMesa(nroMesa.ToString());
                MessageBox.Show("Mesa registrada con éxito.", "Nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }*/

        }
    }

}

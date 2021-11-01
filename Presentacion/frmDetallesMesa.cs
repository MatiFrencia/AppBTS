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
    public partial class frmDetallesMesa : Form
    {
        public frmDetallesMesa()
        {
            InitializeComponent();
        }
        private Button botonClickeado = null;
        Mesas oMesas = new Mesas();
        private ReservaService miGestorReservas = new ReservaService();
        MesasService miGestorMesas = new MesasService();
        public frmDetallesMesa(Button botonClickeado) : this()
        {
            this.botonClickeado = botonClickeado;
        }

        private void frmDetallesMesa_Load(object sender, EventArgs e)
        { 
            Reservas oReservas = new Reservas();
            // TODO: esta línea de código carga datos en la tabla 'bAR_PAVDataSet.Reservas' Puede moverla o quitarla según sea necesario.
            //this.reservasTableAdapter.Fill(this.bAR_PAVDataSet.Reservas);
            this.CargarGrilla(dgvReservasMesa, miGestorReservas.RecuperarFiltrados(DateTime.Today.AddDays(-1).ToString("yyyy/MM/dd"), 
                                                                           DateTime.Today.AddDays(+7).ToString("yyyy/MM/dd"), string.Empty, botonClickeado.Text,
                                                                           string.Empty, string.Empty, string.Empty, "00:00", "23:59"));
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

        private void btnOkey_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnBorrarMesa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro que desea Borrarla?", "ATENCION, Está a punto de borrar la MESA", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                miGestorMesas.Borrar(botonClickeado.Text);
                this.DialogResult = DialogResult.OK;
                this.Close();

        }
    }
}

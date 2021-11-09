using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppBTS.Servicios;

namespace AppBTS.Presentacion
{
    public partial class frmReporteHoras : Form
    {
        public frmReporteHoras()
        {
            InitializeComponent();
        }
        TicketService miGestorTickets = new TicketService();

        private void frmReporteHoras_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (dtpFechaDesde.Value > dtpFechaHasta.Value)
            {
                MessageBox.Show("Fechas erroneas!!!");
                dtpFechaDesde.Focus();
                return;
            }
            this.dsHorasBindingSource.DataSource = ConstruirTabla();
            this.reportViewer1.RefreshReport();
        }

        private DataTable ConstruirTabla()
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("hora");
            tabla.Columns.Add("q_tickets");
            tabla.Columns.Add("porc_tickets");
            tabla.Columns.Add("ventas");
            tabla.Columns.Add("porc_ventas");
            int q_tickets_total = 0;
            double ventas_total = 0;
            for (int i = 0; i < 24; i++)
            {
                DataRow fila = tabla.NewRow();
                string hora;
                string hora_hasta;
                if (i < 10)
                    hora = "0" + i.ToString() + ":00";
                else
                    hora = i.ToString() + ":00";
                if (i < 9)
                    hora_hasta = "0" + (i + 1).ToString() + ":00";
                else
                {
                    if (i == 23)
                        hora_hasta = "00:00";
                    else
                        hora_hasta = (i + 1).ToString() + ":00";
                }
                fila["hora"] = hora;
                int q_tickets = miGestorTickets.CantidadTicketsPorHorario(hora, hora_hasta, dtpFechaDesde.Value.ToString(), dtpFechaHasta.Value.ToString());
                fila["q_tickets"] = q_tickets;
                q_tickets_total += q_tickets;
                double ventas = miGestorTickets.VentasPorHorario(hora, hora_hasta, dtpFechaDesde.Value.ToString(), dtpFechaHasta.Value.ToString());
                fila["ventas"] = ventas;
                ventas_total += ventas;
                tabla.Rows.Add(fila);
            }
            foreach (DataRow fila in tabla.Rows)
            {
                fila["porc_tickets"] = Math.Round((decimal)Convert.ToInt32(fila["q_tickets"]) * 100 / q_tickets_total, 2).ToString() + "%";
                fila["porc_ventas"] = Math.Round(Convert.ToDouble(fila["ventas"]) * 100 / ventas_total, 2) + "%";
            }
            return tabla;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

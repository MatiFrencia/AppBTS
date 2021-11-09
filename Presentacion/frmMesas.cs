using AppBTS.Properties;
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
    public partial class frmMesas : Form
    {
        public frmMesas()
        {
            InitializeComponent();
        }
        public string NroMesa { get; set; }
        public string BotonClickeado { get; set; }
        MesasService miGestorMesas = new MesasService();
        ReservaService miGestorReservas = new ReservaService();

        public Image AsignarColor(string idMesa)
        {
            DataTable reservas = miGestorReservas.RecuperarFiltrados(DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd"),
                                                         DateTime.Today.ToString("yyyy-MM-dd"),
                                                         "", idMesa, "", "", "", "00:00", "23:59");
            
            for (int i = 0; i < reservas.Rows.Count; i++)
            {
                DateTime horaReserva = Convert.ToDateTime(reservas.Rows[i]["horaReserva"].ToString());
                
                if ( horaReserva <= DateTime.Now.AddMinutes(10) &&
                       horaReserva >= DateTime.Now.AddHours(-2))
                {
                    return AppBTS.Properties.Resources.MesaOcupada;
                }
            }
            return AppBTS.Properties.Resources.MesaLibre;
        }
        public void ActualizarMesas()
        {
            Button[,] boton = new Button[10, 10];
            Mesas oMesa = new Mesas();
            DataTable tabla = miGestorMesas.RecuperarTodos();
            
            //string nroMesa = tabla.Rows[i]["nroMesa"].ToString;
            int cantMesas = tabla.Rows.Count;
            int cantFilas = cantMesas / 3;
            int cantBotones = 0;
            if (cantMesas % 3 != 0)
            {
                cantFilas = cantMesas / 3 + 1;
            }
            for (int i = 0; i < cantFilas; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (cantBotones < cantMesas)
                    {
                        Image imgMesa = AsignarColor(tabla.Rows[cantBotones]["nroMesa"].ToString());
                        boton[i, j] = new Button
                        {
                            Image = imgMesa,
                            Width = 221,
                            Height = 176,
                            Text = tabla.Rows[cantBotones]["nroMesa"].ToString(),
                            TextAlign = System.Drawing.ContentAlignment.BottomRight,
                            Top = i * 176 + 30,
                            Left = j * 221 + 70,
                            Name = Text,
                        };
                        boton[i, j].Click += new System.EventHandler(this.buttonMesa_Click);
                        this.Controls.Add(boton[i, j]);
                        NroMesa = boton[i,j].Name;
                    }
                    else
                    {
                        break;
                    };

                    cantBotones++;
                }
            }
        }
        private void añadirMesaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaMesa fam = new frmAltaMesa();
            fam.FormClosed += fam_FormClosed;
            fam.ShowDialog();
        }

        private void fam_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form fam = sender as Form;
            if (fam.DialogResult == DialogResult.OK)
            {
                this.Controls.Clear();
                InitializeComponent();
                ActualizarMesas();
            }
        }

        private void buttonMesa_Click(object sender, EventArgs e)
        {
            var button = (Button)sender; //obtenemos el botón clickeado
            frmDetallesMesa fdm = new frmDetallesMesa(button);
            fdm.FormClosed += fdm_FormClosed;
            fdm.ShowDialog();
        }
        private void fdm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form fdm = sender as Form;
            if (fdm.DialogResult == DialogResult.OK)
            {
                this.Controls.Clear();
                InitializeComponent();
                ActualizarMesas();
            }
        }

        private void frmMesas_Load(object sender, EventArgs e)
        {
            ActualizarMesas();
        }

        private void recuperarMesasBorradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRecuperarMesas frmb = new frmRecuperarMesas();
            frmb.FormClosed += frmb_FormClosed;
            frmb.Show();
        }

        private void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form frm = sender as Form;
            if (frm.DialogResult == DialogResult.OK)
            {
                this.Controls.Clear();
                InitializeComponent();
                ActualizarMesas();
            }
        }

        private void frmb_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form frm = sender as Form;
            if (frm.DialogResult == DialogResult.OK)
            {
                this.Controls.Clear();
                InitializeComponent();
                ActualizarMesas();
            }
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
            this.ActualizarMesas();
            
        }
    }
}

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

namespace AppBTS.Presentacion
{
    public partial class frmMesas : Form
    {
        public frmMesas()
        {
            InitializeComponent();
            ActualizarMesas();
        }
        public string NroMesa { get; set; }
        public string BotonClickeado { get; set; }
        public void ActualizarMesas()
        {
            
            Button[,] boton = new Button[10, 10];
            Mesas oMesa = new Mesas();
            DataTable tabla = oMesa.RecuperarTodos();
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
                        boton[i, j] = new Button
                        {
                            Image = AppBTS.Properties.Resources.Mesa1,
                            Width = 221,
                            Height = 176,
                            Text = String.Format("{0}", j + 1 + 3 * i),
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
                ActualizarMesas();
            }
        }

        private void buttonMesa_Click(object sender, EventArgs e)
        {
            var button = (Button)sender; //obtenemos el botón clickeado
            frmDetallesMesa fdm = new frmDetallesMesa(button);
            fdm.ShowDialog();
        }


    }
}

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
    public partial class frmAltaMesa : Form
    {
        Mesas oMesas = new Mesas();
        frmMesas ofrmMesas = new frmMesas();
        MesasService miGestorMesas = new MesasService();
        public frmAltaMesa()
        {
            InitializeComponent();
            nmrNroMesa.Text = miGestorMesas.IdSiguiente().ToString();
        }

        private void btnCancelarMesa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro que desea Salir?", "ATENCION, NO se guardaran los cambios", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                this.DialogResult = DialogResult.Cancel;
                this.Close();
           
        }

        private void btnConfirmarMesa_Click(object sender, EventArgs e)
        {
            string nroMesa = miGestorMesas.IdSiguiente().ToString();
            string nroSillas = nmrNroSillas.Text;
            if (nroMesa == "" || nroSillas == "")
                MessageBox.Show("Por favor, complete todos los campos requeridos.", "Datos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else
            {
                oMesas.NroMesa = Convert.ToInt32(nroMesa);
                oMesas.CantidadSillas = nroSillas;
                miGestorMesas.AgregarMesa(oMesas);
                MessageBox.Show("Mesa registrada con éxito.", "Nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            
        }
    }
}

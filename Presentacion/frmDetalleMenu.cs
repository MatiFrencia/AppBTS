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
    public partial class frmDetalleMenu : Form
    {
        private int idMenu;
        private string nombre;
        private int pcioUnitario;
        private string tipos;

        public string Tipos { get => tipos; set => tipos = value; }
        public int IdMenu { get => idMenu; set => idMenu = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int PcioUnitario { get => pcioUnitario; set => pcioUnitario = value; }
        private MenuService miGestorMenus = new MenuService();

        public frmDetalleMenu()
        {
            InitializeComponent();
        }

        Menus oMenu = new Menus();

        private void frmDetalleMenu_Load(object sender, EventArgs e)
        {
            frmConsultarMenus frm = new frmConsultarMenus();
            frmPrincipal frmp = new frmPrincipal();
            if (tipos == "New")
            {
                this.lbTitulo.Text = "Crear Menu";
                limpiar();
                campos(true);
            }
            if (tipos == "Edit")
            {
                this.lbTitulo.Text = "Editar Menú";
                campos(true);
                actualizarCampos();
                this.txtbIdMenu.Enabled = false;
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
            this.txtbIdMenu.Enabled = x;
            this.txtbNombre.Enabled = x;
            this.txtbPrecio.Enabled = x;
        }
        private void actualizarCampos()
        {
            this.txtbIdMenu.Text = idMenu.ToString();
            this.txtbNombre.Text = nombre.ToString();
            this.txtbPrecio.Text = pcioUnitario.ToString();
        }

        private void limpiar()
        {
            this.txtbIdMenu.Text = "";
            this.txtbNombre.Text = "";
            this.txtbPrecio.Text = "";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (tipos == "Edit")
            {
                miGestorMenus.Modificar(idMenu, txtbNombre.Text, Convert.ToInt32(txtbPrecio.Text));
            }

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (tipos != "Detail")
                if (MessageBox.Show("Está seguro que desea Salir?", "ATENCION, NO se guardaran los cambios", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

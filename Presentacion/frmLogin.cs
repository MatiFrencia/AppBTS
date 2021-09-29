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

namespace AppBTS
{
    public partial class frmLogin : Form
    {

        private Usuario miUsuario = new Usuario();


        internal Usuario MiUsuario { get => miUsuario; set => miUsuario = value; }

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro que desea Salir?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //if (this.txtUsuario.Text=="")
            if (string.IsNullOrEmpty(this.txtUsuario.Text)) 
            {
                MessageBox.Show("Debe ingresar un Usuario.");
                this.txtUsuario.Focus();
                return;
            }
            if (this.txtClave.Text==string.Empty)
            {
                MessageBox.Show("Debe ingresar una Contraseña.");
                this.txtClave.Focus();
                return;
            }
            frmPrincipal fp = new frmPrincipal();
            this.miUsuario.Nombre = this.txtUsuario.Text;
            this.miUsuario.Password = this.txtClave.Text;

            this.miUsuario.Id_usuario = this.miUsuario.validarUsuario(miUsuario.Nombre, miUsuario.Password);

            //if (this.txtUsuario.Text==this.user && this.txtClave.Text==this.pass)
            if (miUsuario.Id_usuario!=0)
            {
                MessageBox.Show("Login OK", "Ingreso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();

            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtClave.Text = string.Empty;
                this.txtUsuario.Focus();
            }
        }
    }
}

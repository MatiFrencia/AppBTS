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

namespace AppBTS
{
    public partial class frmLogin : Form
    {
        private Usuario miUsuario = new Usuario();
        
        internal Usuario MiUsuario { get => miUsuario; set => miUsuario = value; }
        private UsuarioService miGestorUsuarios = new UsuarioService();
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
            if (string.IsNullOrEmpty(this.txtUsuario.Text)) 
            {
                MessageBox.Show("Debe ingresar un nombre de Usuario.");
                this.txtClave.Text = string.Empty;
                this.txtUsuario.Focus();
                return;
            }
            if (this.txtClave.Text==string.Empty)
            {
                MessageBox.Show("Debe ingresar una Contraseña.");
                this.txtClave.Focus();
                return;
            }

            this.miUsuario.Nombre = this.txtUsuario.Text.Replace('\'', ' ');
            this.miUsuario.Password = this.txtClave.Text.Replace('\'', ' ');
            //this.miUsuario.Nombre = this.txtUsuario.ToString();
            //this.miUsuario.Password = this.txtClave.ToString();

            this.miUsuario.Id_usuario = this.miGestorUsuarios.validarUsuario(miUsuario.Nombre, miUsuario.Password);

            //if (this.txtUsuario.Text==this.user && this.txtClave.Text==this.pass)
            if (miUsuario.Id_usuario!=0)
            {
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtClave.Text = string.Empty;
                this.txtUsuario.Focus();
            }
        }

        private void txtClave_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btnIngresar.PerformClick();
            }
        }
    }
}

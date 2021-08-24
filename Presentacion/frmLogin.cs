using System;
using AppBTS.Negocio;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(this.txtUsuario.Text))
            {
                MessageBox.Show("Por favor ingrese un Usuario.");
                this.txtUsuario.Focus();
                return;
            }
            if (string.IsNullOrEmpty(this.txtContraseña.Text))
            {
                MessageBox.Show("Por favor ingrese una contraseña.");
                this.txtContraseña.Focus();
                return;
            }
            this.miUsuario.Nombre = this.txtUsuario.Text;
            this.miUsuario.Password = this.txtContraseña.Text;
            this.miUsuario.Id_usuario = this.miUsuario.validarUsuario(miUsuario.Nombre,miUsuario.Password);
            miUsuario.Nombre = this.txtUsuario.Text;
            miUsuario.Nombre = this.txtContraseña.Text;
            
            if (miUsuario.Id_usuario!=0)
            {
                MessageBox.Show("Login OK", "Ingreso al Sistema", MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.txtContraseña.Focus();
                return;
            }
            else
            {
                MessageBox.Show("Contraseña y/o Usuario incorrectos.", "Validar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtUsuario.Text = "";
                this.txtContraseña.Text = string.Empty;
                this.txtUsuario.Focus();
            }

    }
        
        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PanelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

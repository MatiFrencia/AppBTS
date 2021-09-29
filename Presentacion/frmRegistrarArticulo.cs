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
    public partial class frmRegistrarArticulo : Form
    {
        TipoArticulo oTipo = new TipoArticulo();
        Articulo oArticulo = new Articulo();
        public frmRegistrarArticulo()
        {
            InitializeComponent();
        }

        private void frmRegistrarArticulo_Load(object sender, EventArgs e)
        {
            CargarCombo(cboTipo, oTipo.RecuperarTodos());
            btnGuardar.Enabled = false;
        }

        private void CargarCombo(ComboBox combo, DataTable tabla)
        {
            combo.DataSource = tabla;
            combo.DisplayMember = tabla.Columns[1].ColumnName;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string precio = txtPrecio.Text;
            if (nombre == "" || precio == "")
                MessageBox.Show("Por favor, complete todos los campos requeridos.", "Datos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                oArticulo.Nombre = nombre;
                oArticulo.PrecioUnitario = Convert.ToDouble(precio);
                oArticulo.IdTipoArticulo = Convert.ToInt32(cboTipo.SelectedValue);
                oArticulo.Registrar();
                MessageBox.Show("Artículo registrado con éxito.", "Nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
        }

        private void Limpiar()
        {
            cboTipo.SelectedIndex = -1;
            txtNombre.Text = "";
            txtPrecio.Text = "";
            btnGuardar.Enabled = false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppBTS.Negocio;
using System.Windows.Forms;

namespace AppBTS.Presentacion
{
    public partial class frmModificarArticulo : Form
    {
        Articulo articulo;
        TipoArticulo oTipo = new TipoArticulo();
        public frmModificarArticulo(Articulo seleccionado)
        {
            InitializeComponent();
            articulo = seleccionado;
        }

        private void frmModificarArticulo_Load(object sender, EventArgs e)
        {
            CargarCombo(cboTipo, oTipo.RecuperarTodos());
            string targetValue = oTipo.RecuperarPorId(articulo.IdTipoArticulo);
            string value = "";
            while (value != targetValue)
            {
                cboTipo.SelectedIndex += 1;
                value = cboTipo.Text;
            }
            cboTipo.Enabled = false;
            CargarGrilla(dgvArticulo, articulo);
            txtNombre.Text = articulo.Nombre;
            txtNombre.Enabled = false;
            txtPrecio.Text = articulo.PrecioUnitario.ToString();
            txtPrecio.Enabled = false;
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
        private void CargarGrilla(DataGridView grilla, Articulo art)
        {
            grilla.Rows.Add(art.IdArticulo, art.Nombre, art.PrecioUnitario, oTipo.RecuperarPorId(art.IdTipoArticulo));
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnPrevisualizar_Click(object sender, EventArgs e)
        {
            dgvArticulo.Rows[0].Cells[1].Value = txtNombre.Text;
            dgvArticulo.Rows[0].Cells[2].Value = txtPrecio.Text;
            dgvArticulo.Rows[0].Cells[3].Value = cboTipo.Text;
        }

        private void btnEditarNombre_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            btnEditarNombre.Enabled = false;
        }

        private void btnEditarPrecio_Click(object sender, EventArgs e)
        {
            txtPrecio.Enabled = true;
            btnEditarPrecio.Enabled = false;
        }

        private void btnEditarTipo_Click(object sender, EventArgs e)
        {
            cboTipo.Enabled = true;
            btnEditarTipo.Enabled = false;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string precio = txtPrecio.Text;
            bool mNombre = false;
            bool mPrecio = false;
            bool mTipo = false;
            if (nombre == "" || precio == "")
                MessageBox.Show("Por favor, no deje campos en blanco.", "Datos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (txtNombre.Enabled == true)
                {
                    articulo.Nombre = nombre;
                    mNombre = true;
                }
                if (txtPrecio.Enabled == true)
                {
                    articulo.PrecioUnitario = Convert.ToDouble(precio);
                    mPrecio = true;
                }
                if (cboTipo.Enabled == true)
                {
                    articulo.IdTipoArticulo = oTipo.RecuperarPorNombre(cboTipo.Text);
                    mTipo = true;
                }
                articulo.Modificar(mNombre, mPrecio, mTipo);
                MessageBox.Show("Cambios registrados con éxito.", "Modificar artículo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}

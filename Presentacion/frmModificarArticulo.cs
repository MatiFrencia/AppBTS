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
using AppBTS.Servicios;

namespace AppBTS.Presentacion
{
    public partial class frmModificarArticulo : Form
    {
        Articulo articulo;
        TipoArticulo oTipo = new TipoArticulo();
        private ArticuloService miGestor = new ArticuloService();
        private TipoArticuloService miGestorTipoArticulo = new TipoArticuloService();
        public frmModificarArticulo(Articulo seleccionado)
        {
            InitializeComponent();
            articulo = seleccionado;
        }

        //Carga el combo de Tipos de Artículo con todos los tipos y lo deja seleccionado en el tipo del artículo que se quiere modificar.
        //Carga el nombre del artículo en el textbox de nombre y su precio en el textbox de precio.
        private void frmModificarArticulo_Load(object sender, EventArgs e)
        {
            CargarCombo(cboTipo, miGestorTipoArticulo.RecuperarTodos());
            string targetValue = miGestorTipoArticulo.RecuperarPorId(articulo.IdTipoArticulo);
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

        //Muestra el artículo cargado para modificación en una grilla de 1 fila.
        private void CargarGrilla(DataGridView grilla, Articulo art)
        {
            grilla.Rows.Add(art.IdArticulo, art.Nombre, art.PrecioUnitario, miGestorTipoArticulo.RecuperarPorId(art.IdTipoArticulo));
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Muestra los valores ingresados en la grilla, reemplazando a los originales, cuando se hace click en el botón de previsualizar cambios. No modifica el artículo.
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

        //Cambia en el objeto artículo los atributos que se hayan decidido editar, y le pide al objeto que se modifique en la BD con sus valores nuevos.
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
                    articulo.IdTipoArticulo = miGestorTipoArticulo.RecuperarPorNombre(cboTipo.Text);
                    mTipo = true;
                }
                miGestor.Modificar(mNombre, mPrecio, mTipo, articulo);
                MessageBox.Show("Cambios registrados con éxito.", "Modificar artículo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}

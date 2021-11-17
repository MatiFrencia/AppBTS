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
    public partial class frmConsultarArticulo : Form
    {
        Articulo oArticulo = new Articulo();
        TipoArticulo oTipo = new TipoArticulo();
        private ArticuloService miGestor = new ArticuloService();
        private TipoArticuloService miGestorTipoArticulo = new TipoArticuloService();
        public frmConsultarArticulo()
        {
            InitializeComponent();
        }
        private void frmConsultarArticulo_Load(object sender, EventArgs e)
        {
            CargarCombo(cboTipo, miGestorTipoArticulo.RecuperarTodos());
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
        }
        private void CargarCombo(ComboBox combo, DataTable tabla)
        {
            combo.DataSource = tabla;
            combo.DisplayMember = tabla.Columns[1].ColumnName;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Cuando se hace click en el botón de consultar. Si se marcó la opción de ver todos, trae todos los artículos. Si no, filtra por los parámetros ingresados.
        private void consultar() {
            if (this.chkTodos.Checked)
            {
                CargarGrilla(dgvArticulos, miGestor.RecuperarTodos());
            }
            else
            {
                string idArticulo = txtIdArtículo.Text;
                string nombre = txtNombre.Text;
                string idTipoArticulo = "";
                if (cboTipo.SelectedIndex != -1)
                    idTipoArticulo = cboTipo.SelectedValue.ToString();
                CargarGrilla(dgvArticulos, miGestor.RecuperarFiltrados(idArticulo, nombre, idTipoArticulo));
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            consultar();
        }

        private void CargarGrilla(DataGridView grilla, DataTable tabla)
        {
            grilla.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["idArticulo"],
                                tabla.Rows[i]["nombre"],
                                tabla.Rows[i]["pcioUnitario"],
                                tabla.Rows[i]["nombreTipo"]);
            }
        }

        //Llama al form de Registrar Artículo cuando se hace click en el botón de "Nuevo".
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmRegistrarArticulo fra = new frmRegistrarArticulo();
            fra.ShowDialog();
            fra.Dispose();
            consultar();
        }

        //Permite eliminar o modificar un artículo una vez que se lo selecciona en la grilla.
        private void dgvArticulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
        }

        //Si hace click en el botón de modificar, arma un objeto correspondiente al artículo seleccionado y se lo pasa por parámetro al form de Modificar Artículo.
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = new Articulo();
            seleccionado.IdArticulo = Convert.ToInt32(dgvArticulos.SelectedCells[0].Value);
            seleccionado.Nombre = dgvArticulos.SelectedCells[1].Value.ToString();
            seleccionado.PrecioUnitario = Convert.ToDouble(dgvArticulos.SelectedCells[2].Value);
            string tipoId = dgvArticulos.SelectedCells[3].Value.ToString();
            seleccionado.IdTipoArticulo = miGestorTipoArticulo.RecuperarPorNombre(tipoId);
            frmModificarArticulo fma = new frmModificarArticulo(seleccionado);
            fma.ShowDialog();
            fma.Dispose();
            consultar();
        }

        //Habilita o deshabilita los combo y textbox según si se marca o desmarca la opción de Ver todos, ya que si se eligen ver todos los artículos, no se va a
        //filtrar por ningún criterio.
        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTodos.Checked)
            {
                cboTipo.Enabled = false;
                txtIdArtículo.Enabled = false;
                txtNombre.Enabled = false;
            }
            else
            {
                cboTipo.Enabled = true;
                txtIdArtículo.Enabled = true;
                txtNombre.Enabled = true;
            }
        }

        //Pide confirmación si se hace click en el botón de eliminar un artículo, y si se confirma le hace borrado lógico.
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = new Articulo();
            string nombre = dgvArticulos.SelectedCells[1].Value.ToString();
            if (MessageBox.Show("¿Está seguro de que desea borrar '"+nombre+"'?","Eliminar Artículo",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                seleccionado.IdArticulo = Convert.ToInt32(dgvArticulos.SelectedCells[0].Value);
                miGestor.Eliminar(seleccionado.IdArticulo);
                MessageBox.Show("'" + nombre + "' eliminado con éxito.");
                consultar();
            }
        }
    }
}

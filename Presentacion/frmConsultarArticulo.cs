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
    public partial class frmConsultarArticulo : Form
    {
        Articulo oArticulo = new Articulo();
        TipoArticulo oTipo = new TipoArticulo();
        public frmConsultarArticulo()
        {
            InitializeComponent();
        }
        private void frmConsultarArticulo_Load(object sender, EventArgs e)
        {
            CargarCombo(cboTipo, oTipo.RecuperarTodos());
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string idArticulo = txtIdArtículo.Text;
            string nombre = txtNombre.Text;
            string idTipoArticulo = "";
            if (cboTipo.SelectedIndex != -1)
                idTipoArticulo = cboTipo.SelectedValue.ToString();
            CargarGrilla(dgvArticulos, oArticulo.RecuperarFiltrados(idArticulo, nombre, idTipoArticulo));
            cboTipo.SelectedIndex = -1;
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmRegistrarArticulo fra = new frmRegistrarArticulo();
            fra.ShowDialog();
            fra.Dispose();
        }

        private void dgvArticulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = new Articulo();
            seleccionado.IdArticulo = Convert.ToInt32(dgvArticulos.SelectedCells[0].Value);
            seleccionado.Nombre = dgvArticulos.SelectedCells[1].Value.ToString();
            seleccionado.PrecioUnitario = Convert.ToDouble(dgvArticulos.SelectedCells[2].Value);
            string tipoId = dgvArticulos.SelectedCells[3].Value.ToString();
            seleccionado.IdTipoArticulo = oTipo.RecuperarPorNombre(tipoId);
            frmModificarArticulo fma = new frmModificarArticulo(seleccionado);
            fma.ShowDialog();
            fma.Dispose();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using AppBTS.Negocio;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBTS.Presentacion
{
    public partial class frmAltaMenu : Form
    {
        TipoArticulo oTipo = new TipoArticulo();
        Articulo oArticulo = new Articulo();
        Menus oMenu = new Menus();
        public frmAltaMenu()
        {
            InitializeComponent();
        }

        private void frmAltaMenu_Load(object sender, EventArgs e)
        {
            lblTotal.Text = "0.00";
            CargarCombo(cboTipo, oTipo.RecuperarTodos());
            btnAgregar.Enabled = false;
            btnBorrar.Enabled = false;
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
            if (cboTipo.SelectedIndex != -1 & cboTipo.ValueMember != "")
            {
                string idSeleccionado = cboTipo.SelectedValue.ToString();
                CargarCombo(cboArticulos, oArticulo.RecuperarFiltrados("", "", idSeleccionado));
                btnAgregar.Enabled = false;
            }
        }

        private void cboArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboArticulos.SelectedIndex != -1 & cboArticulos.ValueMember != "")
            {
                btnAgregar.Enabled = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool noRepetido = true;
            int repetido = 0;
            for (int i = 0; i < dgvDetallesMenu.Rows.Count; i++)
            {
                if (Convert.ToInt32(dgvDetallesMenu.Rows[i].Cells[0].Value) == Convert.ToInt32(cboArticulos.SelectedValue))
                {
                    noRepetido = false;
                    repetido = i;
                    break;
                }
            }
            int cantidad = Convert.ToInt32(nudCantidad.Value);
            double precio = Convert.ToDouble(oArticulo.RecuperarPrecio(cboArticulos.SelectedValue.ToString()));
            if (noRepetido)
            {
                double subtotal = cantidad * precio;
                dgvDetallesMenu.Rows.Add(cboArticulos.SelectedValue, cboArticulos.Text, precio, cantidad, subtotal);
                btnBorrar.Enabled = true;
                lblTotal.Text = (Convert.ToDouble(lblTotal.Text) + subtotal).ToString();
                btnGuardar.Enabled = true;
            }
            else
            {
                if (MessageBox.Show("Artículo ya agregado en el menú. ¿Desea aumentar la cantidad de este artículo en " + cantidad.ToString() + "?", "Nuevo Menú", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    int nCantidad = Convert.ToInt32(dgvDetallesMenu.Rows[repetido].Cells["Cantidad"].Value) + cantidad;
                    dgvDetallesMenu.Rows[repetido].Cells["Cantidad"].Value = nCantidad;
                    dgvDetallesMenu.Rows[repetido].Cells["Subtotal"].Value = precio * nCantidad;
                    lblTotal.Text = (Convert.ToDouble(lblTotal.Text) + cantidad * precio).ToString();
                }
            }
            nudCantidad.Value = 1;
            cboArticulos.SelectedIndex = -1;
            btnAgregar.Enabled = false;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDetallesMenu.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Desea borrar las filas seleccionadas?", "Borrar filas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) 
                    == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dgvDetallesMenu.SelectedRows)
                    {
                        double subtotal = Convert.ToDouble(row.Cells["Subtotal"].Value);
                        dgvDetallesMenu.Rows.Remove(row);
                        lblTotal.Text = (Convert.ToDouble(lblTotal.Text) - subtotal).ToString();
                    }
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarNombre())
            {
                if (ValidarGrilla())
                {
                    if (ValidarPrecio())
                    {
                        GuardarMenu();
                    }
                }
            }
        }

        private bool ValidarNombre()
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe ingresar un nombre para el menú.", "Validación de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }

        private bool ValidarGrilla()
        {
            if (dgvDetallesMenu.RowCount == 0)
            {
                MessageBox.Show("No ha seleccionado ningún artículo aún.", "Validación de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }

        private bool ValidarPrecio()
        {
            if (txtPrecio.Text == "")
            {
                MessageBox.Show("Debe ingresar un precio para el menú.", "Validación de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                double precio = 0;
                double.TryParse(txtPrecio.Text, out precio);
                if (precio >= Convert.ToDouble(lblTotal.Text))
                {
                    MessageBox.Show("El precio ingresado es mayor o igual al precio sin promoción. Ingrese un precio menor al monto mostrado.", "Validación de datos",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }
            return true;
        }
        private void GuardarMenu()
        {
            oMenu.IdMenu = oMenu.IdSiguiente();
            oMenu.Nombre = txtNombre.Text;
            oMenu.PrecioUnitario = Convert.ToDouble(txtPrecio.Text);
            oMenu.Borrado = false;
            oMenu.DetallesMenu = GenerarDetalles(oMenu.IdMenu);
            oMenu.Registrar();
            MessageBox.Show("Menú registrado con éxito.", "Nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpiar();
        }
        private DetalleMenu[] GenerarDetalles(int idMenu)
        {
            DetalleMenu[] detalles = new DetalleMenu[dgvDetallesMenu.RowCount - 1];
            int i = 0;
            foreach (DataGridViewRow row in dgvDetallesMenu.Rows)
            {
                DetalleMenu detalle = new DetalleMenu();
                int idArt = Convert.ToInt32(row.Cells["IdArticulo"].Value);
                if (idArt == 0)
                    break;
                detalle.IdArticulo = idArt;
                detalle.IdMenu = idMenu;
                detalle.Cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                detalle.Borrado = false;
                detalles[i] = detalle;
                i++;
            }
            return detalles;
        }

        private void Limpiar()
        {
            txtNombre.Text = "";
            txtPrecio.Text = "";
            lblTotal.Text = "0.00";
            cboTipo.SelectedIndex = -1;
            cboArticulos.DataSource = null;
            nudCantidad.Value = 1;
            btnAgregar.Enabled = false;
            btnBorrar.Enabled = false;
            btnGuardar.Enabled = false;
            dgvDetallesMenu.Rows.Clear();
        }
    }
}

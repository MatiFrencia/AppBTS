﻿using System;
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
    public partial class frmConsultarMenus : Form
    {
        TipoArticulo oTipo = new TipoArticulo();
        Articulo oArticulo = new Articulo();
        Menus oMenu = new Menus();
        DetalleMenu oDetalle = new DetalleMenu();
        public frmConsultarMenus()
        {
            InitializeComponent();
        }

        private void frmConsultarMenus_Load(object sender, EventArgs e)
        {
            CargarCombo(cboTipo, oTipo.RecuperarTodos());
            btnVisualizar.Enabled = false;
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
        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            if (dgvMenus.SelectedRows.Count == 1)
            {
                string idMenu = dgvMenus.SelectedCells[0].Value.ToString();
                CargarGrillaDetalles(dgvDetalles, oDetalle.RecuperarPorMenu(idMenu));
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTodos.Checked)
            {
                cboTipo.Enabled = false;
                cboArticulo.Enabled = false;
                txtIdMenu.Enabled = false;
                txtNombre.Enabled = false;
            }
            else
            {
                cboTipo.Enabled = true;
                cboArticulo.Enabled = true;
                txtIdMenu.Enabled = true;
                txtNombre.Enabled = true;
            }
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipo.SelectedIndex != -1 & cboTipo.ValueMember != "")
            {
                string idSeleccionado = cboTipo.SelectedValue.ToString();
                CargarCombo(cboArticulo, oArticulo.RecuperarFiltrados("", "", idSeleccionado));
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (chkTodos.Checked)
                CargarGrillaMenus(dgvMenus, oMenu.RecuperarTodos());
            else
            {
                string idMenu = txtIdMenu.Text;
                string nombre = txtNombre.Text;
                string idTipoArticulo = "";
                if (cboTipo.SelectedIndex != -1)
                    idTipoArticulo = cboTipo.SelectedValue.ToString();
                string idArticulo = "";
                if (cboArticulo.SelectedIndex != -1)
                    idArticulo = cboArticulo.SelectedValue.ToString();
                CargarGrillaMenus(dgvMenus, oMenu.RecuperarFiltrados(idMenu, nombre, idTipoArticulo, idArticulo));
                cboTipo.SelectedIndex = -1;
                cboArticulo.DataSource = null;
            }
        }
        private void CargarGrillaMenus(DataGridView grilla, DataTable tabla)
        {
            grilla.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["idMenu"],
                                tabla.Rows[i]["nombre"],
                                tabla.Rows[i]["pcioUnitario"]);
            }
        }

        private void CargarGrillaDetalles(DataGridView grilla, DataTable tabla)
        {
            grilla.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["nombreTipo"],
                                tabla.Rows[i]["nombreArticulo"],
                                tabla.Rows[i]["cantidad"]);
            }
        }

        private void dgvMenus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
            btnVisualizar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Menus seleccionado = new Menus();
            string nombre = dgvMenus.SelectedCells[1].Value.ToString();
            if (MessageBox.Show("¿Está seguro de que desea borrar '" + nombre + "'?", "Eliminar Menú",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                seleccionado.IdMenu = Convert.ToInt32(dgvMenus.SelectedCells[0].Value);
                seleccionado.Eliminar();
                MessageBox.Show("'" + nombre + "' eliminado con éxito.");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmAltaMenu fam = new frmAltaMenu();
            fam.ShowDialog();
            fam.Dispose();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmDetalleMenu fdm = new frmDetalleMenu();
            fdm.IdMenu = Convert.ToInt32(dgvMenus.SelectedCells[0].Value);
            fdm.Nombre = dgvMenus.SelectedCells[1].Value.ToString();
            fdm.PcioUnitario = Convert.ToInt32(dgvMenus.SelectedCells[2].Value);
            fdm.Tipos = "Edit";
            fdm.ShowDialog();
            fdm.Dispose();
        }
    }
}

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
    public partial class frmMozos : Form
    {
        Mozo oMozo = new Mozo();
        bool nuevo = false;
        public frmMozos()
        {
            InitializeComponent();
        }
        private void frmMozos_Load(object sender, EventArgs e)
        {
            CargarGrilla(dgvMozos, oMozo.traerTodos());
            buttons(true);
            campos(false);
            vista(false);
        }
        private void buttons(bool x)
        {
            btnAdd.Enabled = x;
            btnEdit.Enabled = x;
            btnDelete.Enabled = x;
            btnExit.Enabled = x;
            btnSave.Enabled = !x;
            btnCancel.Enabled = !x;
            btnSave.Visible = !x;
            btnCancel.Visible = !x;
        }

        private void vista(bool x) {
            if (x)
            {
                this.Width = 650;

                //for (int i = 0; i < 276; i++)
                //{
                //    this.Width += 1;
                //}
            }
            else
            {
                //this.Width = 374;
                for (int i = 0; i < 276; i++)
                {
                    this.Width -= 1;
                }
            }
        }
        private void campos(bool x){
            this.txtId.Enabled = x;
            this.txtNombre.Enabled = x;
            this.txtApellido.Enabled = x;
        }
        private void limpiar() {
            this.txtId.Clear();
            this.txtNombre.Clear();
            this.txtApellido.Clear();
        }
        private void CargarGrilla(DataGridView grilla, DataTable tabla)
        {
            grilla.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["idMozo"],
                                tabla.Rows[i]["nombre"],
                                tabla.Rows[i]["apellido"]);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            limpiar();
            vista(true);
            buttons(false);
            campos(true);
            this.txtId.Focus();
            
            nuevo = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            vista(true);
            buttons(false);
            campos(true);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            vista(true);
            if (MessageBox.Show("Esta seguro de eliminar a: "+txtNombre.Text+" "+txtApellido.Text, "ELIMINANDO", MessageBoxButtons.YesNo,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                oMozo.Eliminar();
            }
            CargarGrilla(dgvMozos, oMozo.traerTodos());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            buttons(true);
            vista(false);
            CargarGrilla(dgvMozos, oMozo.traerTodos());
            //validar
            if (txtId.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar un ID.", "Error en la carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtId.Focus();
            }
            if (txtNombre.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar un Nombre.", "Error en la carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
            }
            if (txtId.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar un Apellido.", "Error en la carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApellido.Focus();
            }
            //oMozo.idMozo = txtId.Text;
            oMozo.nombre = txtNombre.Text;
            oMozo.apellido = txtApellido.Text;
            if (nuevo)
            {
                //instert
            }
            else
            {
                //update
            }
            nuevo = false;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            buttons(true);
            vista(false);
            campos(false);
            this.actualizarCampos((int)dgvMozos.CurrentRow.Cells[0].Value);
            nuevo = false;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro que desea Salir?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                this.Close();
        }

        private void dgvMozos_SelectionChanged(object sender, EventArgs e)
        {
            this.actualizarCampos((int)dgvMozos.CurrentRow.Cells[0].Value);
            vista(true);
        }

        private void actualizarCampos(int id)
        {
            DataTable tabla = new DataTable();
            tabla = oMozo.traerSegunId(id);
            this.txtId.Text = tabla.Rows[0][0].ToString();
            this.txtNombre.Text = tabla.Rows[0][1].ToString();
            this.txtApellido.Text = tabla.Rows[0][2].ToString();
        }
    }
}

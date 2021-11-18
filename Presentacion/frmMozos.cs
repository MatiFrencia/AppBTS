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

namespace AppBTS.Presentacion
{
    public partial class frmMozos : Form
    {
        Mozo oMozo = new Mozo();
        bool nuevo = false;
        MozoService miGestorMozos = new MozoService();
        public frmMozos()
        {
            InitializeComponent();
        }
        private void frmMozos_Load(object sender, EventArgs e)
        {
            CargarGrilla(dgvMozos, miGestorMozos.traerTodos());
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
            this.numeric.Enabled = false;
            this.txtNombre.Enabled = x;
            this.txtApellido.Enabled = x;
        }
        private void limpiar() {
            //ACA ESTA EL ERROR
            this.numeric.Text = "";
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
            this.numeric.Value = miGestorMozos.IdSiguiente();
            campos(true);
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
                miGestorMozos.Eliminar((int)this.numeric.Value);
                CargarGrilla(dgvMozos, miGestorMozos.traerTodos());
            }
            else
            {
                vista(false);
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            buttons(true);
            //vista(false);
            campos(false);
            //validar
            if (txtNombre.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar un Nombre.", "Error en la carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
            }
            else { 
            if (txtApellido.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar un Apellido.", "Error en la carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApellido.Focus();
            }
            else {
                oMozo.idMozo = (int)numeric.Value;
                oMozo.nombre = txtNombre.Text;
                oMozo.apellido = txtApellido.Text;
                if (nuevo)
                {
                        miGestorMozos.Insertar(oMozo.idMozo, oMozo.nombre, oMozo.apellido);
                }
                else
                {
                        miGestorMozos.Modificar(oMozo.idMozo, oMozo.nombre, oMozo.apellido);
                }
                nuevo = false;
                CargarGrilla(dgvMozos, miGestorMozos.traerTodos());
            }
           }
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
            try
            {
                this.actualizarCampos((int)dgvMozos.CurrentRow.Cells[0].Value);
                vista(true);
            }
            catch (Exception)
            {
                limpiar();
            }
        }

        private void actualizarCampos(int id)
        {
            DataTable tabla = new DataTable();
            tabla = miGestorMozos.traerSegunId(id);
            this.numeric.Value = (int)tabla.Rows[0]["idMozo"];
            this.txtNombre.Text = tabla.Rows[0]["nombre"].ToString();
            this.txtApellido.Text = tabla.Rows[0]["apellido"].ToString();
        }
    }
}

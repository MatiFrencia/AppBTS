using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using AppBTS.Negocio;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBTS.Presentacion
{
    public partial class frmRegistrarReserva : Form
    {
        Reservas oReserva = new Reservas();
        Mesas oMesa = new Mesas();
        public frmRegistrarReserva()
        {
            InitializeComponent();
        }

        private void frmRegistrarReserva_Load(object sender, EventArgs e)
        {
            CargarCombo(cboMesa, oMesa.RecuperarTodos());
            dtpReserva.Format = DateTimePickerFormat.Custom;
            dtpReserva.CustomFormat = "dd/MM/yyyy hh:mm";
        }

        private void CargarCombo(ComboBox combo, DataTable tabla)
        {
            combo.DataSource = tabla;
            combo.DisplayMember = tabla.Columns[0].ColumnName;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}

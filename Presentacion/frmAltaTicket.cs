using AppBTS.Entidades;
using AppBTS.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBTS.Presentacion
{
    public partial class frmAgregarDetalles : Form
    {
        private BindingList<DetallesTicket> listaDetallesTickets;
        public frmAgregarDetalles()
        {
            InitializeComponent();
            listaDetallesTickets = new BindingList<DetallesTicket>();
        }

        private void frmAltaTicket_Load(object sender, EventArgs e)
        {
            this.lblFecha.Text = DateTime.Today.ToString("dd/MM/yyyy");
            this.lblHora.Text = DateTime.Now.ToString("T");
            CargarCombo(cboMenus, miGestorMenus.RecuperarTodos(), 1);
            CargarCombo(cboMesas, miGestorMesas.RecuperarTodos(), 0);
            CargarCombo(cboMozos, miGestorMozos.traerTodos(), 1);
            CargarCombo(cboTipoPago, miGestorTpago.RecuperarTodos(), 1);
        }
        private MenuService miGestorMenus = new MenuService();
        private TipoPagoService miGestorTpago = new TipoPagoService();
        private MesasService miGestorMesas = new MesasService();
        private MozoService miGestorMozos = new MozoService();
        private TicketService miGestorTickets = new TicketService();
        private DetallesTicketService miGestorDtickets = new DetallesTicketService();




        private void btnSeleccionarMenu_Click(object sender, EventArgs e)
        {
            frmConsultarMenus fcm = new frmConsultarMenus();
            fcm.ShowDialog();
            fcm.Dispose();
        }
        private void CargarCombo(ComboBox combo, DataTable tabla, int index)
        {
            combo.DataSource = tabla;
            combo.DisplayMember = tabla.Columns[index].ColumnName;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DataTable menu = miGestorMenus.RecuperarFiltrados("", cboMenus.Text, "", "");
            double pcioUnitario = Convert.ToInt32(menu.Rows[0][2]);
            int idMenu = Convert.ToInt32(menu.Rows[0][0]);
            int cantidad = Convert.ToInt32(nmrCant.Text);
            int descuento = Convert.ToInt32(nmrDescuento.Text);
            double parcial = pcioUnitario * cantidad - (descuento * pcioUnitario * cantidad) / 100;


            //Se fija si ya hay un detalle con el artículo elegido que esté cargado en la grilla.
            bool noRepetido = true;
            int repetido = 0;
            for (int i = 0; i < dgvDetalleTicket.Rows.Count; i++)
            {
                if (Convert.ToInt32(dgvDetalleTicket.Rows[i].Cells[0].Value) == idMenu)
                {
                    noRepetido = false;
                    repetido = i;
                    break;
                }
            }
            if (noRepetido)
            {
                //Si no está el artículo ya cargado, agrega el detalle normalmente.
                dgvDetalleTicket.Rows.Add(idMenu, cboMenus.Text, cantidad, pcioUnitario, descuento, parcial);
            }
            else
            {
                //Si ya hay un detalle cargado con ese artículo, pregunta si quiere agregar la cantidad ingresada al detalle ya existente. (Si ya cargué 2 milanesas,
                //y ahora intento cargar 2 más, me pregunta si quiero en realidad cargar 4). Si elige sí, se agregan. Si elige no, queda el detalle como estaba.
                if (MessageBox.Show("Artículo ya agregado en el menú. ¿Desea aumentar la cantidad de este artículo en " + cantidad.ToString() + "?", "Nuevo Menú",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    int nCantidad = Convert.ToInt32(dgvDetalleTicket.Rows[repetido].Cells["Cantidad"].Value) + cantidad;
                    dgvDetalleTicket.Rows[repetido].Cells["Cantidad"].Value = nCantidad;
                    dgvDetalleTicket.Rows[repetido].Cells["Subtotal"].Value = pcioUnitario * nCantidad - (descuento * pcioUnitario * nCantidad) / 100;
                }
            }
            lblTotalCD.Text = "0";
            for (int i = 0; i < dgvDetalleTicket.Rows.Count; i++)
            {
                lblTotalCD.Text = (Convert.ToInt32(lblTotalCD.Text) + Convert.ToInt32(dgvDetalleTicket.Rows[i].Cells["Subtotal"].Value)).ToString();
            }
            listaDetallesTickets.Add(new DetallesTicket()
            {
                IdMenu = idMenu,
                Cantidad = cantidad,
                PcioUnitario = pcioUnitario,
                Descuento = descuento
            });
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDetalleTicket.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Desea borrar las filas seleccionadas?", "Borrar filas", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dgvDetalleTicket.SelectedRows)
                    {
                        double subtotal = Convert.ToDouble(row.Cells["Subtotal"].Value);
                        dgvDetalleTicket.Rows.Remove(row);
                        lblTotalCD.Text = (Convert.ToDouble(lblTotalCD.Text) - subtotal).ToString();
                    }
                }
            }
        }
        private void Limpiar()
        {
            nmrCant.Value = 0;
            nmrDescuento.Value = 0;
            lblTotalCD.Text = "0";
            cboMenus.SelectedIndex = -1;
            cboMesas.SelectedIndex = -1;
            cboMozos.SelectedIndex = -1;
            cboTipoPago.SelectedIndex = -1;
            dgvDetalleTicket.Rows.Clear();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea confirmar esta operación?", "Registrar Cobro",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Ticket ticket = new Ticket();
                ticket.Fecha = DateTime.Today.ToString("yyyy-MM-dd");
                ticket.Hora = DateTime.Now.ToString("T");

                ticket.IdMozo = Convert.ToInt32(cboMozos.SelectedValue);
                ticket.NroMesa = Convert.ToInt32(cboMesas.SelectedValue);
                ticket.Borrado = false;
                ticket.IdTipoPago = Convert.ToInt32(cboTipoPago.SelectedValue);
                ticket.Total = Convert.ToInt32(lblTotalCD.Text);
                ticket.DetallesTickets = listaDetallesTickets;
                miGestorTickets.Registrar(ticket);
                Limpiar();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Si sale, se borrarán los cambios, desea salir?", "Salir",
                         MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }
    }
}


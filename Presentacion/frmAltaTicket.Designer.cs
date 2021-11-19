
namespace AppBTS.Presentacion
{
    partial class frmAgregarDetalles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarDetalles));
            this.lblTicket = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.dgvDetalleTicket = new System.Windows.Forms.DataGridView();
            this.cboMenus = new System.Windows.Forms.ComboBox();
            this.nmrCant = new System.Windows.Forms.NumericUpDown();
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.nmrDescuento = new System.Windows.Forms.NumericUpDown();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalCD = new System.Windows.Forms.Label();
            this.lblMozo = new System.Windows.Forms.Label();
            this.lblMesa = new System.Windows.Forms.Label();
            this.lblTipoPago = new System.Windows.Forms.Label();
            this.cboMozos = new System.Windows.Forms.ComboBox();
            this.cboTipoPago = new System.Windows.Forms.ComboBox();
            this.cboMesas = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.IdArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleTicket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrCant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrDescuento)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTicket
            // 
            this.lblTicket.AutoSize = true;
            this.lblTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblTicket.Location = new System.Drawing.Point(12, 9);
            this.lblTicket.Name = "lblTicket";
            this.lblTicket.Size = new System.Drawing.Size(116, 22);
            this.lblTicket.TabIndex = 0;
            this.lblTicket.Text = "Nuevo Ticket";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(594, 12);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(54, 15);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "lblFecha";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(700, 12);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(47, 15);
            this.lblHora.TabIndex = 4;
            this.lblHora.Text = "lblHora";
            // 
            // dgvDetalleTicket
            // 
            this.dgvDetalleTicket.AllowUserToAddRows = false;
            this.dgvDetalleTicket.AllowUserToDeleteRows = false;
            this.dgvDetalleTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleTicket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdArticulo,
            this.NombreArticulo,
            this.Cantidad,
            this.PrecioUnitario,
            this.descuento,
            this.Subtotal});
            this.dgvDetalleTicket.Location = new System.Drawing.Point(28, 70);
            this.dgvDetalleTicket.Name = "dgvDetalleTicket";
            this.dgvDetalleTicket.ReadOnly = true;
            this.dgvDetalleTicket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleTicket.Size = new System.Drawing.Size(719, 178);
            this.dgvDetalleTicket.TabIndex = 12;
            // 
            // cboMenus
            // 
            this.cboMenus.FormattingEnabled = true;
            this.cboMenus.Location = new System.Drawing.Point(71, 38);
            this.cboMenus.Name = "cboMenus";
            this.cboMenus.Size = new System.Drawing.Size(140, 23);
            this.cboMenus.TabIndex = 13;
            // 
            // nmrCant
            // 
            this.nmrCant.Location = new System.Drawing.Point(296, 39);
            this.nmrCant.Name = "nmrCant";
            this.nmrCant.Size = new System.Drawing.Size(44, 21);
            this.nmrCant.TabIndex = 14;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Location = new System.Drawing.Point(25, 42);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(42, 15);
            this.lblMenu.TabIndex = 15;
            this.lblMenu.Text = "Menu:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(230, 42);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(59, 15);
            this.lblCantidad.TabIndex = 16;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(439, 43);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(88, 15);
            this.lblDescuento.TabIndex = 17;
            this.lblDescuento.Text = "Descuento(%):";
            // 
            // nmrDescuento
            // 
            this.nmrDescuento.Location = new System.Drawing.Point(532, 40);
            this.nmrDescuento.Name = "nmrDescuento";
            this.nmrDescuento.Size = new System.Drawing.Size(47, 21);
            this.nmrDescuento.TabIndex = 18;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(671, 260);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 15);
            this.lblTotal.TabIndex = 21;
            this.lblTotal.Text = "Total:$";
            // 
            // lblTotalCD
            // 
            this.lblTotalCD.AutoSize = true;
            this.lblTotalCD.Location = new System.Drawing.Point(712, 260);
            this.lblTotalCD.Name = "lblTotalCD";
            this.lblTotalCD.Size = new System.Drawing.Size(14, 15);
            this.lblTotalCD.TabIndex = 24;
            this.lblTotalCD.Text = "0";
            // 
            // lblMozo
            // 
            this.lblMozo.AutoSize = true;
            this.lblMozo.Location = new System.Drawing.Point(25, 260);
            this.lblMozo.Name = "lblMozo";
            this.lblMozo.Size = new System.Drawing.Size(41, 15);
            this.lblMozo.TabIndex = 26;
            this.lblMozo.Text = "Mozo:";
            // 
            // lblMesa
            // 
            this.lblMesa.AutoSize = true;
            this.lblMesa.Location = new System.Drawing.Point(236, 260);
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Size = new System.Drawing.Size(51, 15);
            this.lblMesa.TabIndex = 27;
            this.lblMesa.Text = "# Mesa:";
            // 
            // lblTipoPago
            // 
            this.lblTipoPago.AutoSize = true;
            this.lblTipoPago.Location = new System.Drawing.Point(435, 260);
            this.lblTipoPago.Name = "lblTipoPago";
            this.lblTipoPago.Size = new System.Drawing.Size(83, 15);
            this.lblTipoPago.TabIndex = 28;
            this.lblTipoPago.Text = "Tipo de Pago:";
            // 
            // cboMozos
            // 
            this.cboMozos.FormattingEnabled = true;
            this.cboMozos.Location = new System.Drawing.Point(71, 256);
            this.cboMozos.Name = "cboMozos";
            this.cboMozos.Size = new System.Drawing.Size(140, 23);
            this.cboMozos.TabIndex = 32;
            // 
            // cboTipoPago
            // 
            this.cboTipoPago.FormattingEnabled = true;
            this.cboTipoPago.Location = new System.Drawing.Point(525, 256);
            this.cboTipoPago.Name = "cboTipoPago";
            this.cboTipoPago.Size = new System.Drawing.Size(140, 23);
            this.cboTipoPago.TabIndex = 33;
            // 
            // cboMesas
            // 
            this.cboMesas.FormattingEnabled = true;
            this.cboMesas.Location = new System.Drawing.Point(293, 256);
            this.cboMesas.Name = "cboMesas";
            this.cboMesas.Size = new System.Drawing.Size(119, 23);
            this.cboMesas.TabIndex = 34;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.Tan;
            this.btnCancelar.Image = global::AppBTS.Properties.Resources.logout_door;
            this.btnCancelar.Location = new System.Drawing.Point(28, 285);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(45, 45);
            this.btnCancelar.TabIndex = 36;
            this.toolTip1.SetToolTip(this.btnCancelar, "Volver.");
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.Tan;
            this.btnGuardar.Image = global::AppBTS.Properties.Resources.grabar2;
            this.btnGuardar.Location = new System.Drawing.Point(695, 285);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(52, 45);
            this.btnGuardar.TabIndex = 35;
            this.toolTip1.SetToolTip(this.btnGuardar, "Guardar Ticket.");
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.ForeColor = System.Drawing.Color.Tan;
            this.btnBorrar.Image = global::AppBTS.Properties.Resources.Cancelar3;
            this.btnBorrar.Location = new System.Drawing.Point(702, 33);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(44, 33);
            this.btnBorrar.TabIndex = 20;
            this.toolTip1.SetToolTip(this.btnBorrar, "Limpiar campos.");
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.Color.Tan;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(652, 33);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(44, 33);
            this.btnAgregar.TabIndex = 19;
            this.toolTip1.SetToolTip(this.btnAgregar, "Añadir Menú.");
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // IdArticulo
            // 
            this.IdArticulo.HeaderText = "Id del Menú";
            this.IdArticulo.Name = "IdArticulo";
            this.IdArticulo.ReadOnly = true;
            this.IdArticulo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IdArticulo.Width = 50;
            // 
            // NombreArticulo
            // 
            this.NombreArticulo.HeaderText = "Menú";
            this.NombreArticulo.Name = "NombreArticulo";
            this.NombreArticulo.ReadOnly = true;
            this.NombreArticulo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NombreArticulo.Width = 200;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Cantidad.Width = 75;
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.HeaderText = "Precio Unitario";
            this.PrecioUnitario.Name = "PrecioUnitario";
            this.PrecioUnitario.ReadOnly = true;
            this.PrecioUnitario.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PrecioUnitario.Width = 125;
            // 
            // descuento
            // 
            this.descuento.HeaderText = "Descuento";
            this.descuento.Name = "descuento";
            this.descuento.ReadOnly = true;
            this.descuento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            this.Subtotal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Subtotal.Width = 125;
            // 
            // frmAgregarDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(773, 338);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cboMesas);
            this.Controls.Add(this.cboTipoPago);
            this.Controls.Add(this.cboMozos);
            this.Controls.Add(this.lblTipoPago);
            this.Controls.Add(this.lblMesa);
            this.Controls.Add(this.lblMozo);
            this.Controls.Add(this.lblTotalCD);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.nmrDescuento);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.nmrCant);
            this.Controls.Add(this.cboMenus);
            this.Controls.Add(this.dgvDetalleTicket);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblTicket);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAgregarDetalles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ticket";
            this.Load += new System.EventHandler(this.frmAltaTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleTicket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrCant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrDescuento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTicket;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.DataGridView dgvDetalleTicket;
        private System.Windows.Forms.ComboBox cboMenus;
        private System.Windows.Forms.NumericUpDown nmrCant;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.NumericUpDown nmrDescuento;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalCD;
        private System.Windows.Forms.Label lblMozo;
        private System.Windows.Forms.Label lblMesa;
        private System.Windows.Forms.Label lblTipoPago;
        private System.Windows.Forms.ComboBox cboMozos;
        private System.Windows.Forms.ComboBox cboTipoPago;
        private System.Windows.Forms.ComboBox cboMesas;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
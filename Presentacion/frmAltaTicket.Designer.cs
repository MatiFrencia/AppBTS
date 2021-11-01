
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarDetalles));
            this.lblTicket = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.dgvDetalleTicket = new System.Windows.Forms.DataGridView();
            this.IdArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleTicket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrCant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrDescuento)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTicket
            // 
            this.lblTicket.AutoSize = true;
            this.lblTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblTicket.Location = new System.Drawing.Point(24, 9);
            this.lblTicket.Name = "lblTicket";
            this.lblTicket.Size = new System.Drawing.Size(116, 22);
            this.lblTicket.TabIndex = 0;
            this.lblTicket.Text = "Nuevo Ticket";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(604, 18);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(47, 13);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "lblFecha";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(695, 18);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(40, 13);
            this.lblHora.TabIndex = 4;
            this.lblHora.Text = "lblHora";
            // 
            // dgvDetalleTicket
            // 
            this.dgvDetalleTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleTicket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdArticulo,
            this.NombreArticulo,
            this.Cantidad,
            this.PrecioUnitario,
            this.descuento,
            this.Subtotal});
            this.dgvDetalleTicket.Location = new System.Drawing.Point(28, 135);
            this.dgvDetalleTicket.Name = "dgvDetalleTicket";
            this.dgvDetalleTicket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleTicket.Size = new System.Drawing.Size(707, 154);
            this.dgvDetalleTicket.TabIndex = 12;
            // 
            // IdArticulo
            // 
            this.IdArticulo.HeaderText = "Id del Menú";
            this.IdArticulo.Name = "IdArticulo";
            this.IdArticulo.ReadOnly = true;
            this.IdArticulo.Width = 50;
            // 
            // NombreArticulo
            // 
            this.NombreArticulo.HeaderText = "Menú";
            this.NombreArticulo.Name = "NombreArticulo";
            this.NombreArticulo.ReadOnly = true;
            this.NombreArticulo.Width = 200;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 75;
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.HeaderText = "Precio Unitario";
            this.PrecioUnitario.Name = "PrecioUnitario";
            this.PrecioUnitario.ReadOnly = true;
            this.PrecioUnitario.Width = 125;
            // 
            // descuento
            // 
            this.descuento.HeaderText = "Descuento";
            this.descuento.Name = "descuento";
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            this.Subtotal.Width = 125;
            // 
            // cboMenus
            // 
            this.cboMenus.FormattingEnabled = true;
            this.cboMenus.Location = new System.Drawing.Point(51, 67);
            this.cboMenus.Name = "cboMenus";
            this.cboMenus.Size = new System.Drawing.Size(121, 21);
            this.cboMenus.TabIndex = 13;
            // 
            // nmrCant
            // 
            this.nmrCant.Location = new System.Drawing.Point(242, 68);
            this.nmrCant.Name = "nmrCant";
            this.nmrCant.Size = new System.Drawing.Size(38, 20);
            this.nmrCant.TabIndex = 14;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Location = new System.Drawing.Point(11, 70);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(37, 13);
            this.lblMenu.TabIndex = 15;
            this.lblMenu.Text = "Menu:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(185, 70);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 16;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(297, 70);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(76, 13);
            this.lblDescuento.TabIndex = 17;
            this.lblDescuento.Text = "Descuento(%):";
            // 
            // nmrDescuento
            // 
            this.nmrDescuento.Location = new System.Drawing.Point(376, 67);
            this.nmrDescuento.Name = "nmrDescuento";
            this.nmrDescuento.Size = new System.Drawing.Size(40, 20);
            this.nmrDescuento.TabIndex = 18;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(25, 313);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(40, 13);
            this.lblTotal.TabIndex = 21;
            this.lblTotal.Text = "Total:$";
            // 
            // lblTotalCD
            // 
            this.lblTotalCD.AutoSize = true;
            this.lblTotalCD.Location = new System.Drawing.Point(71, 313);
            this.lblTotalCD.Name = "lblTotalCD";
            this.lblTotalCD.Size = new System.Drawing.Size(13, 13);
            this.lblTotalCD.TabIndex = 24;
            this.lblTotalCD.Text = "0";
            // 
            // lblMozo
            // 
            this.lblMozo.AutoSize = true;
            this.lblMozo.Location = new System.Drawing.Point(28, 361);
            this.lblMozo.Name = "lblMozo";
            this.lblMozo.Size = new System.Drawing.Size(36, 13);
            this.lblMozo.TabIndex = 26;
            this.lblMozo.Text = "Mozo:";
            // 
            // lblMesa
            // 
            this.lblMesa.AutoSize = true;
            this.lblMesa.Location = new System.Drawing.Point(218, 361);
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Size = new System.Drawing.Size(46, 13);
            this.lblMesa.TabIndex = 27;
            this.lblMesa.Text = "# Mesa:";
            // 
            // lblTipoPago
            // 
            this.lblTipoPago.AutoSize = true;
            this.lblTipoPago.Location = new System.Drawing.Point(402, 361);
            this.lblTipoPago.Name = "lblTipoPago";
            this.lblTipoPago.Size = new System.Drawing.Size(74, 13);
            this.lblTipoPago.TabIndex = 28;
            this.lblTipoPago.Text = "Tipo de Pago:";
            // 
            // cboMozos
            // 
            this.cboMozos.FormattingEnabled = true;
            this.cboMozos.Location = new System.Drawing.Point(67, 358);
            this.cboMozos.Name = "cboMozos";
            this.cboMozos.Size = new System.Drawing.Size(121, 21);
            this.cboMozos.TabIndex = 32;
            // 
            // cboTipoPago
            // 
            this.cboTipoPago.FormattingEnabled = true;
            this.cboTipoPago.Location = new System.Drawing.Point(479, 358);
            this.cboTipoPago.Name = "cboTipoPago";
            this.cboTipoPago.Size = new System.Drawing.Size(121, 21);
            this.cboTipoPago.TabIndex = 33;
            // 
            // cboMesas
            // 
            this.cboMesas.FormattingEnabled = true;
            this.cboMesas.Location = new System.Drawing.Point(267, 358);
            this.cboMesas.Name = "cboMesas";
            this.cboMesas.Size = new System.Drawing.Size(103, 21);
            this.cboMesas.TabIndex = 34;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::AppBTS.Properties.Resources.logout_door;
            this.btnCancelar.Location = new System.Drawing.Point(674, 399);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(39, 39);
            this.btnCancelar.TabIndex = 36;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::AppBTS.Properties.Resources.grabar2;
            this.btnGuardar.Location = new System.Drawing.Point(606, 399);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(45, 39);
            this.btnGuardar.TabIndex = 35;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Image = global::AppBTS.Properties.Resources.delete_exit;
            this.btnBorrar.Location = new System.Drawing.Point(490, 62);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(29, 28);
            this.btnBorrar.TabIndex = 20;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(446, 62);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(29, 28);
            this.btnAgregar.TabIndex = 19;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // frmAgregarDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(754, 450);
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
            this.Name = "frmAgregarDetalles";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn IdArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
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
    }
}
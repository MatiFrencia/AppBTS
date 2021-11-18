namespace AppBTS.Presentacion
{
    partial class frmConsultaReservas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaReservas));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpHoraHasta = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpHoraDesde = new System.Windows.Forms.DateTimePicker();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.txtHora = new System.Windows.Forms.Label();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.nroReserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroMesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaReserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaReserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadComensales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.cboComensales = new System.Windows.Forms.ComboBox();
            this.cboTelefono = new System.Windows.Forms.ComboBox();
            this.cboNombreCliente = new System.Windows.Forms.ComboBox();
            this.cboNroMesa = new System.Windows.Forms.ComboBox();
            this.cboNroReserva = new System.Windows.Forms.ComboBox();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bugsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterDataSet = new AppBTS.masterDataSet();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.bugsTableAdapter = new AppBTS.masterDataSetTableAdapters.BugsTableAdapter();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Tan;
            this.groupBox1.Controls.Add(this.dtpHoraHasta);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dtpHoraDesde);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.lblFechaDesde);
            this.groupBox1.Controls.Add(this.lblFechaHasta);
            this.groupBox1.Controls.Add(this.txtHora);
            this.groupBox1.Controls.Add(this.dgvReservas);
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Controls.Add(this.cboComensales);
            this.groupBox1.Controls.Add(this.cboTelefono);
            this.groupBox1.Controls.Add(this.cboNombreCliente);
            this.groupBox1.Controls.Add(this.cboNroMesa);
            this.groupBox1.Controls.Add(this.cboNroReserva);
            this.groupBox1.Controls.Add(this.dtpFechaHasta);
            this.groupBox1.Controls.Add(this.dtpFechaDesde);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(894, 517);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criterios";
            // 
            // dtpHoraHasta
            // 
            this.dtpHoraHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHoraHasta.Location = new System.Drawing.Point(705, 64);
            this.dtpHoraHasta.Margin = new System.Windows.Forms.Padding(4);
            this.dtpHoraHasta.Name = "dtpHoraHasta";
            this.dtpHoraHasta.Size = new System.Drawing.Size(177, 22);
            this.dtpHoraHasta.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(612, 64);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "Hora Hasta:";
            // 
            // dtpHoraDesde
            // 
            this.dtpHoraDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHoraDesde.Location = new System.Drawing.Point(201, 64);
            this.dtpHoraDesde.Margin = new System.Windows.Forms.Padding(4);
            this.dtpHoraDesde.Name = "dtpHoraDesde";
            this.dtpHoraDesde.Size = new System.Drawing.Size(177, 22);
            this.dtpHoraDesde.TabIndex = 23;
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(828, 184);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(36, 35);
            this.btnClear.TabIndex = 22;
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(100, 38);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(93, 16);
            this.lblFechaDesde.TabIndex = 21;
            this.lblFechaDesde.Text = "Fecha Desde:";
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(604, 38);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(88, 16);
            this.lblFechaHasta.TabIndex = 20;
            this.lblFechaHasta.Text = "Fecha Hasta:";
            // 
            // txtHora
            // 
            this.txtHora.AutoSize = true;
            this.txtHora.Location = new System.Drawing.Point(108, 64);
            this.txtHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(85, 16);
            this.txtHora.TabIndex = 17;
            this.txtHora.Text = "Hora Desde:";
            // 
            // dgvReservas
            // 
            this.dgvReservas.AllowUserToAddRows = false;
            this.dgvReservas.AllowUserToDeleteRows = false;
            this.dgvReservas.BackgroundColor = System.Drawing.Color.Tan;
            this.dgvReservas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nroReserva,
            this.nroMesa,
            this.fechaReserva,
            this.horaReserva,
            this.nombreCliente,
            this.telefono,
            this.cantidadComensales,
            this.borrado});
            this.dgvReservas.Location = new System.Drawing.Point(5, 226);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.ReadOnly = true;
            this.dgvReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservas.Size = new System.Drawing.Size(887, 267);
            this.dgvReservas.TabIndex = 15;
            this.dgvReservas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservas_CellClick);
            // 
            // nroReserva
            // 
            this.nroReserva.HeaderText = "# Reserva";
            this.nroReserva.Name = "nroReserva";
            this.nroReserva.ReadOnly = true;
            this.nroReserva.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nroReserva.Width = 80;
            // 
            // nroMesa
            // 
            this.nroMesa.HeaderText = "# Mesa";
            this.nroMesa.Name = "nroMesa";
            this.nroMesa.ReadOnly = true;
            this.nroMesa.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nroMesa.Width = 80;
            // 
            // fechaReserva
            // 
            this.fechaReserva.HeaderText = "Fecha de Reserva";
            this.fechaReserva.Name = "fechaReserva";
            this.fechaReserva.ReadOnly = true;
            this.fechaReserva.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // horaReserva
            // 
            this.horaReserva.HeaderText = "Hora de Reserva";
            this.horaReserva.Name = "horaReserva";
            this.horaReserva.ReadOnly = true;
            this.horaReserva.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // nombreCliente
            // 
            this.nombreCliente.HeaderText = "Cliente";
            this.nombreCliente.Name = "nombreCliente";
            this.nombreCliente.ReadOnly = true;
            this.nombreCliente.Width = 150;
            // 
            // telefono
            // 
            this.telefono.HeaderText = "Telefono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.telefono.Width = 150;
            // 
            // cantidadComensales
            // 
            this.cantidadComensales.HeaderText = "Comensales";
            this.cantidadComensales.Name = "cantidadComensales";
            this.cantidadComensales.ReadOnly = true;
            this.cantidadComensales.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // borrado
            // 
            this.borrado.HeaderText = "Borrado";
            this.borrado.Name = "borrado";
            this.borrado.ReadOnly = true;
            this.borrado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.borrado.Width = 80;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.Tan;
            this.btnConsultar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.Image")));
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(687, 184);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(134, 35);
            this.btnConsultar.TabIndex = 14;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // cboComensales
            // 
            this.cboComensales.BackColor = System.Drawing.Color.Tan;
            this.cboComensales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboComensales.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboComensales.FormattingEnabled = true;
            this.cboComensales.Location = new System.Drawing.Point(704, 137);
            this.cboComensales.Margin = new System.Windows.Forms.Padding(4);
            this.cboComensales.Name = "cboComensales";
            this.cboComensales.Size = new System.Drawing.Size(177, 24);
            this.cboComensales.TabIndex = 6;
            // 
            // cboTelefono
            // 
            this.cboTelefono.BackColor = System.Drawing.Color.Tan;
            this.cboTelefono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTelefono.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboTelefono.FormattingEnabled = true;
            this.cboTelefono.Location = new System.Drawing.Point(704, 96);
            this.cboTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.cboTelefono.Name = "cboTelefono";
            this.cboTelefono.Size = new System.Drawing.Size(177, 24);
            this.cboTelefono.TabIndex = 5;
            // 
            // cboNombreCliente
            // 
            this.cboNombreCliente.BackColor = System.Drawing.Color.Tan;
            this.cboNombreCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboNombreCliente.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboNombreCliente.FormattingEnabled = true;
            this.cboNombreCliente.Location = new System.Drawing.Point(201, 169);
            this.cboNombreCliente.Margin = new System.Windows.Forms.Padding(4);
            this.cboNombreCliente.Name = "cboNombreCliente";
            this.cboNombreCliente.Size = new System.Drawing.Size(177, 24);
            this.cboNombreCliente.TabIndex = 4;
            // 
            // cboNroMesa
            // 
            this.cboNroMesa.BackColor = System.Drawing.Color.Tan;
            this.cboNroMesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboNroMesa.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboNroMesa.FormattingEnabled = true;
            this.cboNroMesa.Location = new System.Drawing.Point(201, 137);
            this.cboNroMesa.Margin = new System.Windows.Forms.Padding(4);
            this.cboNroMesa.Name = "cboNroMesa";
            this.cboNroMesa.Size = new System.Drawing.Size(177, 24);
            this.cboNroMesa.TabIndex = 3;
            // 
            // cboNroReserva
            // 
            this.cboNroReserva.BackColor = System.Drawing.Color.Tan;
            this.cboNroReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboNroReserva.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboNroReserva.FormattingEnabled = true;
            this.cboNroReserva.Location = new System.Drawing.Point(201, 96);
            this.cboNroReserva.Margin = new System.Windows.Forms.Padding(4);
            this.cboNroReserva.Name = "cboNroReserva";
            this.cboNroReserva.Size = new System.Drawing.Size(177, 24);
            this.cboNroReserva.TabIndex = 2;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.CalendarMonthBackground = System.Drawing.SystemColors.WindowFrame;
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(704, 32);
            this.dtpFechaHasta.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(177, 22);
            this.dtpFechaHasta.TabIndex = 1;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(201, 34);
            this.dtpFechaDesde.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(177, 22);
            this.dtpFechaDesde.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(606, 141);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Comensales:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(627, 102);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telefono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 173);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nombre Cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "# Mesa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "# Reserva:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, -3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "Criterios";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 19;
            // 
            // bugsBindingSource
            // 
            this.bugsBindingSource.DataMember = "Bugs";
            this.bugsBindingSource.DataSource = this.masterDataSet;
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Tan;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(21, 566);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(72, 56);
            this.btnNuevo.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnNuevo, "Nuevo");
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnAsignar
            // 
            this.btnAsignar.Image = global::AppBTS.Properties.Resources.new_add_user;
            this.btnAsignar.Location = new System.Drawing.Point(103, 416);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(72, 56);
            this.btnAsignar.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnAsignar, "Asignar");
            this.btnAsignar.UseVisualStyleBackColor = true;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbTitle.Location = new System.Drawing.Point(16, 11);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(111, 25);
            this.lbTitle.TabIndex = 18;
            this.lbTitle.Text = "Reservas";
            // 
            // bugsTableAdapter
            // 
            this.bugsTableAdapter.ClearBeforeFill = true;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Tan;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Image = global::AppBTS.Properties.Resources.logout_door;
            this.btnSalir.Location = new System.Drawing.Point(840, 574);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(53, 40);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBorrar.FlatAppearance.BorderColor = System.Drawing.Color.Sienna;
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Image = global::AppBTS.Properties.Resources.delete_exit;
            this.btnBorrar.Location = new System.Drawing.Point(251, 577);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(0);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(53, 40);
            this.btnBorrar.TabIndex = 3;
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.Color.Tan;
            this.btnEditar.Image = global::AppBTS.Properties.Resources.documentediting;
            this.btnEditar.Location = new System.Drawing.Point(135, 574);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(53, 40);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnDetalle
            // 
            this.btnDetalle.FlatAppearance.BorderSize = 0;
            this.btnDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalle.Image = global::AppBTS.Properties.Resources.search_file;
            this.btnDetalle.Location = new System.Drawing.Point(446, 574);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(53, 40);
            this.btnDetalle.TabIndex = 4;
            this.btnDetalle.UseVisualStyleBackColor = false;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // frmConsultaReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(914, 621);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(300, 100);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmConsultaReservas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Consulta General de Bugs";
            this.Load += new System.EventHandler(this.frmConsultaReservas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ComboBox cboComensales;
        private System.Windows.Forms.ComboBox cboTelefono;
        private System.Windows.Forms.ComboBox cboNombreCliente;
        private System.Windows.Forms.ComboBox cboNroMesa;
        private System.Windows.Forms.ComboBox cboNroReserva;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolTip toolTip1;
        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource bugsBindingSource;
        private masterDataSetTableAdapters.BugsTableAdapter bugsTableAdapter;
        private System.Windows.Forms.Label txtHora;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DateTimePicker dtpHoraDesde;
        private System.Windows.Forms.DateTimePicker dtpHoraHasta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroMesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadComensales;
        private System.Windows.Forms.DataGridViewCheckBoxColumn borrado;
    }
}
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
            this.txtHora = new System.Windows.Forms.Label();
            this.cboHora = new System.Windows.Forms.ComboBox();
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.bugsTableAdapter = new AppBTS.masterDataSetTableAdapters.BugsTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtHora);
            this.groupBox1.Controls.Add(this.cboHora);
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
            this.groupBox1.Location = new System.Drawing.Point(10, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(778, 401);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criterios";
            // 
            // txtHora
            // 
            this.txtHora.AutoSize = true;
            this.txtHora.Location = new System.Drawing.Point(467, 126);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(33, 13);
            this.txtHora.TabIndex = 17;
            this.txtHora.Text = "Hora:";
            // 
            // cboHora
            // 
            this.cboHora.BackColor = System.Drawing.Color.DarkKhaki;
            this.cboHora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboHora.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboHora.FormattingEnabled = true;
            this.cboHora.Location = new System.Drawing.Point(528, 118);
            this.cboHora.Name = "cboHora";
            this.cboHora.Size = new System.Drawing.Size(134, 21);
            this.cboHora.TabIndex = 16;
            // 
            // dgvReservas
            // 
            this.dgvReservas.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
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
            this.dgvReservas.Location = new System.Drawing.Point(6, 186);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservas.Size = new System.Drawing.Size(766, 210);
            this.dgvReservas.TabIndex = 15;
            // 
            // nroReserva
            // 
            this.nroReserva.HeaderText = "# Reserva";
            this.nroReserva.Name = "nroReserva";
            this.nroReserva.Width = 60;
            // 
            // nroMesa
            // 
            this.nroMesa.HeaderText = "# Mesa";
            this.nroMesa.Name = "nroMesa";
            this.nroMesa.Width = 60;
            // 
            // fechaReserva
            // 
            this.fechaReserva.HeaderText = "Fecha de Reserva";
            this.fechaReserva.Name = "fechaReserva";
            // 
            // horaReserva
            // 
            this.horaReserva.HeaderText = "Hora de Reserva";
            this.horaReserva.Name = "horaReserva";
            // 
            // nombreCliente
            // 
            this.nombreCliente.HeaderText = "Cliente";
            this.nombreCliente.Name = "nombreCliente";
            // 
            // telefono
            // 
            this.telefono.HeaderText = "telefono";
            this.telefono.Name = "telefono";
            this.telefono.Width = 150;
            // 
            // cantidadComensales
            // 
            this.cantidadComensales.HeaderText = "Comensales";
            this.cantidadComensales.Name = "cantidadComensales";
            // 
            // borrado
            // 
            this.borrado.HeaderText = "Borrado";
            this.borrado.Name = "borrado";
            this.borrado.Width = 50;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnConsultar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.Image")));
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(528, 145);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(134, 35);
            this.btnConsultar.TabIndex = 14;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // cboComensales
            // 
            this.cboComensales.BackColor = System.Drawing.Color.DarkKhaki;
            this.cboComensales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboComensales.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboComensales.FormattingEnabled = true;
            this.cboComensales.Location = new System.Drawing.Point(528, 91);
            this.cboComensales.Name = "cboComensales";
            this.cboComensales.Size = new System.Drawing.Size(134, 21);
            this.cboComensales.TabIndex = 13;
            // 
            // cboTelefono
            // 
            this.cboTelefono.BackColor = System.Drawing.Color.DarkKhaki;
            this.cboTelefono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTelefono.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboTelefono.FormattingEnabled = true;
            this.cboTelefono.Location = new System.Drawing.Point(528, 60);
            this.cboTelefono.Name = "cboTelefono";
            this.cboTelefono.Size = new System.Drawing.Size(134, 21);
            this.cboTelefono.TabIndex = 12;
            // 
            // cboNombreCliente
            // 
            this.cboNombreCliente.BackColor = System.Drawing.Color.DarkKhaki;
            this.cboNombreCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboNombreCliente.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboNombreCliente.FormattingEnabled = true;
            this.cboNombreCliente.Location = new System.Drawing.Point(151, 134);
            this.cboNombreCliente.Name = "cboNombreCliente";
            this.cboNombreCliente.Size = new System.Drawing.Size(134, 21);
            this.cboNombreCliente.TabIndex = 11;
            // 
            // cboNroMesa
            // 
            this.cboNroMesa.BackColor = System.Drawing.Color.DarkKhaki;
            this.cboNroMesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboNroMesa.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboNroMesa.FormattingEnabled = true;
            this.cboNroMesa.Location = new System.Drawing.Point(151, 98);
            this.cboNroMesa.Name = "cboNroMesa";
            this.cboNroMesa.Size = new System.Drawing.Size(134, 21);
            this.cboNroMesa.TabIndex = 10;
            // 
            // cboNroReserva
            // 
            this.cboNroReserva.BackColor = System.Drawing.Color.DarkKhaki;
            this.cboNroReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboNroReserva.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboNroReserva.FormattingEnabled = true;
            this.cboNroReserva.Location = new System.Drawing.Point(151, 62);
            this.cboNroReserva.Name = "cboNroReserva";
            this.cboNroReserva.Size = new System.Drawing.Size(134, 21);
            this.cboNroReserva.TabIndex = 9;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.CalendarMonthBackground = System.Drawing.SystemColors.WindowFrame;
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(528, 26);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(134, 20);
            this.dtpFechaHasta.TabIndex = 8;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(151, 27);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(134, 20);
            this.dtpFechaDesde.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(433, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Comensales:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(448, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telefono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nombre Cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "# Mesa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "# Reserva:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(429, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha Hasta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Desde:";
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
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Image = global::AppBTS.Properties.Resources.logout_door;
            this.btnSalir.Location = new System.Drawing.Point(716, 416);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(72, 56);
            this.btnSalir.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnSalir, "Salir");
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnDetalle
            // 
            this.btnDetalle.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnDetalle.FlatAppearance.BorderSize = 0;
            this.btnDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalle.Image = ((System.Drawing.Image)(resources.GetObject("btnDetalle.Image")));
            this.btnDetalle.Location = new System.Drawing.Point(377, 416);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(72, 56);
            this.btnDetalle.TabIndex = 4;
            this.btnDetalle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnDetalle, "Detalle de Bugs");
            this.btnDetalle.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(184, 416);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(72, 56);
            this.btnEditar.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnEditar, "Editar");
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnAsignar
            // 
            this.btnAsignar.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnAsignar.FlatAppearance.BorderSize = 0;
            this.btnAsignar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignar.Image = global::AppBTS.Properties.Resources.new_add_user;
            this.btnAsignar.Location = new System.Drawing.Point(103, 416);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(72, 56);
            this.btnAsignar.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnAsignar, "Asignar");
            this.btnAsignar.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(22, 416);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(72, 56);
            this.btnNuevo.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnNuevo, "Nuevo");
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // bugsTableAdapter
            // 
            this.bugsTableAdapter.ClearBeforeFill = true;
            // 
            // frmConsultaReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(796, 481);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmConsultaReservas";
            this.Text = "Consulta General de Bugs";
            this.Load += new System.EventHandler(this.frmConsultaBugs_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.ComboBox cboHora;
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

namespace AppBTS.Presentacion
{
    partial class frmReporteTickets
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteTickets));
            this.dtTicketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTickets = new AppBTS.Reportes.dsTickets();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtpHoraHasta = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpHoraDesde = new System.Windows.Forms.DateTimePicker();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.txtHora = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.cboTipoPago = new System.Windows.Forms.ComboBox();
            this.cboMozo = new System.Windows.Forms.ComboBox();
            this.cboNroMesa = new System.Windows.Forms.ComboBox();
            this.cboNroTicket = new System.Windows.Forms.ComboBox();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.nmrDesde = new System.Windows.Forms.TextBox();
            this.nmrHasta = new System.Windows.Forms.TextBox();
            this.dtTicketsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTickets = new AppBTS.Reportes.dsTickets();
            ((System.ComponentModel.ISupportInitialize)(this.dtTicketsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrDesde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrHasta)).BeginInit();
            this.SuspendLayout();
            // 
            // dtTicketBindingSource
            // 
            this.dtTicketBindingSource.DataMember = "dtTicket";
            this.dtTicketBindingSource.DataSource = this.dsTickets;
            // 
            // dsTickets
            // 
            this.dsTickets.DataSetName = "dsTickets";
            this.dsTickets.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dtTicketsBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.dtTicketsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AppBTS.Reportes.rptTickets.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 259);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(690, 371);
            this.reportViewer1.TabIndex = 0;
            // 
            // dtpHoraHasta
            // 
            this.dtpHoraHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHoraHasta.Location = new System.Drawing.Point(505, 96);
            this.dtpHoraHasta.Margin = new System.Windows.Forms.Padding(4);
            this.dtpHoraHasta.Name = "dtpHoraHasta";
            this.dtpHoraHasta.Size = new System.Drawing.Size(177, 20);
            this.dtpHoraHasta.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label8.Location = new System.Drawing.Point(412, 96);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 16);
            this.label8.TabIndex = 44;
            this.label8.Text = "Hora Hasta:";
            // 
            // dtpHoraDesde
            // 
            this.dtpHoraDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHoraDesde.Location = new System.Drawing.Point(125, 96);
            this.dtpHoraDesde.Margin = new System.Windows.Forms.Padding(4);
            this.dtpHoraDesde.Name = "dtpHoraDesde";
            this.dtpHoraDesde.Size = new System.Drawing.Size(177, 20);
            this.dtpHoraDesde.TabIndex = 43;
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(646, 218);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(36, 35);
            this.btnClear.TabIndex = 42;
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblFechaDesde.Location = new System.Drawing.Point(24, 72);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(93, 16);
            this.lblFechaDesde.TabIndex = 41;
            this.lblFechaDesde.Text = "Fecha Desde:";
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblFechaHasta.Location = new System.Drawing.Point(405, 72);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(88, 16);
            this.lblFechaHasta.TabIndex = 40;
            this.lblFechaHasta.Text = "Fecha Hasta:";
            // 
            // txtHora
            // 
            this.txtHora.AutoSize = true;
            this.txtHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtHora.Location = new System.Drawing.Point(32, 96);
            this.txtHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(85, 16);
            this.txtHora.TabIndex = 39;
            this.txtHora.Text = "Hora Desde:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.Tan;
            this.btnConsultar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.Image")));
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(505, 217);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(134, 35);
            this.btnConsultar.TabIndex = 38;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click_1);
            // 
            // cboTipoPago
            // 
            this.cboTipoPago.BackColor = System.Drawing.Color.Tan;
            this.cboTipoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipoPago.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboTipoPago.FormattingEnabled = true;
            this.cboTipoPago.Location = new System.Drawing.Point(505, 154);
            this.cboTipoPago.Margin = new System.Windows.Forms.Padding(4);
            this.cboTipoPago.Name = "cboTipoPago";
            this.cboTipoPago.Size = new System.Drawing.Size(177, 21);
            this.cboTipoPago.TabIndex = 35;
            // 
            // cboMozo
            // 
            this.cboMozo.BackColor = System.Drawing.Color.Tan;
            this.cboMozo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboMozo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboMozo.FormattingEnabled = true;
            this.cboMozo.Location = new System.Drawing.Point(505, 188);
            this.cboMozo.Margin = new System.Windows.Forms.Padding(4);
            this.cboMozo.Name = "cboMozo";
            this.cboMozo.Size = new System.Drawing.Size(177, 21);
            this.cboMozo.TabIndex = 33;
            // 
            // cboNroMesa
            // 
            this.cboNroMesa.BackColor = System.Drawing.Color.Tan;
            this.cboNroMesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboNroMesa.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboNroMesa.FormattingEnabled = true;
            this.cboNroMesa.Location = new System.Drawing.Point(125, 189);
            this.cboNroMesa.Margin = new System.Windows.Forms.Padding(4);
            this.cboNroMesa.Name = "cboNroMesa";
            this.cboNroMesa.Size = new System.Drawing.Size(177, 21);
            this.cboNroMesa.TabIndex = 30;
            // 
            // cboNroTicket
            // 
            this.cboNroTicket.BackColor = System.Drawing.Color.Tan;
            this.cboNroTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboNroTicket.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboNroTicket.FormattingEnabled = true;
            this.cboNroTicket.Location = new System.Drawing.Point(125, 154);
            this.cboNroTicket.Margin = new System.Windows.Forms.Padding(4);
            this.cboNroTicket.Name = "cboNroTicket";
            this.cboNroTicket.Size = new System.Drawing.Size(177, 21);
            this.cboNroTicket.TabIndex = 29;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.CalendarMonthBackground = System.Drawing.SystemColors.WindowFrame;
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(505, 66);
            this.dtpFechaHasta.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(177, 20);
            this.dtpFechaHasta.TabIndex = 27;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(125, 68);
            this.dtpFechaDesde.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(177, 20);
            this.dtpFechaDesde.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label7.Location = new System.Drawing.Point(54, 127);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 36;
            this.label7.Text = "$ Desde:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label6.Location = new System.Drawing.Point(399, 159);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 16);
            this.label6.TabIndex = 34;
            this.label6.Text = "Tipo de Pago:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.Location = new System.Drawing.Point(448, 189);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "Mozo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.Location = new System.Drawing.Point(60, 194);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "# Mesa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.Location = new System.Drawing.Point(54, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "# Ticket :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 37);
            this.label1.TabIndex = 46;
            this.label1.Text = "Reporte Tickets";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(435, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 47;
            this.label2.Text = "$ Hasta:";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Tan;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Image = global::AppBTS.Properties.Resources.logout_door;
            this.btnSalir.Location = new System.Drawing.Point(646, 639);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(53, 40);
            this.btnSalir.TabIndex = 50;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // nmrDesde
            // 
            this.nmrDesde.Location = new System.Drawing.Point(125, 122);
            this.nmrDesde.Name = "nmrDesde";
            this.nmrDesde.Size = new System.Drawing.Size(177, 20);
            this.nmrDesde.TabIndex = 51;
            // 
            // nmrHasta
            // 
            this.nmrHasta.Location = new System.Drawing.Point(505, 123);
            this.nmrHasta.Name = "nmrHasta";
            this.nmrHasta.Size = new System.Drawing.Size(177, 20);
            this.nmrHasta.TabIndex = 52;
            // 
            // dtTicketsBindingSource
            // 
            this.dtTicketsBindingSource.DataMember = "dtTickets";
            this.dtTicketsBindingSource.DataSource = this.dsTickets;
            // 
            // dsTickets
            // 
            this.dsTickets.DataSetName = "dsTickets";
            this.dsTickets.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmReporteTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(714, 691);
            this.Controls.Add(this.nmrHasta);
            this.Controls.Add(this.nmrDesde);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpHoraHasta);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpHoraDesde);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblFechaDesde);
            this.Controls.Add(this.lblFechaHasta);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.cboTipoPago);
            this.Controls.Add(this.cboMozo);
            this.Controls.Add(this.cboNroMesa);
            this.Controls.Add(this.cboNroTicket);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReporteTickets";
            this.Text = "frmReporteTickets";
            this.Load += new System.EventHandler(this.frmReporteTickets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtTicketsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTickets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.DateTimePicker dtpHoraHasta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpHoraDesde;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.Label txtHora;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ComboBox cboTipoPago;
        private System.Windows.Forms.ComboBox cboMozo;
        private System.Windows.Forms.ComboBox cboNroMesa;
        private System.Windows.Forms.ComboBox cboNroTicket;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Reportes.dsTickets dsTickets;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox nmrDesde;
        private System.Windows.Forms.TextBox nmrHasta;
        private System.Windows.Forms.BindingSource dtTicketsBindingSource;
    }
}
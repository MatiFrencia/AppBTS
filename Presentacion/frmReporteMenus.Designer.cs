
namespace AppBTS.Presentacion
{
    partial class frmReporteMenus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteMenus));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dsDetallesTicketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDetallesTicket = new AppBTS.Reportes.dsDetallesTicket();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cboMenu = new System.Windows.Forms.ComboBox();
            this.btnAño = new System.Windows.Forms.Button();
            this.btnMes = new System.Windows.Forms.Button();
            this.btnSemana = new System.Windows.Forms.Button();
            this.btnDia = new System.Windows.Forms.Button();
            this.btnPerso = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dsDetallesTicketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDetallesTicket)).BeginInit();
            this.SuspendLayout();
            // 
            // dsDetallesTicketBindingSource
            // 
            this.dsDetallesTicketBindingSource.DataSource = this.dsDetallesTicket;
            this.dsDetallesTicketBindingSource.Position = 0;
            // 
            // dsDetallesTicket
            // 
            this.dsDetallesTicket.DataSetName = "dsDetallesTicket";
            this.dsDetallesTicket.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 37);
            this.label1.TabIndex = 47;
            this.label1.Text = "Menú Más Vendido";
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblFechaDesde.Location = new System.Drawing.Point(28, 95);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(93, 16);
            this.lblFechaDesde.TabIndex = 51;
            this.lblFechaDesde.Text = "Fecha Desde:";
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblFechaHasta.Location = new System.Drawing.Point(330, 95);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(88, 16);
            this.lblFechaHasta.TabIndex = 50;
            this.lblFechaHasta.Text = "Fecha Hasta:";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.CalendarMonthBackground = System.Drawing.SystemColors.WindowFrame;
            this.dtpFechaHasta.Enabled = false;
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(425, 91);
            this.dtpFechaHasta.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(177, 20);
            this.dtpFechaHasta.TabIndex = 49;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Enabled = false;
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(129, 91);
            this.dtpFechaDesde.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(177, 20);
            this.dtpFechaDesde.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label6.Location = new System.Drawing.Point(643, 91);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 59;
            this.label6.Text = "Menú:";
            // 
            // cboMenu
            // 
            this.cboMenu.BackColor = System.Drawing.Color.Tan;
            this.cboMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboMenu.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboMenu.FormattingEnabled = true;
            this.cboMenu.Location = new System.Drawing.Point(707, 90);
            this.cboMenu.Margin = new System.Windows.Forms.Padding(4);
            this.cboMenu.Name = "cboMenu";
            this.cboMenu.Size = new System.Drawing.Size(177, 21);
            this.cboMenu.TabIndex = 60;
            // 
            // btnAño
            // 
            this.btnAño.Location = new System.Drawing.Point(30, 61);
            this.btnAño.Name = "btnAño";
            this.btnAño.Size = new System.Drawing.Size(75, 23);
            this.btnAño.TabIndex = 61;
            this.btnAño.Text = "Año";
            this.btnAño.UseVisualStyleBackColor = true;
            this.btnAño.Click += new System.EventHandler(this.btnAño_Click);
            // 
            // btnMes
            // 
            this.btnMes.Location = new System.Drawing.Point(111, 61);
            this.btnMes.Name = "btnMes";
            this.btnMes.Size = new System.Drawing.Size(75, 23);
            this.btnMes.TabIndex = 62;
            this.btnMes.Text = "Mes";
            this.btnMes.UseVisualStyleBackColor = true;
            this.btnMes.Click += new System.EventHandler(this.btnMes_Click);
            // 
            // btnSemana
            // 
            this.btnSemana.Location = new System.Drawing.Point(194, 61);
            this.btnSemana.Name = "btnSemana";
            this.btnSemana.Size = new System.Drawing.Size(75, 23);
            this.btnSemana.TabIndex = 63;
            this.btnSemana.Text = "Semana";
            this.btnSemana.UseVisualStyleBackColor = true;
            this.btnSemana.Click += new System.EventHandler(this.btnSemana_Click);
            // 
            // btnDia
            // 
            this.btnDia.Location = new System.Drawing.Point(275, 61);
            this.btnDia.Name = "btnDia";
            this.btnDia.Size = new System.Drawing.Size(75, 23);
            this.btnDia.TabIndex = 64;
            this.btnDia.Text = "Dia";
            this.btnDia.UseVisualStyleBackColor = true;
            this.btnDia.Click += new System.EventHandler(this.btnDia_Click);
            // 
            // btnPerso
            // 
            this.btnPerso.Location = new System.Drawing.Point(356, 61);
            this.btnPerso.Name = "btnPerso";
            this.btnPerso.Size = new System.Drawing.Size(87, 23);
            this.btnPerso.TabIndex = 65;
            this.btnPerso.Text = "Personalizado:";
            this.btnPerso.UseVisualStyleBackColor = true;
            this.btnPerso.Click += new System.EventHandler(this.btnPerso_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.Tan;
            this.btnConsultar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.Image")));
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(707, 125);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(134, 35);
            this.btnConsultar.TabIndex = 66;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(848, 125);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(36, 35);
            this.btnClear.TabIndex = 67;
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Tan;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Image = global::AppBTS.Properties.Resources.logout_door;
            this.btnSalir.Location = new System.Drawing.Point(859, 524);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(53, 40);
            this.btnSalir.TabIndex = 68;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dsDetallesTicketBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AppBTS.Reportes.rptDetallesTicket.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 176);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(900, 342);
            this.reportViewer1.TabIndex = 69;
            // 
            // frmReporteMenus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(924, 576);
            this.ControlBox = false;
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnPerso);
            this.Controls.Add(this.btnDia);
            this.Controls.Add(this.btnSemana);
            this.Controls.Add(this.btnMes);
            this.Controls.Add(this.btnAño);
            this.Controls.Add(this.cboMenu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblFechaDesde);
            this.Controls.Add(this.lblFechaHasta);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "frmReporteMenus";
            this.ShowIcon = false;
            this.Text = "ReporteMenus";
            this.Load += new System.EventHandler(this.frmReporteMenus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsDetallesTicketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDetallesTicket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboMenu;
        private System.Windows.Forms.Button btnAño;
        private System.Windows.Forms.Button btnMes;
        private System.Windows.Forms.Button btnSemana;
        private System.Windows.Forms.Button btnDia;
        private System.Windows.Forms.Button btnPerso;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSalir;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dsDetallesTicketBindingSource;
        private Reportes.dsDetallesTicket dsDetallesTicket;
    }
}
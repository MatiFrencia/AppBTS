
namespace AppBTS.Presentacion
{
    partial class frmReporteHoras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteHoras));
            this.dsHorasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsHoras = new AppBTS.Reportes.dsHoras();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPerso = new System.Windows.Forms.Button();
            this.btnDia = new System.Windows.Forms.Button();
            this.btnSemana = new System.Windows.Forms.Button();
            this.btnMes = new System.Windows.Forms.Button();
            this.btnAño = new System.Windows.Forms.Button();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsHorasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHoras)).BeginInit();
            this.SuspendLayout();
            // 
            // dsHorasBindingSource
            // 
            this.dsHorasBindingSource.DataSource = this.dsHoras;
            this.dsHorasBindingSource.Position = 0;
            // 
            // dsHoras
            // 
            this.dsHoras.DataSetName = "dsHoras";
            this.dsHoras.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 37);
            this.label1.TabIndex = 48;
            this.label1.Text = "Horarios con más Ventas";
            // 
            // btnPerso
            // 
            this.btnPerso.Location = new System.Drawing.Point(418, 49);
            this.btnPerso.Name = "btnPerso";
            this.btnPerso.Size = new System.Drawing.Size(101, 27);
            this.btnPerso.TabIndex = 74;
            this.btnPerso.Text = "Personalizado:";
            this.btnPerso.UseVisualStyleBackColor = true;
            this.btnPerso.Click += new System.EventHandler(this.btnPerso_Click);
            // 
            // btnDia
            // 
            this.btnDia.Location = new System.Drawing.Point(323, 49);
            this.btnDia.Name = "btnDia";
            this.btnDia.Size = new System.Drawing.Size(87, 27);
            this.btnDia.TabIndex = 73;
            this.btnDia.Text = "Dia";
            this.btnDia.UseVisualStyleBackColor = true;
            this.btnDia.Click += new System.EventHandler(this.btnDia_Click);
            // 
            // btnSemana
            // 
            this.btnSemana.Location = new System.Drawing.Point(229, 49);
            this.btnSemana.Name = "btnSemana";
            this.btnSemana.Size = new System.Drawing.Size(87, 27);
            this.btnSemana.TabIndex = 72;
            this.btnSemana.Text = "Semana";
            this.btnSemana.UseVisualStyleBackColor = true;
            this.btnSemana.Click += new System.EventHandler(this.btnSemana_Click);
            // 
            // btnMes
            // 
            this.btnMes.Location = new System.Drawing.Point(132, 49);
            this.btnMes.Name = "btnMes";
            this.btnMes.Size = new System.Drawing.Size(87, 27);
            this.btnMes.TabIndex = 71;
            this.btnMes.Text = "Mes";
            this.btnMes.UseVisualStyleBackColor = true;
            this.btnMes.Click += new System.EventHandler(this.btnMes_Click);
            // 
            // btnAño
            // 
            this.btnAño.Location = new System.Drawing.Point(37, 49);
            this.btnAño.Name = "btnAño";
            this.btnAño.Size = new System.Drawing.Size(87, 27);
            this.btnAño.TabIndex = 70;
            this.btnAño.Text = "Año";
            this.btnAño.UseVisualStyleBackColor = true;
            this.btnAño.Click += new System.EventHandler(this.btnAño_Click);
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblFechaDesde.Location = new System.Drawing.Point(31, 92);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(93, 16);
            this.lblFechaDesde.TabIndex = 69;
            this.lblFechaDesde.Text = "Fecha Desde:";
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblFechaHasta.Location = new System.Drawing.Point(270, 92);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(88, 16);
            this.lblFechaHasta.TabIndex = 68;
            this.lblFechaHasta.Text = "Fecha Hasta:";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.CalendarMonthBackground = System.Drawing.SystemColors.WindowFrame;
            this.dtpFechaHasta.Enabled = false;
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(364, 90);
            this.dtpFechaHasta.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(109, 21);
            this.dtpFechaHasta.TabIndex = 67;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Enabled = false;
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(132, 90);
            this.dtpFechaDesde.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(109, 21);
            this.dtpFechaDesde.TabIndex = 66;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dsHorasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AppBTS.Reportes.rptHoras.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(16, 136);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(821, 468);
            this.reportViewer1.TabIndex = 75;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.Tan;
            this.btnConsultar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.Image")));
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(570, 82);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(145, 40);
            this.btnConsultar.TabIndex = 76;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Tan;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Image = global::AppBTS.Properties.Resources.logout_door;
            this.btnSalir.Location = new System.Drawing.Point(16, 611);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(62, 46);
            this.btnSalir.TabIndex = 77;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmReporteHoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(849, 669);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnPerso);
            this.Controls.Add(this.btnDia);
            this.Controls.Add(this.btnSemana);
            this.Controls.Add(this.btnMes);
            this.Controls.Add(this.btnAño);
            this.Controls.Add(this.lblFechaDesde);
            this.Controls.Add(this.lblFechaHasta);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "frmReporteHoras";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reporte Pedidos por Hora";
            this.Load += new System.EventHandler(this.frmReporteHoras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsHorasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHoras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPerso;
        private System.Windows.Forms.Button btnDia;
        private System.Windows.Forms.Button btnSemana;
        private System.Windows.Forms.Button btnMes;
        private System.Windows.Forms.Button btnAño;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.BindingSource dsHorasBindingSource;
        private Reportes.dsHoras dsHoras;
    }
}

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
            this.dsHoras = new AppBTS.Reportes.dsHoras();
            this.dsHorasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dsHoras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHorasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 37);
            this.label1.TabIndex = 48;
            this.label1.Text = "Horarios con más Ventas";
            // 
            // btnPerso
            // 
            this.btnPerso.Location = new System.Drawing.Point(370, 49);
            this.btnPerso.Name = "btnPerso";
            this.btnPerso.Size = new System.Drawing.Size(87, 23);
            this.btnPerso.TabIndex = 74;
            this.btnPerso.Text = "Personalizado:";
            this.btnPerso.UseVisualStyleBackColor = true;
            // 
            // btnDia
            // 
            this.btnDia.Location = new System.Drawing.Point(289, 49);
            this.btnDia.Name = "btnDia";
            this.btnDia.Size = new System.Drawing.Size(75, 23);
            this.btnDia.TabIndex = 73;
            this.btnDia.Text = "Dia";
            this.btnDia.UseVisualStyleBackColor = true;
            // 
            // btnSemana
            // 
            this.btnSemana.Location = new System.Drawing.Point(208, 49);
            this.btnSemana.Name = "btnSemana";
            this.btnSemana.Size = new System.Drawing.Size(75, 23);
            this.btnSemana.TabIndex = 72;
            this.btnSemana.Text = "Semana";
            this.btnSemana.UseVisualStyleBackColor = true;
            // 
            // btnMes
            // 
            this.btnMes.Location = new System.Drawing.Point(125, 49);
            this.btnMes.Name = "btnMes";
            this.btnMes.Size = new System.Drawing.Size(75, 23);
            this.btnMes.TabIndex = 71;
            this.btnMes.Text = "Mes";
            this.btnMes.UseVisualStyleBackColor = true;
            // 
            // btnAño
            // 
            this.btnAño.Location = new System.Drawing.Point(44, 49);
            this.btnAño.Name = "btnAño";
            this.btnAño.Size = new System.Drawing.Size(75, 23);
            this.btnAño.TabIndex = 70;
            this.btnAño.Text = "Año";
            this.btnAño.UseVisualStyleBackColor = true;
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblFechaDesde.Location = new System.Drawing.Point(26, 95);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(93, 16);
            this.lblFechaDesde.TabIndex = 69;
            this.lblFechaDesde.Text = "Fecha Desde:";
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblFechaHasta.Location = new System.Drawing.Point(328, 95);
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
            this.dtpFechaHasta.Location = new System.Drawing.Point(423, 91);
            this.dtpFechaHasta.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(177, 20);
            this.dtpFechaHasta.TabIndex = 67;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Enabled = false;
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(127, 91);
            this.dtpFechaDesde.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(177, 20);
            this.dtpFechaDesde.TabIndex = 66;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dsHorasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AppBTS.Reportes.rptHoras.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(29, 149);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1048, 406);
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
            this.btnConsultar.Location = new System.Drawing.Point(943, 107);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(134, 35);
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
            this.btnSalir.Location = new System.Drawing.Point(1024, 561);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(53, 40);
            this.btnSalir.TabIndex = 77;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dsHoras
            // 
            this.dsHoras.DataSetName = "dsHoras";
            this.dsHoras.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsHorasBindingSource
            // 
            this.dsHorasBindingSource.DataSource = this.dsHoras;
            this.dsHorasBindingSource.Position = 0;
            // 
            // frmReporteHoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1102, 602);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "frmReporteHoras";
            this.ShowIcon = false;
            this.Text = "Reporte Pedidos por Hora";
            this.Load += new System.EventHandler(this.frmReporteHoras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsHoras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHorasBindingSource)).EndInit();
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
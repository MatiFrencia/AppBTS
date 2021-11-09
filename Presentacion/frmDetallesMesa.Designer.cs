﻿
namespace AppBTS.Presentacion
{
    partial class frmDetallesMesa
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
            this.bAR_PAVDataSet = new AppBTS.BAR_PAVDataSet();
            this.reservasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservasTableAdapter = new AppBTS.BAR_PAVDataSetTableAdapters.ReservasTableAdapter();
            this.dgvReservasMesa = new System.Windows.Forms.DataGridView();
            this.nroReserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroMesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaReserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaReserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadComensales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblTituloDetallesMesa = new System.Windows.Forms.Label();
            this.btnOkey = new System.Windows.Forms.Button();
            this.btnBorrarMesa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bAR_PAVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservasMesa)).BeginInit();
            this.SuspendLayout();
            // 
            // bAR_PAVDataSet
            // 
            this.bAR_PAVDataSet.DataSetName = "BAR_PAVDataSet";
            this.bAR_PAVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservasBindingSource
            // 
            this.reservasBindingSource.DataMember = "Reservas";
            this.reservasBindingSource.DataSource = this.bAR_PAVDataSet;
            // 
            // reservasTableAdapter
            // 
            this.reservasTableAdapter.ClearBeforeFill = true;
            // 
            // dgvReservasMesa
            // 
            this.dgvReservasMesa.AllowUserToAddRows = false;
            this.dgvReservasMesa.AllowUserToDeleteRows = false;
            this.dgvReservasMesa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservasMesa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nroReserva,
            this.nroMesa,
            this.fechaReserva,
            this.horaReserva,
            this.nombreCliente,
            this.telefono,
            this.cantidadComensales,
            this.borrado});
            this.dgvReservasMesa.Location = new System.Drawing.Point(12, 56);
            this.dgvReservasMesa.Name = "dgvReservasMesa";
            this.dgvReservasMesa.ReadOnly = true;
            this.dgvReservasMesa.Size = new System.Drawing.Size(820, 318);
            this.dgvReservasMesa.TabIndex = 0;
            // 
            // nroReserva
            // 
            this.nroReserva.HeaderText = "# Reserva";
            this.nroReserva.Name = "nroReserva";
            this.nroReserva.ReadOnly = true;
            // 
            // nroMesa
            // 
            this.nroMesa.HeaderText = "# Mesa";
            this.nroMesa.Name = "nroMesa";
            this.nroMesa.ReadOnly = true;
            // 
            // fechaReserva
            // 
            this.fechaReserva.HeaderText = "Fecha de Reserva";
            this.fechaReserva.Name = "fechaReserva";
            this.fechaReserva.ReadOnly = true;
            // 
            // horaReserva
            // 
            this.horaReserva.HeaderText = "Hora de Reserva";
            this.horaReserva.Name = "horaReserva";
            this.horaReserva.ReadOnly = true;
            // 
            // nombreCliente
            // 
            this.nombreCliente.HeaderText = "Cliente";
            this.nombreCliente.Name = "nombreCliente";
            this.nombreCliente.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.HeaderText = "Teléfono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // cantidadComensales
            // 
            this.cantidadComensales.HeaderText = "Comensales";
            this.cantidadComensales.Name = "cantidadComensales";
            this.cantidadComensales.ReadOnly = true;
            // 
            // borrado
            // 
            this.borrado.HeaderText = "Borrado";
            this.borrado.Name = "borrado";
            this.borrado.ReadOnly = true;
            // 
            // lblTituloDetallesMesa
            // 
            this.lblTituloDetallesMesa.AutoSize = true;
            this.lblTituloDetallesMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDetallesMesa.Location = new System.Drawing.Point(12, 19);
            this.lblTituloDetallesMesa.Name = "lblTituloDetallesMesa";
            this.lblTituloDetallesMesa.Size = new System.Drawing.Size(460, 25);
            this.lblTituloDetallesMesa.TabIndex = 1;
            this.lblTituloDetallesMesa.Text = "RESERVAS DE LA MESA SELECCIONADA";
            // 
            // btnOkey
            // 
            this.btnOkey.Location = new System.Drawing.Point(746, 393);
            this.btnOkey.Name = "btnOkey";
            this.btnOkey.Size = new System.Drawing.Size(68, 27);
            this.btnOkey.TabIndex = 2;
            this.btnOkey.Text = "OK";
            this.btnOkey.UseVisualStyleBackColor = true;
            this.btnOkey.Click += new System.EventHandler(this.btnOkey_Click);
            // 
            // btnBorrarMesa
            // 
            this.btnBorrarMesa.Location = new System.Drawing.Point(36, 393);
            this.btnBorrarMesa.Name = "btnBorrarMesa";
            this.btnBorrarMesa.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarMesa.TabIndex = 3;
            this.btnBorrarMesa.Text = "Borrar Mesa";
            this.btnBorrarMesa.UseVisualStyleBackColor = true;
            this.btnBorrarMesa.Click += new System.EventHandler(this.btnBorrarMesa_Click);
            // 
            // frmDetallesMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(844, 438);
            this.Controls.Add(this.btnBorrarMesa);
            this.Controls.Add(this.btnOkey);
            this.Controls.Add(this.lblTituloDetallesMesa);
            this.Controls.Add(this.dgvReservasMesa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDetallesMesa";
            this.Load += new System.EventHandler(this.frmDetallesMesa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bAR_PAVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservasMesa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BAR_PAVDataSet bAR_PAVDataSet;
        private System.Windows.Forms.BindingSource reservasBindingSource;
        private BAR_PAVDataSetTableAdapters.ReservasTableAdapter reservasTableAdapter;
        private System.Windows.Forms.DataGridView dgvReservasMesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroMesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadComensales;
        private System.Windows.Forms.DataGridViewCheckBoxColumn borrado;
        private System.Windows.Forms.Label lblTituloDetallesMesa;
        private System.Windows.Forms.Button btnOkey;
        private System.Windows.Forms.Button btnBorrarMesa;
    }
}
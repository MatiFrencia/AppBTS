
namespace AppBTS.Presentacion
{
    partial class frmAltaReserva
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
            this.lblNroReserva = new System.Windows.Forms.Label();
            this.lblNroMesa = new System.Windows.Forms.Label();
            this.lblFechaReserva = new System.Windows.Forms.Label();
            this.lblHoraReserva = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblCantidadComensales = new System.Windows.Forms.Label();
            this.txtbCantidadComensales = new System.Windows.Forms.TextBox();
            this.txtbTelefono = new System.Windows.Forms.TextBox();
            this.txtbCliente = new System.Windows.Forms.TextBox();
            this.txtbHoraReserva = new System.Windows.Forms.TextBox();
            this.txtbFechaReserva = new System.Windows.Forms.TextBox();
            this.txtbNumeroMesa = new System.Windows.Forms.TextBox();
            this.txtbNumeroReserva = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblCamposObligatorios = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNroReserva
            // 
            this.lblNroReserva.AutoSize = true;
            this.lblNroReserva.Location = new System.Drawing.Point(40, 35);
            this.lblNroReserva.Name = "lblNroReserva";
            this.lblNroReserva.Size = new System.Drawing.Size(57, 13);
            this.lblNroReserva.TabIndex = 0;
            this.lblNroReserva.Text = "# Reserva";
            // 
            // lblNroMesa
            // 
            this.lblNroMesa.AutoSize = true;
            this.lblNroMesa.Location = new System.Drawing.Point(40, 68);
            this.lblNroMesa.Name = "lblNroMesa";
            this.lblNroMesa.Size = new System.Drawing.Size(43, 13);
            this.lblNroMesa.TabIndex = 1;
            this.lblNroMesa.Text = "# Mesa";
            // 
            // lblFechaReserva
            // 
            this.lblFechaReserva.AutoSize = true;
            this.lblFechaReserva.Location = new System.Drawing.Point(40, 102);
            this.lblFechaReserva.Name = "lblFechaReserva";
            this.lblFechaReserva.Size = new System.Drawing.Size(95, 13);
            this.lblFechaReserva.TabIndex = 2;
            this.lblFechaReserva.Text = "Fecha de Reserva";
            // 
            // lblHoraReserva
            // 
            this.lblHoraReserva.AutoSize = true;
            this.lblHoraReserva.Location = new System.Drawing.Point(40, 133);
            this.lblHoraReserva.Name = "lblHoraReserva";
            this.lblHoraReserva.Size = new System.Drawing.Size(88, 13);
            this.lblHoraReserva.TabIndex = 3;
            this.lblHoraReserva.Text = "Hora de Reserva";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(40, 166);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(96, 13);
            this.lblCliente.TabIndex = 4;
            this.lblCliente.Text = "Nombre del Cliente";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(40, 199);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 5;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblCantidadComensales
            // 
            this.lblCantidadComensales.AutoSize = true;
            this.lblCantidadComensales.Location = new System.Drawing.Point(43, 233);
            this.lblCantidadComensales.Name = "lblCantidadComensales";
            this.lblCantidadComensales.Size = new System.Drawing.Size(123, 13);
            this.lblCantidadComensales.TabIndex = 6;
            this.lblCantidadComensales.Text = "Cantidad de comensales";
            // 
            // txtbCantidadComensales
            // 
            this.txtbCantidadComensales.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbCantidadComensales.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtbCantidadComensales.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtbCantidadComensales.Location = new System.Drawing.Point(173, 225);
            this.txtbCantidadComensales.Name = "txtbCantidadComensales";
            this.txtbCantidadComensales.Size = new System.Drawing.Size(100, 20);
            this.txtbCantidadComensales.TabIndex = 7;
            // 
            // txtbTelefono
            // 
            this.txtbTelefono.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbTelefono.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtbTelefono.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtbTelefono.Location = new System.Drawing.Point(173, 196);
            this.txtbTelefono.Name = "txtbTelefono";
            this.txtbTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtbTelefono.TabIndex = 8;
            // 
            // txtbCliente
            // 
            this.txtbCliente.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbCliente.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtbCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtbCliente.Location = new System.Drawing.Point(173, 163);
            this.txtbCliente.Name = "txtbCliente";
            this.txtbCliente.Size = new System.Drawing.Size(100, 20);
            this.txtbCliente.TabIndex = 9;
            // 
            // txtbHoraReserva
            // 
            this.txtbHoraReserva.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbHoraReserva.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtbHoraReserva.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtbHoraReserva.Location = new System.Drawing.Point(173, 130);
            this.txtbHoraReserva.Name = "txtbHoraReserva";
            this.txtbHoraReserva.Size = new System.Drawing.Size(100, 20);
            this.txtbHoraReserva.TabIndex = 10;
            // 
            // txtbFechaReserva
            // 
            this.txtbFechaReserva.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbFechaReserva.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtbFechaReserva.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtbFechaReserva.Location = new System.Drawing.Point(173, 99);
            this.txtbFechaReserva.Name = "txtbFechaReserva";
            this.txtbFechaReserva.Size = new System.Drawing.Size(100, 20);
            this.txtbFechaReserva.TabIndex = 11;
            // 
            // txtbNumeroMesa
            // 
            this.txtbNumeroMesa.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbNumeroMesa.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtbNumeroMesa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtbNumeroMesa.Location = new System.Drawing.Point(173, 65);
            this.txtbNumeroMesa.Name = "txtbNumeroMesa";
            this.txtbNumeroMesa.Size = new System.Drawing.Size(100, 20);
            this.txtbNumeroMesa.TabIndex = 12;
            // 
            // txtbNumeroReserva
            // 
            this.txtbNumeroReserva.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbNumeroReserva.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtbNumeroReserva.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtbNumeroReserva.Location = new System.Drawing.Point(173, 32);
            this.txtbNumeroReserva.Name = "txtbNumeroReserva";
            this.txtbNumeroReserva.Size = new System.Drawing.Size(100, 20);
            this.txtbNumeroReserva.TabIndex = 13;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Location = new System.Drawing.Point(91, 305);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(198, 305);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // lblCamposObligatorios
            // 
            this.lblCamposObligatorios.AutoSize = true;
            this.lblCamposObligatorios.Location = new System.Drawing.Point(5, 264);
            this.lblCamposObligatorios.Name = "lblCamposObligatorios";
            this.lblCamposObligatorios.Size = new System.Drawing.Size(346, 13);
            this.lblCamposObligatorios.TabIndex = 16;
            this.lblCamposObligatorios.Text = "* Todos los campos son obligatorios y deben completarse para proceder";
            // 
            // frmAltaReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(366, 363);
            this.Controls.Add(this.lblCamposObligatorios);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtbNumeroReserva);
            this.Controls.Add(this.txtbNumeroMesa);
            this.Controls.Add(this.txtbFechaReserva);
            this.Controls.Add(this.txtbHoraReserva);
            this.Controls.Add(this.txtbCliente);
            this.Controls.Add(this.txtbTelefono);
            this.Controls.Add(this.txtbCantidadComensales);
            this.Controls.Add(this.lblCantidadComensales);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblHoraReserva);
            this.Controls.Add(this.lblFechaReserva);
            this.Controls.Add(this.lblNroMesa);
            this.Controls.Add(this.lblNroReserva);
            this.Name = "frmAltaReserva";
            this.ShowIcon = false;
            this.Text = "Registrar Reserva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNroReserva;
        private System.Windows.Forms.Label lblNroMesa;
        private System.Windows.Forms.Label lblFechaReserva;
        private System.Windows.Forms.Label lblHoraReserva;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblCantidadComensales;
        private System.Windows.Forms.TextBox txtbCantidadComensales;
        private System.Windows.Forms.TextBox txtbTelefono;
        private System.Windows.Forms.TextBox txtbCliente;
        private System.Windows.Forms.TextBox txtbHoraReserva;
        private System.Windows.Forms.TextBox txtbFechaReserva;
        private System.Windows.Forms.TextBox txtbNumeroMesa;
        private System.Windows.Forms.TextBox txtbNumeroReserva;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblCamposObligatorios;
    }
}
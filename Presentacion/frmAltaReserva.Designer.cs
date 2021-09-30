
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
            this.lbTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNroReserva
            // 
            this.lblNroReserva.AutoSize = true;
            this.lblNroReserva.Location = new System.Drawing.Point(118, 53);
            this.lblNroReserva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNroReserva.Name = "lblNroReserva";
            this.lblNroReserva.Size = new System.Drawing.Size(85, 20);
            this.lblNroReserva.TabIndex = 0;
            this.lblNroReserva.Text = "# Reserva:";
            // 
            // lblNroMesa
            // 
            this.lblNroMesa.AutoSize = true;
            this.lblNroMesa.Location = new System.Drawing.Point(138, 105);
            this.lblNroMesa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNroMesa.Name = "lblNroMesa";
            this.lblNroMesa.Size = new System.Drawing.Size(65, 20);
            this.lblNroMesa.TabIndex = 1;
            this.lblNroMesa.Text = "# Mesa:";
            // 
            // lblFechaReserva
            // 
            this.lblFechaReserva.AutoSize = true;
            this.lblFechaReserva.Location = new System.Drawing.Point(60, 157);
            this.lblFechaReserva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaReserva.Name = "lblFechaReserva";
            this.lblFechaReserva.Size = new System.Drawing.Size(143, 20);
            this.lblFechaReserva.TabIndex = 2;
            this.lblFechaReserva.Text = "Fecha de Reserva:";
            // 
            // lblHoraReserva
            // 
            this.lblHoraReserva.AutoSize = true;
            this.lblHoraReserva.Location = new System.Drawing.Point(70, 209);
            this.lblHoraReserva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoraReserva.Name = "lblHoraReserva";
            this.lblHoraReserva.Size = new System.Drawing.Size(133, 20);
            this.lblHoraReserva.TabIndex = 3;
            this.lblHoraReserva.Text = "Hora de Reserva:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(56, 261);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(147, 20);
            this.lblCliente.TabIndex = 4;
            this.lblCliente.Text = "Nombre del Cliente:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(128, 313);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(75, 20);
            this.lblTelefono.TabIndex = 5;
            this.lblTelefono.Text = "Telefono:";
            // 
            // lblCantidadComensales
            // 
            this.lblCantidadComensales.AutoSize = true;
            this.lblCantidadComensales.Location = new System.Drawing.Point(15, 365);
            this.lblCantidadComensales.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadComensales.Name = "lblCantidadComensales";
            this.lblCantidadComensales.Size = new System.Drawing.Size(188, 20);
            this.lblCantidadComensales.TabIndex = 6;
            this.lblCantidadComensales.Text = "Cantidad de comensales:";
            // 
            // txtbCantidadComensales
            // 
            this.txtbCantidadComensales.BackColor = System.Drawing.Color.Tan;
            this.txtbCantidadComensales.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtbCantidadComensales.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtbCantidadComensales.Location = new System.Drawing.Point(207, 362);
            this.txtbCantidadComensales.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbCantidadComensales.Name = "txtbCantidadComensales";
            this.txtbCantidadComensales.Size = new System.Drawing.Size(28, 26);
            this.txtbCantidadComensales.TabIndex = 6;
            // 
            // txtbTelefono
            // 
            this.txtbTelefono.BackColor = System.Drawing.Color.Tan;
            this.txtbTelefono.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtbTelefono.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtbTelefono.Location = new System.Drawing.Point(207, 310);
            this.txtbTelefono.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbTelefono.Name = "txtbTelefono";
            this.txtbTelefono.Size = new System.Drawing.Size(106, 26);
            this.txtbTelefono.TabIndex = 5;
            // 
            // txtbCliente
            // 
            this.txtbCliente.BackColor = System.Drawing.Color.Tan;
            this.txtbCliente.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtbCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtbCliente.Location = new System.Drawing.Point(207, 258);
            this.txtbCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbCliente.Name = "txtbCliente";
            this.txtbCliente.Size = new System.Drawing.Size(148, 26);
            this.txtbCliente.TabIndex = 4;
            // 
            // txtbHoraReserva
            // 
            this.txtbHoraReserva.BackColor = System.Drawing.Color.Tan;
            this.txtbHoraReserva.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtbHoraReserva.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtbHoraReserva.Location = new System.Drawing.Point(207, 206);
            this.txtbHoraReserva.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbHoraReserva.Name = "txtbHoraReserva";
            this.txtbHoraReserva.Size = new System.Drawing.Size(71, 26);
            this.txtbHoraReserva.TabIndex = 3;
            this.txtbHoraReserva.Tag = "";
            // 
            // txtbFechaReserva
            // 
            this.txtbFechaReserva.BackColor = System.Drawing.Color.Tan;
            this.txtbFechaReserva.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtbFechaReserva.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtbFechaReserva.Location = new System.Drawing.Point(207, 154);
            this.txtbFechaReserva.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbFechaReserva.Name = "txtbFechaReserva";
            this.txtbFechaReserva.Size = new System.Drawing.Size(89, 26);
            this.txtbFechaReserva.TabIndex = 2;
            // 
            // txtbNumeroMesa
            // 
            this.txtbNumeroMesa.BackColor = System.Drawing.Color.Tan;
            this.txtbNumeroMesa.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtbNumeroMesa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtbNumeroMesa.Location = new System.Drawing.Point(207, 102);
            this.txtbNumeroMesa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbNumeroMesa.Name = "txtbNumeroMesa";
            this.txtbNumeroMesa.Size = new System.Drawing.Size(28, 26);
            this.txtbNumeroMesa.TabIndex = 1;
            // 
            // txtbNumeroReserva
            // 
            this.txtbNumeroReserva.BackColor = System.Drawing.Color.Tan;
            this.txtbNumeroReserva.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtbNumeroReserva.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtbNumeroReserva.Location = new System.Drawing.Point(207, 50);
            this.txtbNumeroReserva.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbNumeroReserva.Name = "txtbNumeroReserva";
            this.txtbNumeroReserva.Size = new System.Drawing.Size(41, 26);
            this.txtbNumeroReserva.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Tan;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Location = new System.Drawing.Point(201, 437);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(112, 35);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Tan;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(74, 437);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 35);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblCamposObligatorios
            // 
            this.lblCamposObligatorios.AutoSize = true;
            this.lblCamposObligatorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCamposObligatorios.Location = new System.Drawing.Point(71, 397);
            this.lblCamposObligatorios.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCamposObligatorios.Name = "lblCamposObligatorios";
            this.lblCamposObligatorios.Size = new System.Drawing.Size(236, 16);
            this.lblCamposObligatorios.TabIndex = 16;
            this.lblCamposObligatorios.Text = "(*) Todos los campos son obligatorios";
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTitulo.Font = new System.Drawing.Font("Dutch801 XBd BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbTitulo.Location = new System.Drawing.Point(13, 9);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(181, 25);
            this.lbTitulo.TabIndex = 17;
            this.lbTitulo.Text = "Registrar Reserva";
            // 
            // frmAltaReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(371, 491);
            this.Controls.Add(this.lbTitulo);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(1180, 128);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAltaReserva";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Registrar Reserva";
            this.Load += new System.EventHandler(this.frmAltaReserva_Load);
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
        private System.Windows.Forms.Label lbTitulo;
    }
}
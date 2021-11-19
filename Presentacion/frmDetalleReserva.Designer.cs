
namespace AppBTS.Presentacion
{
    partial class frmDetalleReserva
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
            this.txtbNumeroMesa = new System.Windows.Forms.TextBox();
            this.txtbNumeroReserva = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dtpFechaReserva = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraReserva = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblNroReserva
            // 
            this.lblNroReserva.AutoSize = true;
            this.lblNroReserva.Location = new System.Drawing.Point(118, 48);
            this.lblNroReserva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNroReserva.Name = "lblNroReserva";
            this.lblNroReserva.Size = new System.Drawing.Size(79, 18);
            this.lblNroReserva.TabIndex = 0;
            this.lblNroReserva.Text = "# Reserva:";
            // 
            // lblNroMesa
            // 
            this.lblNroMesa.AutoSize = true;
            this.lblNroMesa.Location = new System.Drawing.Point(136, 95);
            this.lblNroMesa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNroMesa.Name = "lblNroMesa";
            this.lblNroMesa.Size = new System.Drawing.Size(61, 18);
            this.lblNroMesa.TabIndex = 1;
            this.lblNroMesa.Text = "# Mesa:";
            // 
            // lblFechaReserva
            // 
            this.lblFechaReserva.AutoSize = true;
            this.lblFechaReserva.Location = new System.Drawing.Point(65, 138);
            this.lblFechaReserva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaReserva.Name = "lblFechaReserva";
            this.lblFechaReserva.Size = new System.Drawing.Size(132, 18);
            this.lblFechaReserva.TabIndex = 2;
            this.lblFechaReserva.Text = "Fecha de Reserva:";
            // 
            // lblHoraReserva
            // 
            this.lblHoraReserva.AutoSize = true;
            this.lblHoraReserva.Location = new System.Drawing.Point(73, 180);
            this.lblHoraReserva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoraReserva.Name = "lblHoraReserva";
            this.lblHoraReserva.Size = new System.Drawing.Size(124, 18);
            this.lblHoraReserva.TabIndex = 3;
            this.lblHoraReserva.Text = "Hora de Reserva:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(59, 224);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(138, 18);
            this.lblCliente.TabIndex = 4;
            this.lblCliente.Text = "Nombre del Cliente:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(127, 271);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(70, 18);
            this.lblTelefono.TabIndex = 5;
            this.lblTelefono.Text = "Telefono:";
            // 
            // lblCantidadComensales
            // 
            this.lblCantidadComensales.AutoSize = true;
            this.lblCantidadComensales.Location = new System.Drawing.Point(22, 318);
            this.lblCantidadComensales.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadComensales.Name = "lblCantidadComensales";
            this.lblCantidadComensales.Size = new System.Drawing.Size(175, 18);
            this.lblCantidadComensales.TabIndex = 6;
            this.lblCantidadComensales.Text = "Cantidad de comensales:";
            // 
            // txtbCantidadComensales
            // 
            this.txtbCantidadComensales.BackColor = System.Drawing.Color.Tan;
            this.txtbCantidadComensales.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtbCantidadComensales.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtbCantidadComensales.Location = new System.Drawing.Point(207, 315);
            this.txtbCantidadComensales.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbCantidadComensales.Name = "txtbCantidadComensales";
            this.txtbCantidadComensales.Size = new System.Drawing.Size(28, 24);
            this.txtbCantidadComensales.TabIndex = 6;
            // 
            // txtbTelefono
            // 
            this.txtbTelefono.BackColor = System.Drawing.Color.Tan;
            this.txtbTelefono.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtbTelefono.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtbTelefono.Location = new System.Drawing.Point(207, 268);
            this.txtbTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbTelefono.Name = "txtbTelefono";
            this.txtbTelefono.Size = new System.Drawing.Size(106, 24);
            this.txtbTelefono.TabIndex = 5;
            // 
            // txtbCliente
            // 
            this.txtbCliente.BackColor = System.Drawing.Color.Tan;
            this.txtbCliente.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtbCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtbCliente.Location = new System.Drawing.Point(207, 221);
            this.txtbCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbCliente.Name = "txtbCliente";
            this.txtbCliente.Size = new System.Drawing.Size(148, 24);
            this.txtbCliente.TabIndex = 4;
            // 
            // txtbNumeroMesa
            // 
            this.txtbNumeroMesa.BackColor = System.Drawing.Color.Tan;
            this.txtbNumeroMesa.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtbNumeroMesa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtbNumeroMesa.Location = new System.Drawing.Point(207, 92);
            this.txtbNumeroMesa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbNumeroMesa.Name = "txtbNumeroMesa";
            this.txtbNumeroMesa.Size = new System.Drawing.Size(28, 24);
            this.txtbNumeroMesa.TabIndex = 1;
            // 
            // txtbNumeroReserva
            // 
            this.txtbNumeroReserva.BackColor = System.Drawing.Color.Tan;
            this.txtbNumeroReserva.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtbNumeroReserva.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtbNumeroReserva.Location = new System.Drawing.Point(207, 45);
            this.txtbNumeroReserva.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbNumeroReserva.Name = "txtbNumeroReserva";
            this.txtbNumeroReserva.Size = new System.Drawing.Size(41, 24);
            this.txtbNumeroReserva.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Tan;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Location = new System.Drawing.Point(68, 370);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(95, 32);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click_1);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbTitulo.Location = new System.Drawing.Point(14, 8);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(165, 25);
            this.lbTitulo.TabIndex = 17;
            this.lbTitulo.Text = "Detalle Reserva";
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(218, 370);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(95, 32);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dtpFechaReserva
            // 
            this.dtpFechaReserva.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaReserva.Location = new System.Drawing.Point(207, 135);
            this.dtpFechaReserva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaReserva.Name = "dtpFechaReserva";
            this.dtpFechaReserva.Size = new System.Drawing.Size(148, 24);
            this.dtpFechaReserva.TabIndex = 19;
            // 
            // dtpHoraReserva
            // 
            this.dtpHoraReserva.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHoraReserva.Location = new System.Drawing.Point(207, 177);
            this.dtpHoraReserva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpHoraReserva.Name = "dtpHoraReserva";
            this.dtpHoraReserva.Size = new System.Drawing.Size(148, 24);
            this.dtpHoraReserva.TabIndex = 20;
            // 
            // frmDetalleReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(371, 432);
            this.Controls.Add(this.dtpHoraReserva);
            this.Controls.Add(this.dtpFechaReserva);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtbNumeroReserva);
            this.Controls.Add(this.txtbNumeroMesa);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(1400, 100);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDetalleReserva";
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
        private System.Windows.Forms.TextBox txtbNumeroMesa;
        private System.Windows.Forms.TextBox txtbNumeroReserva;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker dtpFechaReserva;
        private System.Windows.Forms.DateTimePicker dtpHoraReserva;
    }
}

namespace AppBTS.Presentacion
{
    partial class frmAltaMesa
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
            this.btnConfirmarMesa = new System.Windows.Forms.Button();
            this.btnCancelarMesa = new System.Windows.Forms.Button();
            this.lblNroMesa = new System.Windows.Forms.Label();
            this.lblNroSillas = new System.Windows.Forms.Label();
            this.nmrNroSillas = new System.Windows.Forms.NumericUpDown();
            this.nmrNroMesa = new System.Windows.Forms.NumericUpDown();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmrNroSillas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrNroMesa)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirmarMesa
            // 
            this.btnConfirmarMesa.BackColor = System.Drawing.Color.Tan;
            this.btnConfirmarMesa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmarMesa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmarMesa.Location = new System.Drawing.Point(16, 114);
            this.btnConfirmarMesa.Name = "btnConfirmarMesa";
            this.btnConfirmarMesa.Size = new System.Drawing.Size(67, 27);
            this.btnConfirmarMesa.TabIndex = 4;
            this.btnConfirmarMesa.Text = "Confirmar";
            this.btnConfirmarMesa.UseVisualStyleBackColor = false;
            this.btnConfirmarMesa.Click += new System.EventHandler(this.btnConfirmarMesa_Click);
            // 
            // btnCancelarMesa
            // 
            this.btnCancelarMesa.BackColor = System.Drawing.Color.Tan;
            this.btnCancelarMesa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarMesa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelarMesa.Location = new System.Drawing.Point(98, 114);
            this.btnCancelarMesa.Name = "btnCancelarMesa";
            this.btnCancelarMesa.Size = new System.Drawing.Size(67, 27);
            this.btnCancelarMesa.TabIndex = 5;
            this.btnCancelarMesa.Text = "Cancelar";
            this.btnCancelarMesa.UseVisualStyleBackColor = false;
            this.btnCancelarMesa.Click += new System.EventHandler(this.btnCancelarMesa_Click);
            // 
            // lblNroMesa
            // 
            this.lblNroMesa.AutoSize = true;
            this.lblNroMesa.Location = new System.Drawing.Point(26, 42);
            this.lblNroMesa.Name = "lblNroMesa";
            this.lblNroMesa.Size = new System.Drawing.Size(48, 15);
            this.lblNroMesa.TabIndex = 7;
            this.lblNroMesa.Text = "# Mesa";
            // 
            // lblNroSillas
            // 
            this.lblNroSillas.AutoSize = true;
            this.lblNroSillas.Location = new System.Drawing.Point(26, 78);
            this.lblNroSillas.Name = "lblNroSillas";
            this.lblNroSillas.Size = new System.Drawing.Size(47, 15);
            this.lblNroSillas.TabIndex = 8;
            this.lblNroSillas.Text = "# Sillas";
            // 
            // nmrNroSillas
            // 
            this.nmrNroSillas.Location = new System.Drawing.Point(107, 76);
            this.nmrNroSillas.Name = "nmrNroSillas";
            this.nmrNroSillas.Size = new System.Drawing.Size(45, 21);
            this.nmrNroSillas.TabIndex = 3;
            // 
            // nmrNroMesa
            // 
            this.nmrNroMesa.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nmrNroMesa.InterceptArrowKeys = false;
            this.nmrNroMesa.Location = new System.Drawing.Point(107, 40);
            this.nmrNroMesa.Name = "nmrNroMesa";
            this.nmrNroMesa.ReadOnly = true;
            this.nmrNroMesa.Size = new System.Drawing.Size(45, 21);
            this.nmrNroMesa.TabIndex = 2;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(110, 22);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "Añadir Mesa";
            // 
            // frmAltaMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(183, 156);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.nmrNroMesa);
            this.Controls.Add(this.nmrNroSillas);
            this.Controls.Add(this.lblNroSillas);
            this.Controls.Add(this.lblNroMesa);
            this.Controls.Add(this.btnCancelarMesa);
            this.Controls.Add(this.btnConfirmarMesa);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAltaMesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Añadir Mesa";
            ((System.ComponentModel.ISupportInitialize)(this.nmrNroSillas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrNroMesa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmarMesa;
        private System.Windows.Forms.Button btnCancelarMesa;
        private System.Windows.Forms.Label lblNroMesa;
        private System.Windows.Forms.Label lblNroSillas;
        private System.Windows.Forms.NumericUpDown nmrNroSillas;
        private System.Windows.Forms.NumericUpDown nmrNroMesa;
        private System.Windows.Forms.Label lblTitulo;
    }
}
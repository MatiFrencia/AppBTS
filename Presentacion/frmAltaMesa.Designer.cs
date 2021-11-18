
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
            ((System.ComponentModel.ISupportInitialize)(this.nmrNroSillas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrNroMesa)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirmarMesa
            // 
            this.btnConfirmarMesa.Location = new System.Drawing.Point(10, 115);
            this.btnConfirmarMesa.Name = "btnConfirmarMesa";
            this.btnConfirmarMesa.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmarMesa.TabIndex = 4;
            this.btnConfirmarMesa.Text = "Confirmar";
            this.btnConfirmarMesa.UseVisualStyleBackColor = true;
            this.btnConfirmarMesa.Click += new System.EventHandler(this.btnConfirmarMesa_Click);
            // 
            // btnCancelarMesa
            // 
            this.btnCancelarMesa.Location = new System.Drawing.Point(106, 115);
            this.btnCancelarMesa.Name = "btnCancelarMesa";
            this.btnCancelarMesa.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarMesa.TabIndex = 5;
            this.btnCancelarMesa.Text = "Cancelar";
            this.btnCancelarMesa.UseVisualStyleBackColor = true;
            this.btnCancelarMesa.Click += new System.EventHandler(this.btnCancelarMesa_Click);
            // 
            // lblNroMesa
            // 
            this.lblNroMesa.AutoSize = true;
            this.lblNroMesa.Location = new System.Drawing.Point(30, 26);
            this.lblNroMesa.Name = "lblNroMesa";
            this.lblNroMesa.Size = new System.Drawing.Size(43, 13);
            this.lblNroMesa.TabIndex = 7;
            this.lblNroMesa.Text = "# Mesa";
            // 
            // lblNroSillas
            // 
            this.lblNroSillas.AutoSize = true;
            this.lblNroSillas.Location = new System.Drawing.Point(30, 77);
            this.lblNroSillas.Name = "lblNroSillas";
            this.lblNroSillas.Size = new System.Drawing.Size(41, 13);
            this.lblNroSillas.TabIndex = 8;
            this.lblNroSillas.Text = "# Sillas";
            // 
            // nmrNroSillas
            // 
            this.nmrNroSillas.Location = new System.Drawing.Point(92, 75);
            this.nmrNroSillas.Name = "nmrNroSillas";
            this.nmrNroSillas.Size = new System.Drawing.Size(39, 20);
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
            this.nmrNroMesa.Location = new System.Drawing.Point(92, 24);
            this.nmrNroMesa.Name = "nmrNroMesa";
            this.nmrNroMesa.ReadOnly = true;
            this.nmrNroMesa.Size = new System.Drawing.Size(39, 20);
            this.nmrNroMesa.TabIndex = 2;
            // 
            // frmAltaMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(203, 155);
            this.Controls.Add(this.nmrNroMesa);
            this.Controls.Add(this.nmrNroSillas);
            this.Controls.Add(this.lblNroSillas);
            this.Controls.Add(this.lblNroMesa);
            this.Controls.Add(this.btnCancelarMesa);
            this.Controls.Add(this.btnConfirmarMesa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
    }
}
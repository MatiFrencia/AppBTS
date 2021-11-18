﻿
namespace AppBTS.Presentacion
{
    partial class frmRecuperarMesas
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
            this.dgvMesasBorradas = new System.Windows.Forms.DataGridView();
            this.nroMesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadSillas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblMesasBorradas = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRecuperar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesasBorradas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMesasBorradas
            // 
            this.dgvMesasBorradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMesasBorradas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nroMesa,
            this.cantidadSillas,
            this.borrado});
            this.dgvMesasBorradas.Location = new System.Drawing.Point(18, 60);
            this.dgvMesasBorradas.Name = "dgvMesasBorradas";
            this.dgvMesasBorradas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMesasBorradas.Size = new System.Drawing.Size(341, 220);
            this.dgvMesasBorradas.TabIndex = 0;
            this.dgvMesasBorradas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMesasBorradas_CellClick);
            // 
            // nroMesa
            // 
            this.nroMesa.HeaderText = "# Mesa";
            this.nroMesa.Name = "nroMesa";
            // 
            // cantidadSillas
            // 
            this.cantidadSillas.HeaderText = "Cantidad de Sillas";
            this.cantidadSillas.Name = "cantidadSillas";
            // 
            // borrado
            // 
            this.borrado.HeaderText = "Borrado";
            this.borrado.Name = "borrado";
            // 
            // lblMesasBorradas
            // 
            this.lblMesasBorradas.AutoSize = true;
            this.lblMesasBorradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesasBorradas.Location = new System.Drawing.Point(12, 9);
            this.lblMesasBorradas.Name = "lblMesasBorradas";
            this.lblMesasBorradas.Size = new System.Drawing.Size(241, 33);
            this.lblMesasBorradas.TabIndex = 1;
            this.lblMesasBorradas.Text = "Mesas Borradas";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(284, 297);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRecuperar
            // 
            this.btnRecuperar.Location = new System.Drawing.Point(203, 297);
            this.btnRecuperar.Name = "btnRecuperar";
            this.btnRecuperar.Size = new System.Drawing.Size(75, 23);
            this.btnRecuperar.TabIndex = 4;
            this.btnRecuperar.Text = "Recuperar";
            this.btnRecuperar.UseVisualStyleBackColor = true;
            this.btnRecuperar.Click += new System.EventHandler(this.btnRecuperar_Click);
            // 
            // frmRecuperarMesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(377, 335);
            this.Controls.Add(this.btnRecuperar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblMesasBorradas);
            this.Controls.Add(this.dgvMesasBorradas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRecuperarMesas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmRecuperarMesas";
            this.Load += new System.EventHandler(this.frmRecuperarMesas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesasBorradas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMesasBorradas;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroMesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadSillas;
        private System.Windows.Forms.DataGridViewCheckBoxColumn borrado;
        private System.Windows.Forms.Label lblMesasBorradas;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRecuperar;
    }
}
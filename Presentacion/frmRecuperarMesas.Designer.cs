
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
            this.lblMesasBorradas = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRecuperar = new System.Windows.Forms.Button();
            this.nroMesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadSillas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesasBorradas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMesasBorradas
            // 
            this.dgvMesasBorradas.AllowUserToAddRows = false;
            this.dgvMesasBorradas.AllowUserToDeleteRows = false;
            this.dgvMesasBorradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMesasBorradas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nroMesa,
            this.cantidadSillas,
            this.borrado});
            this.dgvMesasBorradas.Location = new System.Drawing.Point(29, 55);
            this.dgvMesasBorradas.Name = "dgvMesasBorradas";
            this.dgvMesasBorradas.ReadOnly = true;
            this.dgvMesasBorradas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMesasBorradas.Size = new System.Drawing.Size(244, 254);
            this.dgvMesasBorradas.TabIndex = 0;
            this.dgvMesasBorradas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMesasBorradas_CellClick);
            // 
            // lblMesasBorradas
            // 
            this.lblMesasBorradas.AutoSize = true;
            this.lblMesasBorradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesasBorradas.Location = new System.Drawing.Point(14, 10);
            this.lblMesasBorradas.Name = "lblMesasBorradas";
            this.lblMesasBorradas.Size = new System.Drawing.Size(241, 33);
            this.lblMesasBorradas.TabIndex = 1;
            this.lblMesasBorradas.Text = "Mesas Borradas";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Tan;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(29, 320);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(78, 27);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRecuperar
            // 
            this.btnRecuperar.BackColor = System.Drawing.Color.Tan;
            this.btnRecuperar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecuperar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecuperar.ForeColor = System.Drawing.Color.Black;
            this.btnRecuperar.Location = new System.Drawing.Point(195, 320);
            this.btnRecuperar.Name = "btnRecuperar";
            this.btnRecuperar.Size = new System.Drawing.Size(78, 27);
            this.btnRecuperar.TabIndex = 4;
            this.btnRecuperar.Text = "Recuperar";
            this.btnRecuperar.UseVisualStyleBackColor = false;
            this.btnRecuperar.Click += new System.EventHandler(this.btnRecuperar_Click);
            // 
            // nroMesa
            // 
            this.nroMesa.HeaderText = "# Mesa";
            this.nroMesa.Name = "nroMesa";
            this.nroMesa.ReadOnly = true;
            this.nroMesa.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cantidadSillas
            // 
            this.cantidadSillas.HeaderText = "Cantidad de Sillas";
            this.cantidadSillas.Name = "cantidadSillas";
            this.cantidadSillas.ReadOnly = true;
            this.cantidadSillas.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // borrado
            // 
            this.borrado.HeaderText = "Borrado";
            this.borrado.Name = "borrado";
            this.borrado.ReadOnly = true;
            this.borrado.Visible = false;
            // 
            // frmRecuperarMesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(305, 360);
            this.Controls.Add(this.btnRecuperar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblMesasBorradas);
            this.Controls.Add(this.dgvMesasBorradas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
        private System.Windows.Forms.Label lblMesasBorradas;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRecuperar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroMesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadSillas;
        private System.Windows.Forms.DataGridViewCheckBoxColumn borrado;
    }
}
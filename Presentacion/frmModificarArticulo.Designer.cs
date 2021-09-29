
namespace AppBTS.Presentacion
{
    partial class frmModificarArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificarArticulo));
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.dgvArticulo = new System.Windows.Forms.DataGridView();
            this.IdArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrevisualizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnEditarNombre = new System.Windows.Forms.Button();
            this.btnEditarPrecio = new System.Windows.Forms.Button();
            this.btnEditarTipo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(29, 29);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(29, 79);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(76, 13);
            this.lblPrecio.TabIndex = 1;
            this.lblPrecio.Text = "Precio Unitario";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(29, 129);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(83, 13);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "Tipo de Artículo";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(156, 27);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(138, 20);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(156, 76);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(138, 20);
            this.txtPrecio.TabIndex = 4;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(156, 125);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(138, 21);
            this.cboTipo.TabIndex = 5;
            this.cboTipo.SelectedIndexChanged += new System.EventHandler(this.cboTipo_SelectedIndexChanged);
            // 
            // dgvArticulo
            // 
            this.dgvArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdArticulo,
            this.Nombre,
            this.Precio,
            this.TipoArticulo});
            this.dgvArticulo.Location = new System.Drawing.Point(12, 221);
            this.dgvArticulo.Name = "dgvArticulo";
            this.dgvArticulo.Size = new System.Drawing.Size(516, 84);
            this.dgvArticulo.TabIndex = 6;
            // 
            // IdArticulo
            // 
            this.IdArticulo.HeaderText = "Id del Artículo";
            this.IdArticulo.Name = "IdArticulo";
            this.IdArticulo.ReadOnly = true;
            this.IdArticulo.Width = 50;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Artículo";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 150;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio Unitario";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // TipoArticulo
            // 
            this.TipoArticulo.HeaderText = "Tipo de Artículo";
            this.TipoArticulo.Name = "TipoArticulo";
            this.TipoArticulo.ReadOnly = true;
            this.TipoArticulo.Width = 150;
            // 
            // btnPrevisualizar
            // 
            this.btnPrevisualizar.Location = new System.Drawing.Point(412, 162);
            this.btnPrevisualizar.Name = "btnPrevisualizar";
            this.btnPrevisualizar.Size = new System.Drawing.Size(114, 26);
            this.btnPrevisualizar.TabIndex = 7;
            this.btnPrevisualizar.Text = "Previsualizar";
            this.btnPrevisualizar.UseVisualStyleBackColor = true;
            this.btnPrevisualizar.Click += new System.EventHandler(this.btnPrevisualizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(12, 329);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 33);
            this.btnCancelar.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnCancelar, "Cancelar");
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(439, 329);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(89, 33);
            this.btnGuardar.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnGuardar, "Guardar cambios");
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEditarNombre
            // 
            this.btnEditarNombre.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarNombre.Image")));
            this.btnEditarNombre.Location = new System.Drawing.Point(300, 18);
            this.btnEditarNombre.Name = "btnEditarNombre";
            this.btnEditarNombre.Size = new System.Drawing.Size(34, 35);
            this.btnEditarNombre.TabIndex = 10;
            this.btnEditarNombre.UseVisualStyleBackColor = true;
            this.btnEditarNombre.Click += new System.EventHandler(this.btnEditarNombre_Click);
            // 
            // btnEditarPrecio
            // 
            this.btnEditarPrecio.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarPrecio.Image")));
            this.btnEditarPrecio.Location = new System.Drawing.Point(300, 68);
            this.btnEditarPrecio.Name = "btnEditarPrecio";
            this.btnEditarPrecio.Size = new System.Drawing.Size(34, 35);
            this.btnEditarPrecio.TabIndex = 11;
            this.btnEditarPrecio.UseVisualStyleBackColor = true;
            this.btnEditarPrecio.Click += new System.EventHandler(this.btnEditarPrecio_Click);
            // 
            // btnEditarTipo
            // 
            this.btnEditarTipo.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarTipo.Image")));
            this.btnEditarTipo.Location = new System.Drawing.Point(300, 118);
            this.btnEditarTipo.Name = "btnEditarTipo";
            this.btnEditarTipo.Size = new System.Drawing.Size(34, 35);
            this.btnEditarTipo.TabIndex = 12;
            this.btnEditarTipo.UseVisualStyleBackColor = true;
            this.btnEditarTipo.Click += new System.EventHandler(this.btnEditarTipo_Click);
            // 
            // frmModificarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 380);
            this.Controls.Add(this.btnEditarTipo);
            this.Controls.Add(this.btnEditarPrecio);
            this.Controls.Add(this.btnEditarNombre);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnPrevisualizar);
            this.Controls.Add(this.dgvArticulo);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblNombre);
            this.Name = "frmModificarArticulo";
            this.Text = "frmModificarArticulo";
            this.Load += new System.EventHandler(this.frmModificarArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.DataGridView dgvArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoArticulo;
        private System.Windows.Forms.Button btnPrevisualizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnEditarNombre;
        private System.Windows.Forms.Button btnEditarPrecio;
        private System.Windows.Forms.Button btnEditarTipo;
    }
}
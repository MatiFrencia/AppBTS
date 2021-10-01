
namespace AppBTS.Presentacion
{
    partial class frmConsultarMenus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarMenus));
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.lblArticulo = new System.Windows.Forms.Label();
            this.cboArticulo = new System.Windows.Forms.ComboBox();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.dgvMenus = new System.Windows.Forms.DataGridView();
            this.IdMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PcioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblId = new System.Windows.Forms.Label();
            this.txtIdMenu = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.TipoArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 31);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(62, 28);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(127, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(239, 31);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(120, 13);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "Incluye Tipo de Artículo";
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(365, 27);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(127, 21);
            this.cboTipo.TabIndex = 3;
            this.cboTipo.SelectedIndexChanged += new System.EventHandler(this.cboTipo_SelectedIndexChanged);
            // 
            // lblArticulo
            // 
            this.lblArticulo.AutoSize = true;
            this.lblArticulo.Location = new System.Drawing.Point(542, 31);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(81, 13);
            this.lblArticulo.TabIndex = 4;
            this.lblArticulo.Text = "Incluye Artículo";
            // 
            // cboArticulo
            // 
            this.cboArticulo.FormattingEnabled = true;
            this.cboArticulo.Location = new System.Drawing.Point(629, 27);
            this.cboArticulo.Name = "cboArticulo";
            this.cboArticulo.Size = new System.Drawing.Size(127, 21);
            this.cboArticulo.TabIndex = 5;
            // 
            // chkTodos
            // 
            this.chkTodos.AutoSize = true;
            this.chkTodos.Location = new System.Drawing.Point(12, 69);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(94, 17);
            this.chkTodos.TabIndex = 6;
            this.chkTodos.Text = "Mostrar Todos";
            this.chkTodos.UseVisualStyleBackColor = true;
            this.chkTodos.CheckedChanged += new System.EventHandler(this.chkTodos_CheckedChanged);
            // 
            // dgvMenus
            // 
            this.dgvMenus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMenu,
            this.NombreMenu,
            this.PcioUnitario});
            this.dgvMenus.Location = new System.Drawing.Point(12, 124);
            this.dgvMenus.Name = "dgvMenus";
            this.dgvMenus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMenus.Size = new System.Drawing.Size(431, 188);
            this.dgvMenus.TabIndex = 7;
            this.dgvMenus.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMenus_CellClick);
            // 
            // IdMenu
            // 
            this.IdMenu.HeaderText = "Id del Menú";
            this.IdMenu.Name = "IdMenu";
            this.IdMenu.ReadOnly = true;
            this.IdMenu.Width = 50;
            // 
            // NombreMenu
            // 
            this.NombreMenu.HeaderText = "Nombre";
            this.NombreMenu.Name = "NombreMenu";
            this.NombreMenu.ReadOnly = true;
            this.NombreMenu.Width = 200;
            // 
            // PcioUnitario
            // 
            this.PcioUnitario.HeaderText = "Precio Unitario";
            this.PcioUnitario.Name = "PcioUnitario";
            this.PcioUnitario.ReadOnly = true;
            this.PcioUnitario.Width = 125;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(806, 31);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(61, 13);
            this.lblId.TabIndex = 8;
            this.lblId.Text = "Id de Menú";
            // 
            // txtIdMenu
            // 
            this.txtIdMenu.Location = new System.Drawing.Point(873, 27);
            this.txtIdMenu.Name = "txtIdMenu";
            this.txtIdMenu.Size = new System.Drawing.Size(127, 20);
            this.txtIdMenu.TabIndex = 9;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Image = global::AppBTS.Properties.Resources.buscar1;
            this.btnConsultar.Location = new System.Drawing.Point(967, 60);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(33, 33);
            this.btnConsultar.TabIndex = 10;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnVisualizar.Image")));
            this.btnVisualizar.Location = new System.Drawing.Point(489, 206);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(33, 33);
            this.btnVisualizar.TabIndex = 11;
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoArticulo,
            this.NombreArticulo,
            this.Cantidad});
            this.dgvDetalles.Location = new System.Drawing.Point(568, 124);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.Size = new System.Drawing.Size(431, 188);
            this.dgvDetalles.TabIndex = 12;
            // 
            // TipoArticulo
            // 
            this.TipoArticulo.HeaderText = "Tipo de Artículo";
            this.TipoArticulo.Name = "TipoArticulo";
            this.TipoArticulo.ReadOnly = true;
            this.TipoArticulo.Width = 150;
            // 
            // NombreArticulo
            // 
            this.NombreArticulo.HeaderText = "Artículo";
            this.NombreArticulo.Name = "NombreArticulo";
            this.NombreArticulo.ReadOnly = true;
            this.NombreArticulo.Width = 175;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 50;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(12, 337);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(65, 39);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(236, 337);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(65, 39);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.Location = new System.Drawing.Point(307, 337);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(65, 39);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(378, 337);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(65, 39);
            this.btnNuevo.TabIndex = 16;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // frmConsultarMenus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1014, 388);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvDetalles);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtIdMenu);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.dgvMenus);
            this.Controls.Add(this.chkTodos);
            this.Controls.Add(this.cboArticulo);
            this.Controls.Add(this.lblArticulo);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "frmConsultarMenus";
            this.Text = "frmConsultarMenus";
            this.Load += new System.EventHandler(this.frmConsultarMenus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label lblArticulo;
        private System.Windows.Forms.ComboBox cboArticulo;
        private System.Windows.Forms.CheckBox chkTodos;
        private System.Windows.Forms.DataGridView dgvMenus;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtIdMenu;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn PcioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
    }
}
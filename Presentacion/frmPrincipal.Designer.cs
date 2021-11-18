namespace AppBTS
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnArticulos = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnMozos = new System.Windows.Forms.Button();
            this.btnReservas = new System.Windows.Forms.Button();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.btnMesas = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.asd = new System.Windows.Forms.Label();
            this.btnRHorarios = new System.Windows.Forms.Button();
            this.btnRMenus = new System.Windows.Forms.Button();
            this.btnRTickets = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.articuloToolStripMenuItem});
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // articuloToolStripMenuItem
            // 
            this.articuloToolStripMenuItem.Name = "articuloToolStripMenuItem";
            this.articuloToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.articuloToolStripMenuItem.Text = "Articulo";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Tan;
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.btnReportes);
            this.splitContainer1.Panel1.Controls.Add(this.btnArticulos);
            this.splitContainer1.Panel1.Controls.Add(this.btnMenu);
            this.splitContainer1.Panel1.Controls.Add(this.btnMozos);
            this.splitContainer1.Panel1.Controls.Add(this.btnReservas);
            this.splitContainer1.Panel1.Controls.Add(this.btnCobrar);
            this.splitContainer1.Panel1.Controls.Add(this.btnMesas);
            this.splitContainer1.Panel1.Controls.Add(this.user);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.asd);
            this.splitContainer1.Panel1.Cursor = System.Windows.Forms.Cursors.Default;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel2.BackgroundImage")));
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel2.Controls.Add(this.btnRHorarios);
            this.splitContainer1.Panel2.Controls.Add(this.btnRMenus);
            this.splitContainer1.Panel2.Controls.Add(this.btnRTickets);
            this.splitContainer1.Panel2.Controls.Add(this.btnSalir);
            this.splitContainer1.Panel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitContainer1.Size = new System.Drawing.Size(1686, 982);
            this.splitContainer1.SplitterDistance = 153;
            this.splitContainer1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(59, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Mesas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(59, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Artículo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Menús";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 535);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Mozos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 671);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Reservas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 943);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Reportes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 807);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cobrar";
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.Tan;
            this.btnReportes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReportes.BackgroundImage")));
            this.btnReportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.ForeColor = System.Drawing.Color.Tan;
            this.btnReportes.Location = new System.Drawing.Point(44, 883);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(80, 57);
            this.btnReportes.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btnReportes, "Generar Reportes.");
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnArticulos
            // 
            this.btnArticulos.BackColor = System.Drawing.Color.Tan;
            this.btnArticulos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnArticulos.BackgroundImage")));
            this.btnArticulos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArticulos.ForeColor = System.Drawing.Color.Tan;
            this.btnArticulos.Location = new System.Drawing.Point(44, 203);
            this.btnArticulos.Name = "btnArticulos";
            this.btnArticulos.Size = new System.Drawing.Size(80, 57);
            this.btnArticulos.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btnArticulos, "Consultar Artículos.");
            this.btnArticulos.UseVisualStyleBackColor = false;
            this.btnArticulos.Click += new System.EventHandler(this.btnArticulos_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Tan;
            this.btnMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMenu.BackgroundImage")));
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.ForeColor = System.Drawing.Color.Tan;
            this.btnMenu.Location = new System.Drawing.Point(44, 339);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(80, 57);
            this.btnMenu.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnMenu, "Consultar Menús.");
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnMozos
            // 
            this.btnMozos.BackColor = System.Drawing.Color.Tan;
            this.btnMozos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMozos.BackgroundImage")));
            this.btnMozos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMozos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMozos.ForeColor = System.Drawing.Color.Tan;
            this.btnMozos.Location = new System.Drawing.Point(44, 475);
            this.btnMozos.Name = "btnMozos";
            this.btnMozos.Size = new System.Drawing.Size(80, 57);
            this.btnMozos.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnMozos, "Consultar Mozos.");
            this.btnMozos.UseVisualStyleBackColor = false;
            this.btnMozos.Click += new System.EventHandler(this.btnMozos_Click);
            // 
            // btnReservas
            // 
            this.btnReservas.BackColor = System.Drawing.Color.Tan;
            this.btnReservas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReservas.BackgroundImage")));
            this.btnReservas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservas.ForeColor = System.Drawing.Color.Tan;
            this.btnReservas.Location = new System.Drawing.Point(44, 611);
            this.btnReservas.Name = "btnReservas";
            this.btnReservas.Size = new System.Drawing.Size(80, 57);
            this.btnReservas.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnReservas, "Consultar Reservas.");
            this.btnReservas.UseVisualStyleBackColor = false;
            this.btnReservas.Click += new System.EventHandler(this.btnReservas_Click);
            // 
            // btnCobrar
            // 
            this.btnCobrar.BackColor = System.Drawing.Color.Tan;
            this.btnCobrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCobrar.BackgroundImage")));
            this.btnCobrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCobrar.ForeColor = System.Drawing.Color.Tan;
            this.btnCobrar.Location = new System.Drawing.Point(44, 747);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(80, 57);
            this.btnCobrar.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnCobrar, "Realizar Cobro.");
            this.btnCobrar.UseVisualStyleBackColor = false;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // btnMesas
            // 
            this.btnMesas.BackColor = System.Drawing.Color.Tan;
            this.btnMesas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMesas.BackgroundImage")));
            this.btnMesas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMesas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMesas.ForeColor = System.Drawing.Color.Tan;
            this.btnMesas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMesas.Location = new System.Drawing.Point(44, 67);
            this.btnMesas.Name = "btnMesas";
            this.btnMesas.Size = new System.Drawing.Size(80, 57);
            this.btnMesas.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnMesas, "Consultar Mesas.");
            this.btnMesas.UseVisualStyleBackColor = false;
            this.btnMesas.Click += new System.EventHandler(this.btnMesas_Click);
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.ForeColor = System.Drawing.SystemColors.ControlText;
            this.user.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.user.Location = new System.Drawing.Point(55, 24);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(37, 19);
            this.user.TabIndex = 4;
            this.user.Text = "none";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 46);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // asd
            // 
            this.asd.AutoSize = true;
            this.asd.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.asd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.asd.Location = new System.Drawing.Point(55, 5);
            this.asd.Name = "asd";
            this.asd.Size = new System.Drawing.Size(79, 19);
            this.asd.TabIndex = 2;
            this.asd.Text = "Bienvenid@";
            // 
            // btnRHorarios
            // 
            this.btnRHorarios.BackColor = System.Drawing.Color.Transparent;
            this.btnRHorarios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRHorarios.BackgroundImage")));
            this.btnRHorarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRHorarios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRHorarios.ForeColor = System.Drawing.Color.Transparent;
            this.btnRHorarios.Location = new System.Drawing.Point(42, 947);
            this.btnRHorarios.Name = "btnRHorarios";
            this.btnRHorarios.Size = new System.Drawing.Size(80, 57);
            this.btnRHorarios.TabIndex = 21;
            this.toolTip1.SetToolTip(this.btnRHorarios, "Reporte de Horarios.");
            this.btnRHorarios.UseVisualStyleBackColor = false;
            this.btnRHorarios.Click += new System.EventHandler(this.btnRHorarios_Click);
            // 
            // btnRMenus
            // 
            this.btnRMenus.BackColor = System.Drawing.Color.Transparent;
            this.btnRMenus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRMenus.BackgroundImage")));
            this.btnRMenus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRMenus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRMenus.ForeColor = System.Drawing.Color.Transparent;
            this.btnRMenus.Location = new System.Drawing.Point(42, 883);
            this.btnRMenus.Name = "btnRMenus";
            this.btnRMenus.Size = new System.Drawing.Size(80, 57);
            this.btnRMenus.TabIndex = 20;
            this.toolTip1.SetToolTip(this.btnRMenus, "Reporte de Menús.");
            this.btnRMenus.UseVisualStyleBackColor = false;
            this.btnRMenus.Click += new System.EventHandler(this.btnRMenus_Click);
            // 
            // btnRTickets
            // 
            this.btnRTickets.BackColor = System.Drawing.Color.Transparent;
            this.btnRTickets.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRTickets.BackgroundImage")));
            this.btnRTickets.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRTickets.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRTickets.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRTickets.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRTickets.Location = new System.Drawing.Point(42, 819);
            this.btnRTickets.Name = "btnRTickets";
            this.btnRTickets.Size = new System.Drawing.Size(80, 57);
            this.btnRTickets.TabIndex = 19;
            this.btnRTickets.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRTickets.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btnRTickets, "Reporte de Artículos.");
            this.btnRTickets.UseVisualStyleBackColor = false;
            this.btnRTickets.Click += new System.EventHandler(this.btnRTickets_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Image = global::AppBTS.Properties.Resources.logout_door;
            this.btnSalir.Location = new System.Drawing.Point(1452, 921);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(63, 47);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnSalir, "Salir del sistema.");
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1686, 982);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articuloToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label asd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMesas;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnArticulos;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnMozos;
        private System.Windows.Forms.Button btnReservas;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnRHorarios;
        private System.Windows.Forms.Button btnRMenus;
        private System.Windows.Forms.Button btnRTickets;
    }
}


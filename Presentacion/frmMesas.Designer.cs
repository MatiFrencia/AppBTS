
namespace AppBTS.Presentacion
{
    partial class frmMesas
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.añadirMesaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recuperarMesasBorradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirMesaToolStripMenuItem,
            this.recuperarMesasBorradaToolStripMenuItem,
            this.actualizarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // añadirMesaToolStripMenuItem
            // 
            this.añadirMesaToolStripMenuItem.Name = "añadirMesaToolStripMenuItem";
            this.añadirMesaToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.añadirMesaToolStripMenuItem.Text = "Añadir Mesa...";
            this.añadirMesaToolStripMenuItem.Click += new System.EventHandler(this.añadirMesaToolStripMenuItem_Click);
            // 
            // recuperarMesasBorradaToolStripMenuItem
            // 
            this.recuperarMesasBorradaToolStripMenuItem.Name = "recuperarMesasBorradaToolStripMenuItem";
            this.recuperarMesasBorradaToolStripMenuItem.Size = new System.Drawing.Size(157, 20);
            this.recuperarMesasBorradaToolStripMenuItem.Text = "Recuperar Mesas Borradas";
            this.recuperarMesasBorradaToolStripMenuItem.Click += new System.EventHandler(this.recuperarMesasBorradaToolStripMenuItem_Click);
            // 
            // actualizarToolStripMenuItem
            // 
            this.actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            this.actualizarToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.actualizarToolStripMenuItem.Text = "Actualizar";
            this.actualizarToolStripMenuItem.Click += new System.EventHandler(this.actualizarToolStripMenuItem_Click);
            // 
            // frmMesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(800, 633);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmMesas";
            this.Text = "Mesas";
            this.Load += new System.EventHandler(this.frmMesas_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem añadirMesaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recuperarMesasBorradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem;
    }
}

namespace AppBTS.Presentacion
{
    partial class frmDetalleMenu
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
            this.lbTitulo = new System.Windows.Forms.Label();
            this.txtbIdMenu = new System.Windows.Forms.TextBox();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.txtbPrecio = new System.Windows.Forms.TextBox();
            this.lblIdMenu = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbTitulo.Location = new System.Drawing.Point(12, 18);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(128, 25);
            this.lbTitulo.TabIndex = 18;
            this.lbTitulo.Text = "Editar Menú";
            // 
            // txtbIdMenu
            // 
            this.txtbIdMenu.Enabled = false;
            this.txtbIdMenu.Location = new System.Drawing.Point(124, 88);
            this.txtbIdMenu.Name = "txtbIdMenu";
            this.txtbIdMenu.Size = new System.Drawing.Size(100, 20);
            this.txtbIdMenu.TabIndex = 19;
            // 
            // txtbNombre
            // 
            this.txtbNombre.Location = new System.Drawing.Point(124, 132);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(100, 20);
            this.txtbNombre.TabIndex = 20;
            // 
            // txtbPrecio
            // 
            this.txtbPrecio.Location = new System.Drawing.Point(124, 170);
            this.txtbPrecio.Name = "txtbPrecio";
            this.txtbPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtbPrecio.TabIndex = 21;
            // 
            // lblIdMenu
            // 
            this.lblIdMenu.AutoSize = true;
            this.lblIdMenu.Location = new System.Drawing.Point(36, 91);
            this.lblIdMenu.Name = "lblIdMenu";
            this.lblIdMenu.Size = new System.Drawing.Size(47, 13);
            this.lblIdMenu.TabIndex = 22;
            this.lblIdMenu.Text = "ID menú";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(39, 132);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 23;
            this.lblNombre.Text = "Nombre";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(42, 170);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 24;
            this.lblPrecio.Text = "Precio";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(39, 217);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 25;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(149, 217);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmDetalleMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(263, 252);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblIdMenu);
            this.Controls.Add(this.txtbPrecio);
            this.Controls.Add(this.txtbNombre);
            this.Controls.Add(this.txtbIdMenu);
            this.Controls.Add(this.lbTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDetalleMenu";
            this.Text = "frmDetalleMenu";
            this.Load += new System.EventHandler(this.frmDetalleMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.TextBox txtbIdMenu;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.TextBox txtbPrecio;
        private System.Windows.Forms.Label lblIdMenu;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
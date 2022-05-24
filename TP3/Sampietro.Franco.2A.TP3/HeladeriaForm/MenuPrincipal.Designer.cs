
namespace HeladeriaForm
{
    partial class MenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbProductos = new System.Windows.Forms.ListBox();
            this.pbarPedido = new System.Windows.Forms.ProgressBar();
            this.btnAgregarCarrito = new System.Windows.Forms.Button();
            this.lbCarrito = new System.Windows.Forms.ListBox();
            this.txtbInformacion = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCarrito = new System.Windows.Forms.Label();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.lblPaletas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbProductos
            // 
            this.lbProductos.BackColor = System.Drawing.SystemColors.Menu;
            this.lbProductos.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbProductos.FormattingEnabled = true;
            this.lbProductos.ItemHeight = 21;
            this.lbProductos.Location = new System.Drawing.Point(12, 200);
            this.lbProductos.Name = "lbProductos";
            this.lbProductos.Size = new System.Drawing.Size(287, 256);
            this.lbProductos.TabIndex = 0;
            // 
            // pbarPedido
            // 
            this.pbarPedido.Location = new System.Drawing.Point(12, 12);
            this.pbarPedido.Name = "pbarPedido";
            this.pbarPedido.Size = new System.Drawing.Size(614, 23);
            this.pbarPedido.TabIndex = 1;
            // 
            // btnAgregarCarrito
            // 
            this.btnAgregarCarrito.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarCarrito.Location = new System.Drawing.Point(74, 480);
            this.btnAgregarCarrito.Name = "btnAgregarCarrito";
            this.btnAgregarCarrito.Size = new System.Drawing.Size(155, 40);
            this.btnAgregarCarrito.TabIndex = 2;
            this.btnAgregarCarrito.Text = "Agregar al carrito";
            this.btnAgregarCarrito.UseVisualStyleBackColor = true;
            // 
            // lbCarrito
            // 
            this.lbCarrito.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbCarrito.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCarrito.FormattingEnabled = true;
            this.lbCarrito.ItemHeight = 21;
            this.lbCarrito.Location = new System.Drawing.Point(352, 368);
            this.lbCarrito.Name = "lbCarrito";
            this.lbCarrito.Size = new System.Drawing.Size(239, 88);
            this.lbCarrito.TabIndex = 3;
            // 
            // txtbInformacion
            // 
            this.txtbInformacion.BackColor = System.Drawing.Color.Khaki;
            this.txtbInformacion.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtbInformacion.Location = new System.Drawing.Point(352, 203);
            this.txtbInformacion.Multiline = true;
            this.txtbInformacion.Name = "txtbInformacion";
            this.txtbInformacion.ReadOnly = true;
            this.txtbInformacion.Size = new System.Drawing.Size(239, 111);
            this.txtbInformacion.TabIndex = 4;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Sitka Small", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(131, 59);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(393, 48);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Heladería Gustos Finos";
            // 
            // lblCarrito
            // 
            this.lblCarrito.AutoSize = true;
            this.lblCarrito.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCarrito.Location = new System.Drawing.Point(422, 326);
            this.lblCarrito.Name = "lblCarrito";
            this.lblCarrito.Size = new System.Drawing.Size(102, 35);
            this.lblCarrito.TabIndex = 6;
            this.lblCarrito.Text = "Carrito";
            // 
            // lblInformacion
            // 
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInformacion.Location = new System.Drawing.Point(389, 158);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(166, 35);
            this.lblInformacion.TabIndex = 7;
            this.lblInformacion.Text = "Informacion";
            // 
            // lblPaletas
            // 
            this.lblPaletas.AutoSize = true;
            this.lblPaletas.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPaletas.Location = new System.Drawing.Point(50, 155);
            this.lblPaletas.Name = "lblPaletas";
            this.lblPaletas.Size = new System.Drawing.Size(218, 35);
            this.lblPaletas.TabIndex = 8;
            this.lblPaletas.Text = "Nuestras paletas";
            // 
            // MenuPrincipal
            // 
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(638, 547);
            this.Controls.Add(this.lblPaletas);
            this.Controls.Add(this.lblInformacion);
            this.Controls.Add(this.lblCarrito);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtbInformacion);
            this.Controls.Add(this.lbCarrito);
            this.Controls.Add(this.btnAgregarCarrito);
            this.Controls.Add(this.pbarPedido);
            this.Controls.Add(this.lbProductos);
            this.Name = "MenuPrincipal";
            this.Text = "Sampietro Franco 2A TP3";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbProductos;
        private System.Windows.Forms.ProgressBar pbarPedido;
        private System.Windows.Forms.Button btnAgregarCarrito;
        private System.Windows.Forms.ListBox lbCarrito;
        private System.Windows.Forms.TextBox txtbInformacion;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCarrito;
        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.Label lblPaletas;
    }
}


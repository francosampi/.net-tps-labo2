
namespace MenuAgregarForm
{
    partial class frmMenuAlumno
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.nupAbonado = new System.Windows.Forms.NumericUpDown();
            this.lblTotalAbonado = new System.Windows.Forms.Label();
            this.cbNacionalidad = new System.Windows.Forms.ComboBox();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.lblTipoDePago = new System.Windows.Forms.Label();
            this.cbTipoDePago = new System.Windows.Forms.ComboBox();
            this.cbCurso = new System.Windows.Forms.ComboBox();
            this.lblCurso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nupAbonado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.Location = new System.Drawing.Point(13, 261);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(125, 37);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Guardar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(144, 261);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(125, 37);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(13, 35);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.PlaceholderText = "Nombre completo";
            this.tbNombre.Size = new System.Drawing.Size(253, 23);
            this.tbNombre.TabIndex = 11;
            this.tbNombre.TextChanged += new System.EventHandler(this.tbNombre_TextChanged);
            // 
            // tbMail
            // 
            this.tbMail.BackColor = System.Drawing.SystemColors.Window;
            this.tbMail.Location = new System.Drawing.Point(12, 73);
            this.tbMail.Name = "tbMail";
            this.tbMail.PlaceholderText = "Direccion de correo electrónico";
            this.tbMail.Size = new System.Drawing.Size(254, 23);
            this.tbMail.TabIndex = 12;
            this.tbMail.TextChanged += new System.EventHandler(this.tbMail_TextChanged);
            // 
            // nupAbonado
            // 
            this.nupAbonado.DecimalPlaces = 1;
            this.nupAbonado.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nupAbonado.Location = new System.Drawing.Point(381, 36);
            this.nupAbonado.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nupAbonado.Name = "nupAbonado";
            this.nupAbonado.Size = new System.Drawing.Size(120, 23);
            this.nupAbonado.TabIndex = 14;
            this.nupAbonado.ValueChanged += new System.EventHandler(this.nupAbonado_ValueChanged);
            // 
            // lblTotalAbonado
            // 
            this.lblTotalAbonado.AutoSize = true;
            this.lblTotalAbonado.Location = new System.Drawing.Point(293, 38);
            this.lblTotalAbonado.Name = "lblTotalAbonado";
            this.lblTotalAbonado.Size = new System.Drawing.Size(82, 15);
            this.lblTotalAbonado.TabIndex = 15;
            this.lblTotalAbonado.Text = "Total abonado";
            // 
            // cbNacionalidad
            // 
            this.cbNacionalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNacionalidad.FormattingEnabled = true;
            this.cbNacionalidad.Location = new System.Drawing.Point(380, 75);
            this.cbNacionalidad.Name = "cbNacionalidad";
            this.cbNacionalidad.Size = new System.Drawing.Size(254, 23);
            this.cbNacionalidad.TabIndex = 16;
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Location = new System.Drawing.Point(293, 78);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(77, 15);
            this.lblNacionalidad.TabIndex = 17;
            this.lblNacionalidad.Text = "Nacionalidad";
            // 
            // lblTipoDePago
            // 
            this.lblTipoDePago.AutoSize = true;
            this.lblTipoDePago.Location = new System.Drawing.Point(293, 121);
            this.lblTipoDePago.Name = "lblTipoDePago";
            this.lblTipoDePago.Size = new System.Drawing.Size(76, 15);
            this.lblTipoDePago.TabIndex = 18;
            this.lblTipoDePago.Text = "Tipo de pago";
            // 
            // cbTipoDePago
            // 
            this.cbTipoDePago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoDePago.FormattingEnabled = true;
            this.cbTipoDePago.Location = new System.Drawing.Point(380, 118);
            this.cbTipoDePago.Name = "cbTipoDePago";
            this.cbTipoDePago.Size = new System.Drawing.Size(254, 23);
            this.cbTipoDePago.TabIndex = 19;
            // 
            // cbCurso
            // 
            this.cbCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCurso.FormattingEnabled = true;
            this.cbCurso.Location = new System.Drawing.Point(380, 158);
            this.cbCurso.Name = "cbCurso";
            this.cbCurso.Size = new System.Drawing.Size(254, 23);
            this.cbCurso.TabIndex = 21;
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(310, 161);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(38, 15);
            this.lblCurso.TabIndex = 20;
            this.lblCurso.Text = "Curso";
            // 
            // frmMenuAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(646, 310);
            this.Controls.Add(this.cbCurso);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.cbTipoDePago);
            this.Controls.Add(this.lblTipoDePago);
            this.Controls.Add(this.lblNacionalidad);
            this.Controls.Add(this.cbNacionalidad);
            this.Controls.Add(this.lblTotalAbonado);
            this.Controls.Add(this.nupAbonado);
            this.Controls.Add(this.tbMail);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMenuAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sampietro Franco TP3 (Agregar)";
            this.Load += new System.EventHandler(this.frmAgregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupAbonado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.NumericUpDown nupAbonado;
        private System.Windows.Forms.Label lblTotalAbonado;
        private System.Windows.Forms.ComboBox cbNacionalidad;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.Label lblTipoDePago;
        private System.Windows.Forms.ComboBox cbTipoDePago;
        private System.Windows.Forms.ComboBox cbCurso;
        private System.Windows.Forms.Label lblCurso;
    }
}


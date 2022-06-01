
namespace MenuAgregarProfesorForm
{
    partial class frmMenuProfesor
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
            this.tbMail = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbMail
            // 
            this.tbMail.BackColor = System.Drawing.SystemColors.Window;
            this.tbMail.Location = new System.Drawing.Point(12, 78);
            this.tbMail.Name = "tbMail";
            this.tbMail.PlaceholderText = "Direccion de correo electrónico";
            this.tbMail.Size = new System.Drawing.Size(254, 23);
            this.tbMail.TabIndex = 14;
            this.tbMail.TextChanged += new System.EventHandler(this.tbMail_TextChanged);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(13, 40);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.PlaceholderText = "Nombre completo";
            this.tbNombre.Size = new System.Drawing.Size(253, 23);
            this.tbNombre.TabIndex = 13;
            this.tbNombre.TextChanged += new System.EventHandler(this.tbNombre_TextChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(144, 187);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(125, 37);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.Location = new System.Drawing.Point(13, 187);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(125, 37);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "Guardar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // frmMenuProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 236);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.tbMail);
            this.Controls.Add(this.tbNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMenuProfesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sampietro Franco TP3 (Agregar)";
            this.Load += new System.EventHandler(this.frmMenuProfesor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
    }
}


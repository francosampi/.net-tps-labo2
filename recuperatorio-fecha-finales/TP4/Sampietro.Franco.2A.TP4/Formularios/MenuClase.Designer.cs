
namespace Formularios
{
    partial class frmMenuClase
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
            this.lblDocente = new System.Windows.Forms.Label();
            this.cbDocente = new System.Windows.Forms.ComboBox();
            this.lblHorario = new System.Windows.Forms.Label();
            this.cbHorario = new System.Windows.Forms.ComboBox();
            this.lblCurso = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tbCurso = new System.Windows.Forms.TextBox();
            this.cbDias = new System.Windows.Forms.ComboBox();
            this.lblDias = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDocente
            // 
            this.lblDocente.AutoSize = true;
            this.lblDocente.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDocente.Location = new System.Drawing.Point(205, 34);
            this.lblDocente.Name = "lblDocente";
            this.lblDocente.Size = new System.Drawing.Size(83, 22);
            this.lblDocente.TabIndex = 9;
            this.lblDocente.Text = "Docente";
            // 
            // cbDocente
            // 
            this.cbDocente.FormattingEnabled = true;
            this.cbDocente.Location = new System.Drawing.Point(143, 59);
            this.cbDocente.Name = "cbDocente";
            this.cbDocente.Size = new System.Drawing.Size(203, 23);
            this.cbDocente.TabIndex = 10;
            this.cbDocente.SelectedIndexChanged += new System.EventHandler(this.cbDocente_SelectedIndexChanged);
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHorario.Location = new System.Drawing.Point(205, 255);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(79, 22);
            this.lblHorario.TabIndex = 11;
            this.lblHorario.Text = "Horario";
            // 
            // cbHorario
            // 
            this.cbHorario.FormattingEnabled = true;
            this.cbHorario.Location = new System.Drawing.Point(143, 280);
            this.cbHorario.Name = "cbHorario";
            this.cbHorario.Size = new System.Drawing.Size(203, 23);
            this.cbHorario.TabIndex = 12;
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCurso.Location = new System.Drawing.Point(214, 105);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(62, 22);
            this.lblCurso.TabIndex = 13;
            this.lblCurso.Text = "Curso";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.Location = new System.Drawing.Point(12, 359);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(232, 37);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Guardar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(250, 359);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(245, 37);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tbCurso
            // 
            this.tbCurso.Location = new System.Drawing.Point(143, 130);
            this.tbCurso.Name = "tbCurso";
            this.tbCurso.ReadOnly = true;
            this.tbCurso.Size = new System.Drawing.Size(203, 23);
            this.tbCurso.TabIndex = 18;
            // 
            // cbDias
            // 
            this.cbDias.FormattingEnabled = true;
            this.cbDias.Location = new System.Drawing.Point(143, 203);
            this.cbDias.Name = "cbDias";
            this.cbDias.Size = new System.Drawing.Size(203, 23);
            this.cbDias.TabIndex = 21;
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDias.Location = new System.Drawing.Point(220, 178);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(49, 22);
            this.lblDias.TabIndex = 20;
            this.lblDias.Text = "Dias";
            // 
            // frmMenuClase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(507, 405);
            this.Controls.Add(this.cbDias);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.tbCurso);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.cbHorario);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.cbDocente);
            this.Controls.Add(this.lblDocente);
            this.Name = "frmMenuClase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar clase";
            this.Load += new System.EventHandler(this.frmMenuClase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDocente;
        private System.Windows.Forms.ComboBox cbDocente;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.ComboBox cbHorario;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox tbCurso;
        private System.Windows.Forms.ComboBox cbDias;
        private System.Windows.Forms.Label lblDias;
    }
}
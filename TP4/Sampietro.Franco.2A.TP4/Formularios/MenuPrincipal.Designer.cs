
namespace MenuPrincipalForm
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
            this.btnClases = new System.Windows.Forms.Button();
            this.btnProfesores = new System.Windows.Forms.Button();
            this.btnAlumnos = new System.Windows.Forms.Button();
            this.lbListado = new System.Windows.Forms.ListBox();
            this.tbDetalles = new System.Windows.Forms.TextBox();
            this.lblDetalles = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnGuardarXML = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnModoOscuro = new System.Windows.Forms.Button();
            this.pbLogoInstituto = new System.Windows.Forms.PictureBox();
            this.btnPlanillaNotas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoInstituto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClases
            // 
            this.btnClases.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClases.Location = new System.Drawing.Point(273, 25);
            this.btnClases.Name = "btnClases";
            this.btnClases.Size = new System.Drawing.Size(124, 37);
            this.btnClases.TabIndex = 2;
            this.btnClases.Text = "Clases";
            this.btnClases.UseVisualStyleBackColor = true;
            this.btnClases.Click += new System.EventHandler(this.btnClases_Click);
            // 
            // btnProfesores
            // 
            this.btnProfesores.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProfesores.Location = new System.Drawing.Point(143, 24);
            this.btnProfesores.Name = "btnProfesores";
            this.btnProfesores.Size = new System.Drawing.Size(124, 37);
            this.btnProfesores.TabIndex = 1;
            this.btnProfesores.Text = "Profesores";
            this.btnProfesores.UseVisualStyleBackColor = true;
            this.btnProfesores.Click += new System.EventHandler(this.btnProfesores_Click);
            // 
            // btnAlumnos
            // 
            this.btnAlumnos.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAlumnos.Location = new System.Drawing.Point(12, 24);
            this.btnAlumnos.Name = "btnAlumnos";
            this.btnAlumnos.Size = new System.Drawing.Size(124, 37);
            this.btnAlumnos.TabIndex = 0;
            this.btnAlumnos.Text = "Alumnos";
            this.btnAlumnos.UseVisualStyleBackColor = true;
            this.btnAlumnos.Click += new System.EventHandler(this.btnAlumnos_Click);
            // 
            // lbListado
            // 
            this.lbListado.FormattingEnabled = true;
            this.lbListado.ItemHeight = 15;
            this.lbListado.Location = new System.Drawing.Point(13, 68);
            this.lbListado.Name = "lbListado";
            this.lbListado.Size = new System.Drawing.Size(384, 379);
            this.lbListado.TabIndex = 6;
            this.lbListado.SelectedIndexChanged += new System.EventHandler(this.lbListado_SelectedIndexChanged);
            // 
            // tbDetalles
            // 
            this.tbDetalles.Location = new System.Drawing.Point(437, 285);
            this.tbDetalles.Multiline = true;
            this.tbDetalles.Name = "tbDetalles";
            this.tbDetalles.Size = new System.Drawing.Size(324, 205);
            this.tbDetalles.TabIndex = 7;
            // 
            // lblDetalles
            // 
            this.lblDetalles.AutoSize = true;
            this.lblDetalles.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDetalles.Location = new System.Drawing.Point(564, 248);
            this.lblDetalles.Name = "lblDetalles";
            this.lblDetalles.Size = new System.Drawing.Size(81, 22);
            this.lblDetalles.TabIndex = 6;
            this.lblDetalles.Text = "Detalles";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.Location = new System.Drawing.Point(13, 453);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(125, 37);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.LightCoral;
            this.btnRemover.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemover.Location = new System.Drawing.Point(272, 453);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(125, 37);
            this.btnRemover.TabIndex = 4;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnGuardarXML
            // 
            this.btnGuardarXML.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuardarXML.Location = new System.Drawing.Point(13, 502);
            this.btnGuardarXML.Name = "btnGuardarXML";
            this.btnGuardarXML.Size = new System.Drawing.Size(384, 37);
            this.btnGuardarXML.TabIndex = 8;
            this.btnGuardarXML.Text = "Guardar XML";
            this.btnGuardarXML.UseVisualStyleBackColor = true;
            this.btnGuardarXML.Click += new System.EventHandler(this.btnGuardarXML_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnModificar.Location = new System.Drawing.Point(144, 453);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(125, 37);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnModoOscuro
            // 
            this.btnModoOscuro.BackgroundImage = global::Formularios.Properties.Resources.modoOscuro01;
            this.btnModoOscuro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModoOscuro.Location = new System.Drawing.Point(729, 27);
            this.btnModoOscuro.Name = "btnModoOscuro";
            this.btnModoOscuro.Size = new System.Drawing.Size(32, 32);
            this.btnModoOscuro.TabIndex = 10;
            this.btnModoOscuro.UseVisualStyleBackColor = true;
            this.btnModoOscuro.Click += new System.EventHandler(this.btnModoOscuro_Click);
            // 
            // pbLogoInstituto
            // 
            this.pbLogoInstituto.BackgroundImage = global::Formularios.Properties.Resources.davinci01;
            this.pbLogoInstituto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogoInstituto.Location = new System.Drawing.Point(437, 68);
            this.pbLogoInstituto.Name = "pbLogoInstituto";
            this.pbLogoInstituto.Size = new System.Drawing.Size(324, 90);
            this.pbLogoInstituto.TabIndex = 11;
            this.pbLogoInstituto.TabStop = false;
            // 
            // btnPlanillaNotas
            // 
            this.btnPlanillaNotas.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPlanillaNotas.Location = new System.Drawing.Point(437, 502);
            this.btnPlanillaNotas.Name = "btnPlanillaNotas";
            this.btnPlanillaNotas.Size = new System.Drawing.Size(324, 37);
            this.btnPlanillaNotas.TabIndex = 12;
            this.btnPlanillaNotas.Text = "Planilla de notas";
            this.btnPlanillaNotas.UseVisualStyleBackColor = true;
            this.btnPlanillaNotas.Click += new System.EventHandler(this.btnPlanillaNotas_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 551);
            this.Controls.Add(this.btnPlanillaNotas);
            this.Controls.Add(this.pbLogoInstituto);
            this.Controls.Add(this.btnModoOscuro);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardarXML);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblDetalles);
            this.Controls.Add(this.tbDetalles);
            this.Controls.Add(this.lbListado);
            this.Controls.Add(this.btnAlumnos);
            this.Controls.Add(this.btnProfesores);
            this.Controls.Add(this.btnClases);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoInstituto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClases;
        private System.Windows.Forms.Button btnProfesores;
        private System.Windows.Forms.Button btnAlumnos;
        private System.Windows.Forms.ListBox lbListado;
        private System.Windows.Forms.TextBox tbDetalles;
        private System.Windows.Forms.Label lblDetalles;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnGuardarXML;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnModoOscuro;
        private System.Windows.Forms.PictureBox pbLogoInstituto;
        private System.Windows.Forms.Button btnPlanillaNotas;
    }
}
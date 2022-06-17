
namespace Formularios
{
    partial class frmPlanillaNotas
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
            this.dgPlanilla = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProgramacionDeVideojuegos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DibujoDeComics = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diseno3DEnBlender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisenoGrafico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProgramacionWeb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Promedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardarBaseDatos = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPlanilla)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPlanilla
            // 
            this.dgPlanilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPlanilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Alumno,
            this.ProgramacionDeVideojuegos,
            this.DibujoDeComics,
            this.Diseno3DEnBlender,
            this.DisenoGrafico,
            this.ProgramacionWeb,
            this.Promedio});
            this.dgPlanilla.Location = new System.Drawing.Point(21, 26);
            this.dgPlanilla.MultiSelect = false;
            this.dgPlanilla.Name = "dgPlanilla";
            this.dgPlanilla.RowTemplate.Height = 25;
            this.dgPlanilla.Size = new System.Drawing.Size(846, 369);
            this.dgPlanilla.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 40;
            // 
            // Alumno
            // 
            this.Alumno.HeaderText = "Alumno";
            this.Alumno.Name = "Alumno";
            this.Alumno.Width = 160;
            // 
            // ProgramacionDeVideojuegos
            // 
            this.ProgramacionDeVideojuegos.HeaderText = "Programacion de videojuegos";
            this.ProgramacionDeVideojuegos.Name = "ProgramacionDeVideojuegos";
            // 
            // DibujoDeComics
            // 
            this.DibujoDeComics.HeaderText = "Dibujo de comics";
            this.DibujoDeComics.Name = "DibujoDeComics";
            // 
            // Diseno3DEnBlender
            // 
            this.Diseno3DEnBlender.HeaderText = "Diseño 3D en Blender";
            this.Diseno3DEnBlender.Name = "Diseno3DEnBlender";
            // 
            // DisenoGrafico
            // 
            this.DisenoGrafico.HeaderText = "Diseño Gráfico";
            this.DisenoGrafico.Name = "DisenoGrafico";
            // 
            // ProgramacionWeb
            // 
            this.ProgramacionWeb.HeaderText = "Programacion Web";
            this.ProgramacionWeb.Name = "ProgramacionWeb";
            // 
            // Promedio
            // 
            this.Promedio.HeaderText = "Promedio";
            this.Promedio.Name = "Promedio";
            // 
            // btnGuardarBaseDatos
            // 
            this.btnGuardarBaseDatos.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuardarBaseDatos.Location = new System.Drawing.Point(206, 401);
            this.btnGuardarBaseDatos.Name = "btnGuardarBaseDatos";
            this.btnGuardarBaseDatos.Size = new System.Drawing.Size(467, 37);
            this.btnGuardarBaseDatos.TabIndex = 9;
            this.btnGuardarBaseDatos.Text = "Guardar en base de datos";
            this.btnGuardarBaseDatos.UseVisualStyleBackColor = true;
            this.btnGuardarBaseDatos.Click += new System.EventHandler(this.btnGuardarBaseDatos_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCerrar.Location = new System.Drawing.Point(679, 401);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(188, 37);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNuevo.Location = new System.Drawing.Point(12, 401);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(188, 37);
            this.btnNuevo.TabIndex = 11;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // frmPlanillaNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 450);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnGuardarBaseDatos);
            this.Controls.Add(this.dgPlanilla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPlanillaNotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Planilla de notas";
            this.Load += new System.EventHandler(this.frmPlanillaNotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPlanilla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPlanilla;
        private System.Windows.Forms.Button btnGuardarBaseDatos;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProgramacionDeVideojuegos;
        private System.Windows.Forms.DataGridViewTextBoxColumn DibujoDeComics;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diseno3DEnBlender;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisenoGrafico;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProgramacionWeb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Promedio;
    }
}
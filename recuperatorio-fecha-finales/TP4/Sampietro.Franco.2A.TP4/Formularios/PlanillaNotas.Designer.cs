
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
            this.DisenoGrafico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisenoEnBlender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProgramacionWeb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardarBaseDatos = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnPromedio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPlanilla)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPlanilla
            // 
            this.dgPlanilla.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgPlanilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPlanilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Alumno,
            this.ProgramacionDeVideojuegos,
            this.DibujoDeComics,
            this.DisenoGrafico,
            this.DisenoEnBlender,
            this.ProgramacionWeb});
            this.dgPlanilla.Location = new System.Drawing.Point(17, 93);
            this.dgPlanilla.MultiSelect = false;
            this.dgPlanilla.Name = "dgPlanilla";
            this.dgPlanilla.ReadOnly = true;
            this.dgPlanilla.RowTemplate.Height = 25;
            this.dgPlanilla.Size = new System.Drawing.Size(746, 312);
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
            this.Alumno.ReadOnly = true;
            this.Alumno.Width = 160;
            // 
            // ProgramacionDeVideojuegos
            // 
            this.ProgramacionDeVideojuegos.HeaderText = "Programacion de videojuegos";
            this.ProgramacionDeVideojuegos.Name = "ProgramacionDeVideojuegos";
            this.ProgramacionDeVideojuegos.ReadOnly = true;
            // 
            // DibujoDeComics
            // 
            this.DibujoDeComics.HeaderText = "Dibujo de comics";
            this.DibujoDeComics.Name = "DibujoDeComics";
            this.DibujoDeComics.ReadOnly = true;
            // 
            // DisenoGrafico
            // 
            this.DisenoGrafico.HeaderText = "Diseño Gráfico";
            this.DisenoGrafico.Name = "DisenoGrafico";
            this.DisenoGrafico.ReadOnly = true;
            // 
            // DisenoEnBlender
            // 
            this.DisenoEnBlender.HeaderText = "Diseño 3D en Blender";
            this.DisenoEnBlender.Name = "DisenoEnBlender";
            this.DisenoEnBlender.ReadOnly = true;
            // 
            // ProgramacionWeb
            // 
            this.ProgramacionWeb.HeaderText = "Programacion Web";
            this.ProgramacionWeb.Name = "ProgramacionWeb";
            this.ProgramacionWeb.ReadOnly = true;
            // 
            // btnGuardarBaseDatos
            // 
            this.btnGuardarBaseDatos.BackColor = System.Drawing.Color.GreenYellow;
            this.btnGuardarBaseDatos.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuardarBaseDatos.Location = new System.Drawing.Point(17, 12);
            this.btnGuardarBaseDatos.Name = "btnGuardarBaseDatos";
            this.btnGuardarBaseDatos.Size = new System.Drawing.Size(150, 37);
            this.btnGuardarBaseDatos.TabIndex = 9;
            this.btnGuardarBaseDatos.Text = "Agregar";
            this.btnGuardarBaseDatos.UseVisualStyleBackColor = false;
            this.btnGuardarBaseDatos.Click += new System.EventHandler(this.btnGuardarBaseDatos_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCerrar.Location = new System.Drawing.Point(485, 411);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(279, 37);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Cyan;
            this.btnModificar.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnModificar.Location = new System.Drawing.Point(211, 12);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(150, 37);
            this.btnModificar.TabIndex = 13;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.OrangeRed;
            this.btnRemover.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemover.Location = new System.Drawing.Point(412, 12);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(150, 37);
            this.btnRemover.TabIndex = 14;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnPromedio
            // 
            this.btnPromedio.BackColor = System.Drawing.Color.Fuchsia;
            this.btnPromedio.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPromedio.Location = new System.Drawing.Point(613, 12);
            this.btnPromedio.Name = "btnPromedio";
            this.btnPromedio.Size = new System.Drawing.Size(150, 37);
            this.btnPromedio.TabIndex = 16;
            this.btnPromedio.Text = "Promedio";
            this.btnPromedio.UseVisualStyleBackColor = false;
            this.btnPromedio.Click += new System.EventHandler(this.btnPromedio_Click);
            // 
            // frmPlanillaNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 458);
            this.Controls.Add(this.btnPromedio);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnModificar);
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
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProgramacionDeVideojuegos;
        private System.Windows.Forms.DataGridViewTextBoxColumn DibujoDeComics;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisenoGrafico;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisenoEnBlender;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProgramacionWeb;
        private System.Windows.Forms.Button btnPromedio;
    }
}
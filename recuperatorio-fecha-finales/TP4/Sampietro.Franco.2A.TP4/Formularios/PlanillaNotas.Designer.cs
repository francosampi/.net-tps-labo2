
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
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbAlumno = new System.Windows.Forms.TextBox();
            this.tbProgVj = new System.Windows.Forms.TextBox();
            this.tbDibujo = new System.Windows.Forms.TextBox();
            this.tbDisenoG = new System.Windows.Forms.TextBox();
            this.tbDisenoB = new System.Windows.Forms.TextBox();
            this.tbProgW = new System.Windows.Forms.TextBox();
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
            this.dgPlanilla.Location = new System.Drawing.Point(20, 206);
            this.dgPlanilla.MultiSelect = false;
            this.dgPlanilla.Name = "dgPlanilla";
            this.dgPlanilla.ReadOnly = true;
            this.dgPlanilla.RowTemplate.Height = 25;
            this.dgPlanilla.Size = new System.Drawing.Size(746, 295);
            this.dgPlanilla.TabIndex = 0;
            this.dgPlanilla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPlanilla_CellClick);
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
            this.btnGuardarBaseDatos.Location = new System.Drawing.Point(20, 108);
            this.btnGuardarBaseDatos.Name = "btnGuardarBaseDatos";
            this.btnGuardarBaseDatos.Size = new System.Drawing.Size(150, 37);
            this.btnGuardarBaseDatos.TabIndex = 9;
            this.btnGuardarBaseDatos.Text = "Guardar";
            this.btnGuardarBaseDatos.UseVisualStyleBackColor = false;
            this.btnGuardarBaseDatos.Click += new System.EventHandler(this.btnGuardarBaseDatos_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCerrar.Location = new System.Drawing.Point(488, 507);
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
            this.btnModificar.Location = new System.Drawing.Point(214, 108);
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
            this.btnRemover.Location = new System.Drawing.Point(415, 108);
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
            this.btnPromedio.Location = new System.Drawing.Point(616, 108);
            this.btnPromedio.Name = "btnPromedio";
            this.btnPromedio.Size = new System.Drawing.Size(150, 37);
            this.btnPromedio.TabIndex = 16;
            this.btnPromedio.Text = "Promedio";
            this.btnPromedio.UseVisualStyleBackColor = false;
            this.btnPromedio.Click += new System.EventHandler(this.btnPromedio_Click);
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(59, 38);
            this.tbId.Name = "tbId";
            this.tbId.PlaceholderText = "Id";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(43, 23);
            this.tbId.TabIndex = 17;
            // 
            // tbAlumno
            // 
            this.tbAlumno.Location = new System.Drawing.Point(102, 38);
            this.tbAlumno.Name = "tbAlumno";
            this.tbAlumno.PlaceholderText = "Alumno";
            this.tbAlumno.Size = new System.Drawing.Size(160, 23);
            this.tbAlumno.TabIndex = 18;
            // 
            // tbProgVj
            // 
            this.tbProgVj.Location = new System.Drawing.Point(263, 38);
            this.tbProgVj.Name = "tbProgVj";
            this.tbProgVj.PlaceholderText = "Materia 1";
            this.tbProgVj.Size = new System.Drawing.Size(96, 23);
            this.tbProgVj.TabIndex = 19;
            // 
            // tbDibujo
            // 
            this.tbDibujo.Location = new System.Drawing.Point(359, 38);
            this.tbDibujo.Name = "tbDibujo";
            this.tbDibujo.PlaceholderText = "Materia 2";
            this.tbDibujo.Size = new System.Drawing.Size(100, 23);
            this.tbDibujo.TabIndex = 20;
            // 
            // tbDisenoG
            // 
            this.tbDisenoG.Location = new System.Drawing.Point(459, 38);
            this.tbDisenoG.Name = "tbDisenoG";
            this.tbDisenoG.PlaceholderText = "Materia 3";
            this.tbDisenoG.Size = new System.Drawing.Size(101, 23);
            this.tbDisenoG.TabIndex = 21;
            // 
            // tbDisenoB
            // 
            this.tbDisenoB.Location = new System.Drawing.Point(560, 38);
            this.tbDisenoB.Name = "tbDisenoB";
            this.tbDisenoB.PlaceholderText = "Materia 4";
            this.tbDisenoB.Size = new System.Drawing.Size(100, 23);
            this.tbDisenoB.TabIndex = 22;
            // 
            // tbProgW
            // 
            this.tbProgW.Location = new System.Drawing.Point(660, 38);
            this.tbProgW.Name = "tbProgW";
            this.tbProgW.PlaceholderText = "Materia 5";
            this.tbProgW.Size = new System.Drawing.Size(100, 23);
            this.tbProgW.TabIndex = 23;
            // 
            // frmPlanillaNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 554);
            this.Controls.Add(this.tbProgW);
            this.Controls.Add(this.tbDisenoB);
            this.Controls.Add(this.tbDisenoG);
            this.Controls.Add(this.tbDibujo);
            this.Controls.Add(this.tbProgVj);
            this.Controls.Add(this.tbAlumno);
            this.Controls.Add(this.tbId);
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
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbAlumno;
        private System.Windows.Forms.TextBox tbProgVj;
        private System.Windows.Forms.TextBox tbDibujo;
        private System.Windows.Forms.TextBox tbDisenoG;
        private System.Windows.Forms.TextBox tbDisenoB;
        private System.Windows.Forms.TextBox tbProgW;
    }
}
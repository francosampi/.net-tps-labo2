
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
            this.dgAgregarAPlanilla = new System.Windows.Forms.DataGridView();
            this.addId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addProgramacionDeVideojuegos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addDibujoDeComics = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addDisenoGrafico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addDisenoEnBlender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addProgramacionWeb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPlanilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAgregarAPlanilla)).BeginInit();
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
            // dgAgregarAPlanilla
            // 
            this.dgAgregarAPlanilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAgregarAPlanilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.addId,
            this.AddAlumno,
            this.addProgramacionDeVideojuegos,
            this.addDibujoDeComics,
            this.addDisenoGrafico,
            this.addDisenoEnBlender,
            this.addProgramacionWeb});
            this.dgAgregarAPlanilla.Location = new System.Drawing.Point(20, 23);
            this.dgAgregarAPlanilla.MultiSelect = false;
            this.dgAgregarAPlanilla.Name = "dgAgregarAPlanilla";
            this.dgAgregarAPlanilla.RowTemplate.Height = 25;
            this.dgAgregarAPlanilla.Size = new System.Drawing.Size(746, 79);
            this.dgAgregarAPlanilla.TabIndex = 12;
            // 
            // addId
            // 
            this.addId.HeaderText = "id";
            this.addId.Name = "addId";
            this.addId.ReadOnly = true;
            this.addId.Width = 40;
            // 
            // AddAlumno
            // 
            this.AddAlumno.HeaderText = "Alumno";
            this.AddAlumno.Name = "AddAlumno";
            this.AddAlumno.Width = 160;
            // 
            // addProgramacionDeVideojuegos
            // 
            this.addProgramacionDeVideojuegos.HeaderText = "Programacion de videojuegos";
            this.addProgramacionDeVideojuegos.Name = "addProgramacionDeVideojuegos";
            // 
            // addDibujoDeComics
            // 
            this.addDibujoDeComics.HeaderText = "Dibujo de comics";
            this.addDibujoDeComics.Name = "addDibujoDeComics";
            // 
            // addDisenoGrafico
            // 
            this.addDisenoGrafico.HeaderText = "Diseño Gráfico";
            this.addDisenoGrafico.Name = "addDisenoGrafico";
            // 
            // addDisenoEnBlender
            // 
            this.addDisenoEnBlender.HeaderText = "Diseño 3D en Blender";
            this.addDisenoEnBlender.Name = "addDisenoEnBlender";
            // 
            // addProgramacionWeb
            // 
            this.addProgramacionWeb.HeaderText = "Programacion Web";
            this.addProgramacionWeb.Name = "addProgramacionWeb";
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Cyan;
            this.btnModificar.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnModificar.Location = new System.Drawing.Point(332, 108);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(150, 37);
            this.btnModificar.TabIndex = 13;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.OrangeRed;
            this.btnRemover.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemover.Location = new System.Drawing.Point(488, 108);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(150, 37);
            this.btnRemover.TabIndex = 14;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            // 
            // btnLeer
            // 
            this.btnLeer.BackColor = System.Drawing.Color.Gold;
            this.btnLeer.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLeer.Location = new System.Drawing.Point(176, 108);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(150, 37);
            this.btnLeer.TabIndex = 15;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = false;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // frmPlanillaNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 554);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dgAgregarAPlanilla);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnGuardarBaseDatos);
            this.Controls.Add(this.dgPlanilla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPlanillaNotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Planilla de notas";
            this.Load += new System.EventHandler(this.frmPlanillaNotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPlanilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAgregarAPlanilla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPlanilla;
        private System.Windows.Forms.Button btnGuardarBaseDatos;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgAgregarAPlanilla;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProgramacionDeVideojuegos;
        private System.Windows.Forms.DataGridViewTextBoxColumn DibujoDeComics;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisenoGrafico;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisenoEnBlender;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProgramacionWeb;
        private System.Windows.Forms.DataGridViewTextBoxColumn addId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn addProgramacionDeVideojuegos;
        private System.Windows.Forms.DataGridViewTextBoxColumn addDibujoDeComics;
        private System.Windows.Forms.DataGridViewTextBoxColumn addDisenoGrafico;
        private System.Windows.Forms.DataGridViewTextBoxColumn addDisenoEnBlender;
        private System.Windows.Forms.DataGridViewTextBoxColumn addProgramacionWeb;
    }
}
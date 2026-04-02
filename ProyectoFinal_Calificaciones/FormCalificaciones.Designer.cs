namespace ProyectoFinal_Calificaciones
{
    partial class FormCalificaciones
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
            this.components = new System.ComponentModel.Container();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtC1 = new System.Windows.Forms.TextBox();
            this.txtC2 = new System.Windows.Forms.TextBox();
            this.txtC3 = new System.Windows.Forms.TextBox();
            this.txtC4 = new System.Windows.Forms.TextBox();
            this.txtExamen = new System.Windows.Forms.TextBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvCalificaciones = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbEstudiante = new System.Windows.Forms.ComboBox();
            this.cmbMateria = new System.Windows.Forms.ComboBox();
            this.btnExportarCSV = new System.Windows.Forms.Button();
            this.btnExportarPDF = new System.Windows.Forms.Button();
            this.materiasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estudianteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.formEstudiantesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.formEstudiantesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.formEstudiantesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalificaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formEstudiantesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formEstudiantesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formEstudiantesBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(83, 52);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(142, 20);
            this.txtID.TabIndex = 1;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtC1
            // 
            this.txtC1.Location = new System.Drawing.Point(296, 52);
            this.txtC1.Name = "txtC1";
            this.txtC1.Size = new System.Drawing.Size(142, 20);
            this.txtC1.TabIndex = 3;
            this.txtC1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtC2
            // 
            this.txtC2.Location = new System.Drawing.Point(497, 52);
            this.txtC2.Name = "txtC2";
            this.txtC2.Size = new System.Drawing.Size(142, 20);
            this.txtC2.TabIndex = 4;
            this.txtC2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtC3
            // 
            this.txtC3.Location = new System.Drawing.Point(296, 120);
            this.txtC3.Name = "txtC3";
            this.txtC3.Size = new System.Drawing.Size(142, 20);
            this.txtC3.TabIndex = 5;
            this.txtC3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtC4
            // 
            this.txtC4.Location = new System.Drawing.Point(497, 120);
            this.txtC4.Name = "txtC4";
            this.txtC4.Size = new System.Drawing.Size(142, 20);
            this.txtC4.TabIndex = 6;
            this.txtC4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtExamen
            // 
            this.txtExamen.Location = new System.Drawing.Point(689, 52);
            this.txtExamen.Name = "txtExamen";
            this.txtExamen.Size = new System.Drawing.Size(142, 20);
            this.txtExamen.TabIndex = 7;
            this.txtExamen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnMostrar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnMostrar.Location = new System.Drawing.Point(12, 227);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(849, 43);
            this.btnMostrar.TabIndex = 8;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAgregar.Location = new System.Drawing.Point(296, 167);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(142, 40);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnActualizar.Location = new System.Drawing.Point(497, 167);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(142, 40);
            this.btnActualizar.TabIndex = 10;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Crimson;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(689, 141);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(142, 66);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvCalificaciones
            // 
            this.dgvCalificaciones.AllowUserToAddRows = false;
            this.dgvCalificaciones.AllowUserToDeleteRows = false;
            this.dgvCalificaciones.AllowUserToResizeColumns = false;
            this.dgvCalificaciones.AllowUserToResizeRows = false;
            this.dgvCalificaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCalificaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCalificaciones.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvCalificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalificaciones.GridColor = System.Drawing.SystemColors.MenuText;
            this.dgvCalificaciones.Location = new System.Drawing.Point(12, 276);
            this.dgvCalificaciones.MultiSelect = false;
            this.dgvCalificaciones.Name = "dgvCalificaciones";
            this.dgvCalificaciones.ReadOnly = true;
            this.dgvCalificaciones.RowHeadersVisible = false;
            this.dgvCalificaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCalificaciones.ShowEditingIcon = false;
            this.dgvCalificaciones.Size = new System.Drawing.Size(849, 225);
            this.dgvCalificaciones.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label1.Location = new System.Drawing.Point(145, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label2.Location = new System.Drawing.Point(328, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Calificación 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label3.Location = new System.Drawing.Point(528, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Calificación 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label4.Location = new System.Drawing.Point(328, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Calificación 3:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label5.Location = new System.Drawing.Point(528, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Calificación 4:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label6.Location = new System.Drawing.Point(736, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Examen:";
            // 
            // cmbEstudiante
            // 
            this.cmbEstudiante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstudiante.FormattingEnabled = true;
            this.cmbEstudiante.Location = new System.Drawing.Point(83, 119);
            this.cmbEstudiante.Name = "cmbEstudiante";
            this.cmbEstudiante.Size = new System.Drawing.Size(142, 21);
            this.cmbEstudiante.TabIndex = 19;
            // 
            // cmbMateria
            // 
            this.cmbMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMateria.FormattingEnabled = true;
            this.cmbMateria.Location = new System.Drawing.Point(83, 186);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(142, 21);
            this.cmbMateria.TabIndex = 20;
            // 
            // btnExportarCSV
            // 
            this.btnExportarCSV.BackColor = System.Drawing.Color.SpringGreen;
            this.btnExportarCSV.Location = new System.Drawing.Point(720, 107);
            this.btnExportarCSV.Name = "btnExportarCSV";
            this.btnExportarCSV.Size = new System.Drawing.Size(90, 23);
            this.btnExportarCSV.TabIndex = 21;
            this.btnExportarCSV.Text = "Exportar CSV";
            this.btnExportarCSV.UseVisualStyleBackColor = false;
            this.btnExportarCSV.Click += new System.EventHandler(this.btnExportarCSV_Click);
            // 
            // btnExportarPDF
            // 
            this.btnExportarPDF.BackColor = System.Drawing.Color.Red;
            this.btnExportarPDF.Location = new System.Drawing.Point(720, 78);
            this.btnExportarPDF.Name = "btnExportarPDF";
            this.btnExportarPDF.Size = new System.Drawing.Size(90, 23);
            this.btnExportarPDF.TabIndex = 22;
            this.btnExportarPDF.Text = "Exportar PDF";
            this.btnExportarPDF.UseVisualStyleBackColor = false;
            this.btnExportarPDF.Click += new System.EventHandler(this.btnExportarPDF_Click);
            // 
            // materiasBindingSource
            // 
            this.materiasBindingSource.DataSource = typeof(ProyectoFinal_Calificaciones.Modelo.Materias);
            // 
            // estudianteBindingSource
            // 
            this.estudianteBindingSource.DataSource = typeof(ProyectoFinal_Calificaciones.Modelo.Estudiante);
            // 
            // formEstudiantesBindingSource
            // 
            this.formEstudiantesBindingSource.DataSource = typeof(ProyectoFinal_Calificaciones.FormEstudiantes);
            // 
            // formEstudiantesBindingSource1
            // 
            this.formEstudiantesBindingSource1.DataSource = typeof(ProyectoFinal_Calificaciones.FormEstudiantes);
            // 
            // formEstudiantesBindingSource2
            // 
            this.formEstudiantesBindingSource2.DataSource = typeof(ProyectoFinal_Calificaciones.FormEstudiantes);
            // 
            // FormCalificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(873, 513);
            this.Controls.Add(this.btnExportarPDF);
            this.Controls.Add(this.btnExportarCSV);
            this.Controls.Add(this.cmbMateria);
            this.Controls.Add(this.cmbEstudiante);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCalificaciones);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.txtExamen);
            this.Controls.Add(this.txtC4);
            this.Controls.Add(this.txtC3);
            this.Controls.Add(this.txtC2);
            this.Controls.Add(this.txtC1);
            this.Controls.Add(this.txtID);
            this.Name = "FormCalificaciones";
            this.Text = "Calificaciones";
            this.Load += new System.EventHandler(this.FormCalificaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalificaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formEstudiantesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formEstudiantesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formEstudiantesBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtC1;
        private System.Windows.Forms.TextBox txtC2;
        private System.Windows.Forms.TextBox txtC3;
        private System.Windows.Forms.TextBox txtC4;
        private System.Windows.Forms.TextBox txtExamen;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvCalificaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource formEstudiantesBindingSource;
        private System.Windows.Forms.BindingSource estudianteBindingSource;
        private System.Windows.Forms.BindingSource materiasBindingSource;
        private System.Windows.Forms.BindingSource formEstudiantesBindingSource1;
        private System.Windows.Forms.BindingSource formEstudiantesBindingSource2;
        private System.Windows.Forms.ComboBox cmbEstudiante;
        private System.Windows.Forms.ComboBox cmbMateria;
        private System.Windows.Forms.Button btnExportarCSV;
        private System.Windows.Forms.Button btnExportarPDF;
    }
}
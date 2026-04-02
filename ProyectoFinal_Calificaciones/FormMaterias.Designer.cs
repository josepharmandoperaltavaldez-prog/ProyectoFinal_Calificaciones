namespace ProyectoFinal_Calificaciones
{
    partial class FormMaterias
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.dgvMaterias = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNombreMateria = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Materia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(517, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de la Materia:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(97, 131);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(171, 65);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(360, 131);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(171, 65);
            this.btnActualizar.TabIndex = 7;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Crimson;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(625, 131);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(171, 65);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMostrar.Location = new System.Drawing.Point(13, 224);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(847, 43);
            this.btnMostrar.TabIndex = 5;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // dgvMaterias
            // 
            this.dgvMaterias.AllowUserToAddRows = false;
            this.dgvMaterias.AllowUserToDeleteRows = false;
            this.dgvMaterias.AllowUserToResizeColumns = false;
            this.dgvMaterias.AllowUserToResizeRows = false;
            this.dgvMaterias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMaterias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterias.GridColor = System.Drawing.SystemColors.MenuText;
            this.dgvMaterias.Location = new System.Drawing.Point(13, 275);
            this.dgvMaterias.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMaterias.MultiSelect = false;
            this.dgvMaterias.Name = "dgvMaterias";
            this.dgvMaterias.ReadOnly = true;
            this.dgvMaterias.RowHeadersVisible = false;
            this.dgvMaterias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvMaterias.Size = new System.Drawing.Size(847, 199);
            this.dgvMaterias.TabIndex = 6;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(234, 65);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(171, 25);
            this.txtID.TabIndex = 7;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNombreMateria
            // 
            this.txtNombreMateria.Location = new System.Drawing.Point(498, 65);
            this.txtNombreMateria.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreMateria.Name = "txtNombreMateria";
            this.txtNombreMateria.Size = new System.Drawing.Size(171, 25);
            this.txtNombreMateria.TabIndex = 8;
            this.txtNombreMateria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(873, 487);
            this.Controls.Add(this.txtNombreMateria);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dgvMaterias);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMaterias";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Materias";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.DataGridView dgvMaterias;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNombreMateria;
    }
}
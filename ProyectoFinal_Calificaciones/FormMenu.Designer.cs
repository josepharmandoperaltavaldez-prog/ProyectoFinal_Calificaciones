namespace ProyectoFinal_Calificaciones
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MateriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.EstudiantesStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MateriasStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.CalificacionesStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MateriasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(9, 33);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(178, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MateriasToolStripMenuItem
            // 
            this.MateriasToolStripMenuItem.BackColor = System.Drawing.SystemColors.Menu;
            this.MateriasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.EstudiantesStripMenuItem,
            this.toolStripSeparator2,
            this.MateriasStripMenuItem2,
            this.toolStripSeparator3,
            this.CalificacionesStripMenuItem3});
            this.MateriasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MateriasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MateriasToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.MateriasToolStripMenuItem.Name = "MateriasToolStripMenuItem";
            this.MateriasToolStripMenuItem.Size = new System.Drawing.Size(169, 21);
            this.MateriasToolStripMenuItem.Text = "Sistema Calificaciones";
            this.MateriasToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // EstudiantesStripMenuItem
            // 
            this.EstudiantesStripMenuItem.Name = "EstudiantesStripMenuItem";
            this.EstudiantesStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.EstudiantesStripMenuItem.Text = "Estudiantes";
            this.EstudiantesStripMenuItem.Click += new System.EventHandler(this.EstudiantesStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // MateriasStripMenuItem2
            // 
            this.MateriasStripMenuItem2.Name = "MateriasStripMenuItem2";
            this.MateriasStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.MateriasStripMenuItem2.Text = "Materias";
            this.MateriasStripMenuItem2.Click += new System.EventHandler(this.MateriasStripMenuItem2_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // CalificacionesStripMenuItem3
            // 
            this.CalificacionesStripMenuItem3.Name = "CalificacionesStripMenuItem3";
            this.CalificacionesStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.CalificacionesStripMenuItem3.Text = "Calificaciones";
            this.CalificacionesStripMenuItem3.Click += new System.EventHandler(this.CalificacionesStripMenuItem3_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(873, 487);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormMenu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MateriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem EstudiantesStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem MateriasStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem CalificacionesStripMenuItem3;
    }
}
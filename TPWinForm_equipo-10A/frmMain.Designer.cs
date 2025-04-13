namespace TPWinForm_equipo_10A
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarArticulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarMarcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarCategoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdminArticulos = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnAdminCategoria = new System.Windows.Forms.Button();
            this.btnAdminMarcas = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(585, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarArticulosToolStripMenuItem,
            this.administrarMarcasToolStripMenuItem,
            this.administrarCategoriasToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.toolStripMenuItem1.Text = "Menu";
            // 
            // administrarArticulosToolStripMenuItem
            // 
            this.administrarArticulosToolStripMenuItem.Name = "administrarArticulosToolStripMenuItem";
            this.administrarArticulosToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.administrarArticulosToolStripMenuItem.Text = "Administrar Articulos";
            this.administrarArticulosToolStripMenuItem.Click += new System.EventHandler(this.administrarArticulosToolStripMenuItem_Click);
            // 
            // administrarMarcasToolStripMenuItem
            // 
            this.administrarMarcasToolStripMenuItem.Name = "administrarMarcasToolStripMenuItem";
            this.administrarMarcasToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.administrarMarcasToolStripMenuItem.Text = "Administrar Marcas";
            this.administrarMarcasToolStripMenuItem.Click += new System.EventHandler(this.administrarMarcasToolStripMenuItem_Click);
            // 
            // administrarCategoriasToolStripMenuItem
            // 
            this.administrarCategoriasToolStripMenuItem.Name = "administrarCategoriasToolStripMenuItem";
            this.administrarCategoriasToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.administrarCategoriasToolStripMenuItem.Text = "Administrar Categorias";
            this.administrarCategoriasToolStripMenuItem.Click += new System.EventHandler(this.administrarCategoriasToolStripMenuItem_Click);
            // 
            // btnAdminArticulos
            // 
            this.btnAdminArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminArticulos.Location = new System.Drawing.Point(155, 153);
            this.btnAdminArticulos.Name = "btnAdminArticulos";
            this.btnAdminArticulos.Size = new System.Drawing.Size(263, 37);
            this.btnAdminArticulos.TabIndex = 2;
            this.btnAdminArticulos.Text = "Administrar Articulos";
            this.btnAdminArticulos.UseVisualStyleBackColor = true;
            this.btnAdminArticulos.Click += new System.EventHandler(this.btnAdminArticulos_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AccessibleName = "Menu";
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(106, 94);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(358, 31);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "GESTION DE COMERCIO";
            // 
            // btnAdminCategoria
            // 
            this.btnAdminCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminCategoria.Location = new System.Drawing.Point(155, 196);
            this.btnAdminCategoria.Name = "btnAdminCategoria";
            this.btnAdminCategoria.Size = new System.Drawing.Size(263, 37);
            this.btnAdminCategoria.TabIndex = 6;
            this.btnAdminCategoria.Text = "Administrar Categorias";
            this.btnAdminCategoria.UseVisualStyleBackColor = true;
            this.btnAdminCategoria.Click += new System.EventHandler(this.btnAdminCategoria_Click);
            // 
            // btnAdminMarcas
            // 
            this.btnAdminMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminMarcas.Location = new System.Drawing.Point(155, 239);
            this.btnAdminMarcas.Name = "btnAdminMarcas";
            this.btnAdminMarcas.Size = new System.Drawing.Size(263, 37);
            this.btnAdminMarcas.TabIndex = 7;
            this.btnAdminMarcas.Text = "Administrar Marcas";
            this.btnAdminMarcas.UseVisualStyleBackColor = true;
            this.btnAdminMarcas.Click += new System.EventHandler(this.btnAdminMarcas_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 363);
            this.Controls.Add(this.btnAdminMarcas);
            this.Controls.Add(this.btnAdminCategoria);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnAdminArticulos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(601, 402);
            this.MinimumSize = new System.Drawing.Size(601, 402);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem administrarArticulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarMarcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarCategoriasToolStripMenuItem;
        private System.Windows.Forms.Button btnAdminArticulos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAdminCategoria;
        private System.Windows.Forms.Button btnAdminMarcas;
    }
}
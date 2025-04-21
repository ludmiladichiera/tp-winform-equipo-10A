namespace TPWinForm_equipo_10A
{
    partial class frmAdminCategorias
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
            this.btnEliminarCategorias = new System.Windows.Forms.Button();
            this.btnModificarCategorias = new System.Windows.Forms.Button();
            this.btnAgregarCategorias = new System.Windows.Forms.Button();
            this.lblTituloCategorias = new System.Windows.Forms.Label();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarCategorias
            // 
            this.btnEliminarCategorias.BackColor = System.Drawing.Color.LightCoral;
            this.btnEliminarCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCategorias.Location = new System.Drawing.Point(432, 309);
            this.btnEliminarCategorias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminarCategorias.Name = "btnEliminarCategorias";
            this.btnEliminarCategorias.Size = new System.Drawing.Size(532, 46);
            this.btnEliminarCategorias.TabIndex = 34;
            this.btnEliminarCategorias.Text = "Eliminar categoria seleccionada";
            this.btnEliminarCategorias.UseVisualStyleBackColor = false;
            this.btnEliminarCategorias.Click += new System.EventHandler(this.btnEliminarCategorias_Click);
            // 
            // btnModificarCategorias
            // 
            this.btnModificarCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCategorias.Location = new System.Drawing.Point(501, 232);
            this.btnModificarCategorias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificarCategorias.Name = "btnModificarCategorias";
            this.btnModificarCategorias.Size = new System.Drawing.Size(385, 46);
            this.btnModificarCategorias.TabIndex = 32;
            this.btnModificarCategorias.Text = "Modificar categorias";
            this.btnModificarCategorias.UseVisualStyleBackColor = true;
            this.btnModificarCategorias.Click += new System.EventHandler(this.btnModificarCategorias_Click);
            // 
            // btnAgregarCategorias
            // 
            this.btnAgregarCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCategorias.Location = new System.Drawing.Point(501, 150);
            this.btnAgregarCategorias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarCategorias.Name = "btnAgregarCategorias";
            this.btnAgregarCategorias.Size = new System.Drawing.Size(385, 46);
            this.btnAgregarCategorias.TabIndex = 30;
            this.btnAgregarCategorias.Text = "Agregar Categorias";
            this.btnAgregarCategorias.UseVisualStyleBackColor = true;
            this.btnAgregarCategorias.Click += new System.EventHandler(this.btnAgregarCategorias_Click);
            // 
            // lblTituloCategorias
            // 
            this.lblTituloCategorias.AccessibleName = "Menu";
            this.lblTituloCategorias.AutoSize = true;
            this.lblTituloCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCategorias.Location = new System.Drawing.Point(197, 11);
            this.lblTituloCategorias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloCategorias.Name = "lblTituloCategorias";
            this.lblTituloCategorias.Size = new System.Drawing.Size(624, 39);
            this.lblTituloCategorias.TabIndex = 35;
            this.lblTituloCategorias.Text = "ADMINISTRADOR DE CATEGORIAS";
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.BackgroundColor = System.Drawing.Color.Ivory;
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCategorias.Location = new System.Drawing.Point(41, 81);
            this.dgvCategorias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCategorias.MultiSelect = false;
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.RowHeadersWidth = 51;
            this.dgvCategorias.RowTemplate.Height = 24;
            this.dgvCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategorias.Size = new System.Drawing.Size(352, 361);
            this.dgvCategorias.TabIndex = 36;
            // 
            // frmAdminCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 476);
            this.Controls.Add(this.dgvCategorias);
            this.Controls.Add(this.lblTituloCategorias);
            this.Controls.Add(this.btnEliminarCategorias);
            this.Controls.Add(this.btnModificarCategorias);
            this.Controls.Add(this.btnAgregarCategorias);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAdminCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador de Categorias";
            this.Load += new System.EventHandler(this.frmAdminCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarCategorias;
        private System.Windows.Forms.Button btnModificarCategorias;
        private System.Windows.Forms.Button btnAgregarCategorias;
        private System.Windows.Forms.Label lblTituloCategorias;
        private System.Windows.Forms.DataGridView dgvCategorias;
    }
}
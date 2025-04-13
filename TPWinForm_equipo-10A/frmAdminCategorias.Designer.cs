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
            this.btnListadoCategorias = new System.Windows.Forms.Button();
            this.btnModificarCategorias = new System.Windows.Forms.Button();
            this.btnBusquedaCategorias = new System.Windows.Forms.Button();
            this.btnAgregarCategorias = new System.Windows.Forms.Button();
            this.lblTituloCategorias = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEliminarCategorias
            // 
            this.btnEliminarCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCategorias.Location = new System.Drawing.Point(146, 347);
            this.btnEliminarCategorias.Name = "btnEliminarCategorias";
            this.btnEliminarCategorias.Size = new System.Drawing.Size(289, 37);
            this.btnEliminarCategorias.TabIndex = 34;
            this.btnEliminarCategorias.Text = "Eliminar categorias";
            this.btnEliminarCategorias.UseVisualStyleBackColor = true;
            // 
            // btnListadoCategorias
            // 
            this.btnListadoCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListadoCategorias.Location = new System.Drawing.Point(146, 304);
            this.btnListadoCategorias.Name = "btnListadoCategorias";
            this.btnListadoCategorias.Size = new System.Drawing.Size(289, 37);
            this.btnListadoCategorias.TabIndex = 33;
            this.btnListadoCategorias.Text = "Listado de categorias";
            this.btnListadoCategorias.UseVisualStyleBackColor = true;
            // 
            // btnModificarCategorias
            // 
            this.btnModificarCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCategorias.Location = new System.Drawing.Point(146, 261);
            this.btnModificarCategorias.Name = "btnModificarCategorias";
            this.btnModificarCategorias.Size = new System.Drawing.Size(289, 37);
            this.btnModificarCategorias.TabIndex = 32;
            this.btnModificarCategorias.Text = "Modificar categorias";
            this.btnModificarCategorias.UseVisualStyleBackColor = true;
            // 
            // btnBusquedaCategorias
            // 
            this.btnBusquedaCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusquedaCategorias.Location = new System.Drawing.Point(146, 218);
            this.btnBusquedaCategorias.Name = "btnBusquedaCategorias";
            this.btnBusquedaCategorias.Size = new System.Drawing.Size(289, 37);
            this.btnBusquedaCategorias.TabIndex = 31;
            this.btnBusquedaCategorias.Text = "Busqueda de categorias";
            this.btnBusquedaCategorias.UseVisualStyleBackColor = true;
            // 
            // btnAgregarCategorias
            // 
            this.btnAgregarCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCategorias.Location = new System.Drawing.Point(146, 175);
            this.btnAgregarCategorias.Name = "btnAgregarCategorias";
            this.btnAgregarCategorias.Size = new System.Drawing.Size(289, 37);
            this.btnAgregarCategorias.TabIndex = 30;
            this.btnAgregarCategorias.Text = "Agregar Categorias";
            this.btnAgregarCategorias.UseVisualStyleBackColor = true;
            // 
            // lblTituloCategorias
            // 
            this.lblTituloCategorias.AccessibleName = "Menu";
            this.lblTituloCategorias.AutoSize = true;
            this.lblTituloCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCategorias.Location = new System.Drawing.Point(43, 105);
            this.lblTituloCategorias.Name = "lblTituloCategorias";
            this.lblTituloCategorias.Size = new System.Drawing.Size(502, 31);
            this.lblTituloCategorias.TabIndex = 35;
            this.lblTituloCategorias.Text = "ADMINISTRADOR DE CATEGORIAS";
            // 
            // frmAdminCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 491);
            this.Controls.Add(this.lblTituloCategorias);
            this.Controls.Add(this.btnEliminarCategorias);
            this.Controls.Add(this.btnListadoCategorias);
            this.Controls.Add(this.btnModificarCategorias);
            this.Controls.Add(this.btnBusquedaCategorias);
            this.Controls.Add(this.btnAgregarCategorias);
            this.MaximumSize = new System.Drawing.Size(601, 530);
            this.MinimumSize = new System.Drawing.Size(601, 530);
            this.Name = "frmAdminCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador de Categorias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarCategorias;
        private System.Windows.Forms.Button btnListadoCategorias;
        private System.Windows.Forms.Button btnModificarCategorias;
        private System.Windows.Forms.Button btnBusquedaCategorias;
        private System.Windows.Forms.Button btnAgregarCategorias;
        private System.Windows.Forms.Label lblTituloCategorias;
    }
}
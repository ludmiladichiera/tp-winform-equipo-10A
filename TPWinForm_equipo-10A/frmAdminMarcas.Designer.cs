namespace TPWinForm_equipo_10A
{
    partial class frmAdminMarcas
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
            this.btnEliminarMarcas = new System.Windows.Forms.Button();
            this.btnModificarMarcas = new System.Windows.Forms.Button();
            this.btnBusquedaMarcas = new System.Windows.Forms.Button();
            this.btnAgregarMarcas = new System.Windows.Forms.Button();
            this.lblTituloMarcas = new System.Windows.Forms.Label();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarMarcas
            // 
            this.btnEliminarMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMarcas.Location = new System.Drawing.Point(168, 468);
            this.btnEliminarMarcas.Name = "btnEliminarMarcas";
            this.btnEliminarMarcas.Size = new System.Drawing.Size(289, 37);
            this.btnEliminarMarcas.TabIndex = 28;
            this.btnEliminarMarcas.Text = "Eliminar marcas";
            this.btnEliminarMarcas.UseVisualStyleBackColor = true;
            this.btnEliminarMarcas.Click += new System.EventHandler(this.btnEliminarMarcas_Click);
            // 
            // btnModificarMarcas
            // 
            this.btnModificarMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarMarcas.Location = new System.Drawing.Point(168, 425);
            this.btnModificarMarcas.Name = "btnModificarMarcas";
            this.btnModificarMarcas.Size = new System.Drawing.Size(289, 37);
            this.btnModificarMarcas.TabIndex = 26;
            this.btnModificarMarcas.Text = "Modificar marcas";
            this.btnModificarMarcas.UseVisualStyleBackColor = true;
            // 
            // btnBusquedaMarcas
            // 
            this.btnBusquedaMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusquedaMarcas.Location = new System.Drawing.Point(168, 382);
            this.btnBusquedaMarcas.Name = "btnBusquedaMarcas";
            this.btnBusquedaMarcas.Size = new System.Drawing.Size(289, 37);
            this.btnBusquedaMarcas.TabIndex = 25;
            this.btnBusquedaMarcas.Text = "Busqueda de marcas";
            this.btnBusquedaMarcas.UseVisualStyleBackColor = true;
            // 
            // btnAgregarMarcas
            // 
            this.btnAgregarMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMarcas.Location = new System.Drawing.Point(168, 339);
            this.btnAgregarMarcas.Name = "btnAgregarMarcas";
            this.btnAgregarMarcas.Size = new System.Drawing.Size(289, 37);
            this.btnAgregarMarcas.TabIndex = 24;
            this.btnAgregarMarcas.Text = "Agregar marcas";
            this.btnAgregarMarcas.UseVisualStyleBackColor = true;
            this.btnAgregarMarcas.Click += new System.EventHandler(this.btnAgregarMarcas_Click);
            // 
            // lblTituloMarcas
            // 
            this.lblTituloMarcas.AccessibleName = "Menu";
            this.lblTituloMarcas.AutoSize = true;
            this.lblTituloMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloMarcas.Location = new System.Drawing.Point(99, 291);
            this.lblTituloMarcas.Name = "lblTituloMarcas";
            this.lblTituloMarcas.Size = new System.Drawing.Size(435, 31);
            this.lblTituloMarcas.TabIndex = 23;
            this.lblTituloMarcas.Text = "ADMINISTRADOR DE MARCAS";
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.BackgroundColor = System.Drawing.Color.Ivory;
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCategorias.Location = new System.Drawing.Point(19, 22);
            this.dgvCategorias.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCategorias.MultiSelect = false;
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.RowHeadersWidth = 51;
            this.dgvCategorias.RowTemplate.Height = 24;
            this.dgvCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategorias.Size = new System.Drawing.Size(610, 250);
            this.dgvCategorias.TabIndex = 37;
            // 
            // frmAdminMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 553);
            this.Controls.Add(this.dgvCategorias);
            this.Controls.Add(this.btnEliminarMarcas);
            this.Controls.Add(this.btnModificarMarcas);
            this.Controls.Add(this.btnBusquedaMarcas);
            this.Controls.Add(this.btnAgregarMarcas);
            this.Controls.Add(this.lblTituloMarcas);
            this.MinimumSize = new System.Drawing.Size(601, 530);
            this.Name = "frmAdminMarcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador de Marcas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarMarcas;
        private System.Windows.Forms.Button btnModificarMarcas;
        private System.Windows.Forms.Button btnBusquedaMarcas;
        private System.Windows.Forms.Button btnAgregarMarcas;
        private System.Windows.Forms.Label lblTituloMarcas;
        private System.Windows.Forms.DataGridView dgvCategorias;
    }
}
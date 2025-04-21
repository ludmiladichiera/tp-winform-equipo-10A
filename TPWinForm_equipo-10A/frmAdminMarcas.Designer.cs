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
            this.btnAgregarMarcas = new System.Windows.Forms.Button();
            this.lblTituloMarcas = new System.Windows.Forms.Label();
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarMarcas
            // 
            this.btnEliminarMarcas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEliminarMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMarcas.Location = new System.Drawing.Point(492, 311);
            this.btnEliminarMarcas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminarMarcas.Name = "btnEliminarMarcas";
            this.btnEliminarMarcas.Size = new System.Drawing.Size(488, 46);
            this.btnEliminarMarcas.TabIndex = 28;
            this.btnEliminarMarcas.Text = "Eliminar marca seleccionada";
            this.btnEliminarMarcas.UseVisualStyleBackColor = false;
            this.btnEliminarMarcas.Click += new System.EventHandler(this.btnEliminarMarcas_Click);
            // 
            // btnModificarMarcas
            // 
            this.btnModificarMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarMarcas.Location = new System.Drawing.Point(544, 233);
            this.btnModificarMarcas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificarMarcas.Name = "btnModificarMarcas";
            this.btnModificarMarcas.Size = new System.Drawing.Size(385, 46);
            this.btnModificarMarcas.TabIndex = 26;
            this.btnModificarMarcas.Text = "Modificar marcas";
            this.btnModificarMarcas.UseVisualStyleBackColor = true;
            this.btnModificarMarcas.Click += new System.EventHandler(this.btnModificarMarcas_Click);
            // 
            // btnAgregarMarcas
            // 
            this.btnAgregarMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMarcas.Location = new System.Drawing.Point(544, 153);
            this.btnAgregarMarcas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarMarcas.Name = "btnAgregarMarcas";
            this.btnAgregarMarcas.Size = new System.Drawing.Size(385, 46);
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
            this.lblTituloMarcas.Location = new System.Drawing.Point(179, 14);
            this.lblTituloMarcas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloMarcas.Name = "lblTituloMarcas";
            this.lblTituloMarcas.Size = new System.Drawing.Size(542, 39);
            this.lblTituloMarcas.TabIndex = 23;
            this.lblTituloMarcas.Text = "ADMINISTRADOR DE MARCAS";
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.BackgroundColor = System.Drawing.Color.Ivory;
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMarcas.Location = new System.Drawing.Point(37, 78);
            this.dgvMarcas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMarcas.MultiSelect = false;
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.RowHeadersWidth = 51;
            this.dgvMarcas.RowTemplate.Height = 24;
            this.dgvMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarcas.Size = new System.Drawing.Size(405, 370);
            this.dgvMarcas.TabIndex = 37;
            // 
            // frmAdminMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 482);
            this.Controls.Add(this.dgvMarcas);
            this.Controls.Add(this.btnEliminarMarcas);
            this.Controls.Add(this.btnModificarMarcas);
            this.Controls.Add(this.btnAgregarMarcas);
            this.Controls.Add(this.lblTituloMarcas);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAdminMarcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador de Marcas";
            this.Load += new System.EventHandler(this.frmAdminMarcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarMarcas;
        private System.Windows.Forms.Button btnModificarMarcas;
        private System.Windows.Forms.Button btnAgregarMarcas;
        private System.Windows.Forms.Label lblTituloMarcas;
        private System.Windows.Forms.DataGridView dgvMarcas;
    }
}
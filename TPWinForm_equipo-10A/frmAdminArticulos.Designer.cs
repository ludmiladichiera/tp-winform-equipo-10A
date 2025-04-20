namespace TPWinForm_equipo_10A
{
    partial class frmAdminArticulos
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
            this.lblTituloArticulos = new System.Windows.Forms.Label();
            this.btnAgregarArticulo = new System.Windows.Forms.Button();
            this.btnBusquedaArticulos = new System.Windows.Forms.Button();
            this.btnModificarArticulos = new System.Windows.Forms.Button();
            this.btnListadoArticulos = new System.Windows.Forms.Button();
            this.btnEliminarArticulos = new System.Windows.Forms.Button();
            this.btnDetalleArticulo = new System.Windows.Forms.Button();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloArticulos
            // 
            this.lblTituloArticulos.AccessibleName = "Menu";
            this.lblTituloArticulos.AutoSize = true;
            this.lblTituloArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloArticulos.Location = new System.Drawing.Point(289, 352);
            this.lblTituloArticulos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloArticulos.Name = "lblTituloArticulos";
            this.lblTituloArticulos.Size = new System.Drawing.Size(595, 39);
            this.lblTituloArticulos.TabIndex = 9;
            this.lblTituloArticulos.Text = "ADMINISTRADOR DE ARTICULOS";
            this.lblTituloArticulos.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarArticulo.Location = new System.Drawing.Point(409, 418);
            this.btnAgregarArticulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Size = new System.Drawing.Size(385, 46);
            this.btnAgregarArticulo.TabIndex = 11;
            this.btnAgregarArticulo.Text = "Agregar articulos";
            this.btnAgregarArticulo.UseVisualStyleBackColor = true;
            this.btnAgregarArticulo.Click += new System.EventHandler(this.btnAdminMarcas_Click);
            // 
            // btnBusquedaArticulos
            // 
            this.btnBusquedaArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusquedaArticulos.Location = new System.Drawing.Point(409, 471);
            this.btnBusquedaArticulos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBusquedaArticulos.Name = "btnBusquedaArticulos";
            this.btnBusquedaArticulos.Size = new System.Drawing.Size(385, 46);
            this.btnBusquedaArticulos.TabIndex = 12;
            this.btnBusquedaArticulos.Text = "Busqueda de articulos";
            this.btnBusquedaArticulos.UseVisualStyleBackColor = true;
            this.btnBusquedaArticulos.Click += new System.EventHandler(this.btnBusquedaArticulos_Click);
            // 
            // btnModificarArticulos
            // 
            this.btnModificarArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarArticulos.Location = new System.Drawing.Point(409, 524);
            this.btnModificarArticulos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificarArticulos.Name = "btnModificarArticulos";
            this.btnModificarArticulos.Size = new System.Drawing.Size(385, 46);
            this.btnModificarArticulos.TabIndex = 13;
            this.btnModificarArticulos.Text = "Modificar articulos";
            this.btnModificarArticulos.UseVisualStyleBackColor = true;
            this.btnModificarArticulos.Click += new System.EventHandler(this.btnModificarArticulos_Click);
            // 
            // btnListadoArticulos
            // 
            this.btnListadoArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListadoArticulos.Location = new System.Drawing.Point(409, 577);
            this.btnListadoArticulos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnListadoArticulos.Name = "btnListadoArticulos";
            this.btnListadoArticulos.Size = new System.Drawing.Size(385, 46);
            this.btnListadoArticulos.TabIndex = 14;
            this.btnListadoArticulos.Text = "Listado de articulos";
            this.btnListadoArticulos.UseVisualStyleBackColor = true;
            this.btnListadoArticulos.Click += new System.EventHandler(this.btnListadoArticulos_Click);
            // 
            // btnEliminarArticulos
            // 
            this.btnEliminarArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarArticulos.Location = new System.Drawing.Point(352, 630);
            this.btnEliminarArticulos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminarArticulos.Name = "btnEliminarArticulos";
            this.btnEliminarArticulos.Size = new System.Drawing.Size(476, 46);
            this.btnEliminarArticulos.TabIndex = 15;
            this.btnEliminarArticulos.Text = "Eliminar articulo seleccionado";
            this.btnEliminarArticulos.UseVisualStyleBackColor = true;
            this.btnEliminarArticulos.Click += new System.EventHandler(this.btnEliminarArticulos_Click);
            // 
            // btnDetalleArticulo
            // 
            this.btnDetalleArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalleArticulo.Location = new System.Drawing.Point(409, 683);
            this.btnDetalleArticulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDetalleArticulo.Name = "btnDetalleArticulo";
            this.btnDetalleArticulo.Size = new System.Drawing.Size(385, 46);
            this.btnDetalleArticulo.TabIndex = 16;
            this.btnDetalleArticulo.Text = "Ver detalle de un articulo";
            this.btnDetalleArticulo.UseVisualStyleBackColor = true;
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.BackgroundColor = System.Drawing.Color.Ivory;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(15, 14);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.RowTemplate.Height = 24;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(813, 308);
            this.dgvArticulos.TabIndex = 17;
            this.dgvArticulos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulos_CellContentClick);
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.BackColor = System.Drawing.Color.Ivory;
            this.pbxArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxArticulo.Location = new System.Drawing.Point(851, 14);
            this.pbxArticulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(365, 307);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 18;
            this.pbxArticulo.TabStop = false;
            // 
            // frmAdminArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1231, 757);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.btnDetalleArticulo);
            this.Controls.Add(this.btnEliminarArticulos);
            this.Controls.Add(this.btnListadoArticulos);
            this.Controls.Add(this.btnModificarArticulos);
            this.Controls.Add(this.btnBusquedaArticulos);
            this.Controls.Add(this.btnAgregarArticulo);
            this.Controls.Add(this.lblTituloArticulos);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(794, 639);
            this.Name = "frmAdminArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador de Articulos";
            this.Load += new System.EventHandler(this.frmAdminArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTituloArticulos;
        private System.Windows.Forms.Button btnAgregarArticulo;
        private System.Windows.Forms.Button btnBusquedaArticulos;
        private System.Windows.Forms.Button btnModificarArticulos;
        private System.Windows.Forms.Button btnListadoArticulos;
        private System.Windows.Forms.Button btnEliminarArticulos;
        private System.Windows.Forms.Button btnDetalleArticulo;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox pbxArticulo;
    }
}
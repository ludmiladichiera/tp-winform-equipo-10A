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
            this.SuspendLayout();
            // 
            // lblTituloArticulos
            // 
            this.lblTituloArticulos.AccessibleName = "Menu";
            this.lblTituloArticulos.AutoSize = true;
            this.lblTituloArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloArticulos.Location = new System.Drawing.Point(41, 97);
            this.lblTituloArticulos.Name = "lblTituloArticulos";
            this.lblTituloArticulos.Size = new System.Drawing.Size(479, 31);
            this.lblTituloArticulos.TabIndex = 9;
            this.lblTituloArticulos.Text = "ADMINISTRADOR DE ARTICULOS";
            this.lblTituloArticulos.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarArticulo.Location = new System.Drawing.Point(131, 165);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Size = new System.Drawing.Size(289, 37);
            this.btnAgregarArticulo.TabIndex = 11;
            this.btnAgregarArticulo.Text = "Agregar articulos";
            this.btnAgregarArticulo.UseVisualStyleBackColor = true;
            this.btnAgregarArticulo.Click += new System.EventHandler(this.btnAdminMarcas_Click);
            // 
            // btnBusquedaArticulos
            // 
            this.btnBusquedaArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusquedaArticulos.Location = new System.Drawing.Point(131, 208);
            this.btnBusquedaArticulos.Name = "btnBusquedaArticulos";
            this.btnBusquedaArticulos.Size = new System.Drawing.Size(289, 37);
            this.btnBusquedaArticulos.TabIndex = 12;
            this.btnBusquedaArticulos.Text = "Busqueda de articulos";
            this.btnBusquedaArticulos.UseVisualStyleBackColor = true;
            // 
            // btnModificarArticulos
            // 
            this.btnModificarArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarArticulos.Location = new System.Drawing.Point(131, 251);
            this.btnModificarArticulos.Name = "btnModificarArticulos";
            this.btnModificarArticulos.Size = new System.Drawing.Size(289, 37);
            this.btnModificarArticulos.TabIndex = 13;
            this.btnModificarArticulos.Text = "Modificar articulos";
            this.btnModificarArticulos.UseVisualStyleBackColor = true;
            this.btnModificarArticulos.Click += new System.EventHandler(this.btnModificarArticulos_Click);
            // 
            // btnListadoArticulos
            // 
            this.btnListadoArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListadoArticulos.Location = new System.Drawing.Point(131, 294);
            this.btnListadoArticulos.Name = "btnListadoArticulos";
            this.btnListadoArticulos.Size = new System.Drawing.Size(289, 37);
            this.btnListadoArticulos.TabIndex = 14;
            this.btnListadoArticulos.Text = "Listado de articulos";
            this.btnListadoArticulos.UseVisualStyleBackColor = true;
            this.btnListadoArticulos.Click += new System.EventHandler(this.btnListadoArticulos_Click);
            // 
            // btnEliminarArticulos
            // 
            this.btnEliminarArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarArticulos.Location = new System.Drawing.Point(131, 337);
            this.btnEliminarArticulos.Name = "btnEliminarArticulos";
            this.btnEliminarArticulos.Size = new System.Drawing.Size(289, 37);
            this.btnEliminarArticulos.TabIndex = 15;
            this.btnEliminarArticulos.Text = "Eliminar articulos";
            this.btnEliminarArticulos.UseVisualStyleBackColor = true;
            // 
            // btnDetalleArticulo
            // 
            this.btnDetalleArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalleArticulo.Location = new System.Drawing.Point(131, 380);
            this.btnDetalleArticulo.Name = "btnDetalleArticulo";
            this.btnDetalleArticulo.Size = new System.Drawing.Size(289, 37);
            this.btnDetalleArticulo.TabIndex = 16;
            this.btnDetalleArticulo.Text = "Ver detalle de un articulo";
            this.btnDetalleArticulo.UseVisualStyleBackColor = true;
            // 
            // frmAdminArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 489);
            this.Controls.Add(this.btnDetalleArticulo);
            this.Controls.Add(this.btnEliminarArticulos);
            this.Controls.Add(this.btnListadoArticulos);
            this.Controls.Add(this.btnModificarArticulos);
            this.Controls.Add(this.btnBusquedaArticulos);
            this.Controls.Add(this.btnAgregarArticulo);
            this.Controls.Add(this.lblTituloArticulos);
            this.MaximumSize = new System.Drawing.Size(600, 528);
            this.MinimumSize = new System.Drawing.Size(600, 528);
            this.Name = "frmAdminArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador de Articulos";
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
    }
}
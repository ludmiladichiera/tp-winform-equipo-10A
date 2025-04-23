namespace TPWinForm_equipo_10A
{
    partial class frmAgregarArticulo
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
            this.btnNombre = new System.Windows.Forms.Label();
            this.txtTituloAgregarArticulo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDescripcionArticulo = new System.Windows.Forms.Label();
            this.lblMarcaArticulo = new System.Windows.Forms.Label();
            this.lblCategoriaArticulo = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNombre
            // 
            this.btnNombre.AutoSize = true;
            this.btnNombre.Location = new System.Drawing.Point(117, 160);
            this.btnNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnNombre.Name = "btnNombre";
            this.btnNombre.Size = new System.Drawing.Size(59, 16);
            this.btnNombre.TabIndex = 0;
            this.btnNombre.Text = "Nombre:";
            this.btnNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTituloAgregarArticulo
            // 
            this.txtTituloAgregarArticulo.AutoSize = true;
            this.txtTituloAgregarArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTituloAgregarArticulo.Location = new System.Drawing.Point(221, 52);
            this.txtTituloAgregarArticulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTituloAgregarArticulo.Name = "txtTituloAgregarArticulo";
            this.txtTituloAgregarArticulo.Size = new System.Drawing.Size(287, 39);
            this.txtTituloAgregarArticulo.TabIndex = 1;
            this.txtTituloAgregarArticulo.Text = "Agregar Articulo:";
            this.txtTituloAgregarArticulo.Click += new System.EventHandler(this.txtTituloAgregarArticulo_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(213, 156);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(337, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // lblDescripcionArticulo
            // 
            this.lblDescripcionArticulo.AutoSize = true;
            this.lblDescripcionArticulo.Location = new System.Drawing.Point(117, 192);
            this.lblDescripcionArticulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcionArticulo.Name = "lblDescripcionArticulo";
            this.lblDescripcionArticulo.Size = new System.Drawing.Size(82, 16);
            this.lblDescripcionArticulo.TabIndex = 3;
            this.lblDescripcionArticulo.Text = "Descripcion:";
            // 
            // lblMarcaArticulo
            // 
            this.lblMarcaArticulo.AutoSize = true;
            this.lblMarcaArticulo.Location = new System.Drawing.Point(119, 224);
            this.lblMarcaArticulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarcaArticulo.Name = "lblMarcaArticulo";
            this.lblMarcaArticulo.Size = new System.Drawing.Size(48, 16);
            this.lblMarcaArticulo.TabIndex = 4;
            this.lblMarcaArticulo.Text = "Marca:";
            this.lblMarcaArticulo.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblCategoriaArticulo
            // 
            this.lblCategoriaArticulo.AutoSize = true;
            this.lblCategoriaArticulo.Location = new System.Drawing.Point(119, 257);
            this.lblCategoriaArticulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoriaArticulo.Name = "lblCategoriaArticulo";
            this.lblCategoriaArticulo.Size = new System.Drawing.Size(69, 16);
            this.lblCategoriaArticulo.TabIndex = 5;
            this.lblCategoriaArticulo.Text = "Categoria:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(213, 188);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(337, 22);
            this.txtDescripcion.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(780, 30);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // cboMarca
            // 
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(213, 220);
            this.cboMarca.Margin = new System.Windows.Forms.Padding(4);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(337, 24);
            this.cboMarca.TabIndex = 3;
            this.cboMarca.DropDown += new System.EventHandler(this.cboMarca_DropDown);
            this.cboMarca.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(213, 254);
            this.cboCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(337, 24);
            this.cboCategoria.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 319);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 290);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Precio:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(213, 287);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(337, 22);
            this.txtPrecio.TabIndex = 5;
            this.txtPrecio.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(344, 319);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(119, 128);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(54, 16);
            this.lblCodigo.TabIndex = 16;
            this.lblCodigo.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(213, 124);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(337, 22);
            this.txtCodigo.TabIndex = 0;
            // 
            // frmAgregarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 447);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblCategoriaArticulo);
            this.Controls.Add(this.lblMarcaArticulo);
            this.Controls.Add(this.lblDescripcionArticulo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtTituloAgregarArticulo);
            this.Controls.Add(this.btnNombre);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(795, 484);
            this.Name = "frmAgregarArticulo";
            this.Text = "Agregar Articulo";
            this.Load += new System.EventHandler(this.frmAgregarArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btnNombre;
        private System.Windows.Forms.Label txtTituloAgregarArticulo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDescripcionArticulo;
        private System.Windows.Forms.Label lblMarcaArticulo;
        private System.Windows.Forms.Label lblCategoriaArticulo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
    }
}
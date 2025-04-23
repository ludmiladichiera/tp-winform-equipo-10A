namespace TPWinForm_equipo_10A
{
    partial class frmVerImagen
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
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            this.dgvImagen = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxImagen
            // 
            this.pbxImagen.Location = new System.Drawing.Point(533, 46);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(255, 224);
            this.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagen.TabIndex = 0;
            this.pbxImagen.TabStop = false;
            // 
            // dgvImagen
            // 
            this.dgvImagen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImagen.Location = new System.Drawing.Point(12, 46);
            this.dgvImagen.Name = "dgvImagen";
            this.dgvImagen.RowHeadersWidth = 51;
            this.dgvImagen.RowTemplate.Height = 24;
            this.dgvImagen.Size = new System.Drawing.Size(480, 218);
            this.dgvImagen.TabIndex = 1;
            this.dgvImagen.SelectionChanged += new System.EventHandler(this.dgvImagen_SelectionChanged);
            // 
            // frmVerImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvImagen);
            this.Controls.Add(this.pbxImagen);
            this.Name = "frmVerImagen";
            this.Text = "frmVerImagen";
            this.Load += new System.EventHandler(this.frmVerImagen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxImagen;
        private System.Windows.Forms.DataGridView dgvImagen;
    }
}
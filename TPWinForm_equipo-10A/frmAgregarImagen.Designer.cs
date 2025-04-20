namespace TPWinForm_equipo_10A
{
    partial class frmAgregarImagen
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrlImagen = new System.Windows.Forms.TextBox();
            this.lblUrlImagen = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.btnRigth = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Desea agregar imagen?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtUrlImagen
            // 
            this.txtUrlImagen.Location = new System.Drawing.Point(102, 263);
            this.txtUrlImagen.Name = "txtUrlImagen";
            this.txtUrlImagen.Size = new System.Drawing.Size(254, 20);
            this.txtUrlImagen.TabIndex = 24;
            this.txtUrlImagen.Leave += new System.EventHandler(this.txtUrlImagen_Leave);
            // 
            // lblUrlImagen
            // 
            this.lblUrlImagen.AutoSize = true;
            this.lblUrlImagen.Location = new System.Drawing.Point(31, 266);
            this.lblUrlImagen.Name = "lblUrlImagen";
            this.lblUrlImagen.Size = new System.Drawing.Size(60, 13);
            this.lblUrlImagen.TabIndex = 23;
            this.lblUrlImagen.Text = "Url imagen:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Agregar imagen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(225, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "Omitir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Image = global::TPWinForm_equipo_10A.Properties.Resources._8674414_ic_fluent_arrow_circle_left_icon__1_;
            this.btnLeft.Location = new System.Drawing.Point(30, 188);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(56, 56);
            this.btnLeft.TabIndex = 27;
            this.btnLeft.UseVisualStyleBackColor = true;
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Location = new System.Drawing.Point(92, 12);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(270, 232);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 21;
            this.pbxArticulo.TabStop = false;
            // 
            // btnRigth
            // 
            this.btnRigth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRigth.Image = global::TPWinForm_equipo_10A.Properties.Resources._8674280_ic_fluent_arrow_circle_right_icon__1_;
            this.btnRigth.Location = new System.Drawing.Point(368, 188);
            this.btnRigth.Name = "btnRigth";
            this.btnRigth.Size = new System.Drawing.Size(56, 56);
            this.btnRigth.TabIndex = 28;
            this.btnRigth.UseVisualStyleBackColor = true;
            // 
            // frmAgregarImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 357);
            this.Controls.Add(this.btnRigth);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtUrlImagen);
            this.Controls.Add(this.lblUrlImagen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbxArticulo);
            this.Name = "frmAgregarImagen";
            this.Text = "frmAgregarImagen";
            this.Load += new System.EventHandler(this.frmAgregarImagen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrlImagen;
        private System.Windows.Forms.Label lblUrlImagen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRigth;
    }
}
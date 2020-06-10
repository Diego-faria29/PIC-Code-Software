namespace UI
{
    partial class FRMconsulta
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMconsulta));
            this.LBLNOMEconsulta = new System.Windows.Forms.Label();
            this.btnconsulta = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.MaskedTextBox();
            this.dtgrid1 = new System.Windows.Forms.DataGridView();
            this.LBLconsclientnome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // LBLNOMEconsulta
            // 
            this.LBLNOMEconsulta.AutoSize = true;
            this.LBLNOMEconsulta.BackColor = System.Drawing.Color.Transparent;
            this.LBLNOMEconsulta.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLNOMEconsulta.Location = new System.Drawing.Point(17, 91);
            this.LBLNOMEconsulta.Name = "LBLNOMEconsulta";
            this.LBLNOMEconsulta.Size = new System.Drawing.Size(72, 23);
            this.LBLNOMEconsulta.TabIndex = 0;
            this.LBLNOMEconsulta.Text = "Nome:";
            // 
            // btnconsulta
            // 
            this.btnconsulta.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnconsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnconsulta.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconsulta.ForeColor = System.Drawing.SystemColors.Control;
            this.btnconsulta.Location = new System.Drawing.Point(313, 138);
            this.btnconsulta.Name = "btnconsulta";
            this.btnconsulta.Size = new System.Drawing.Size(122, 35);
            this.btnconsulta.TabIndex = 2;
            this.btnconsulta.Text = "Consultar";
            this.btnconsulta.UseVisualStyleBackColor = false;
            this.btnconsulta.Click += new System.EventHandler(this.btnconsulta_Click);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(95, 88);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(563, 32);
            this.txtNome.TabIndex = 4;
            // 
            // dtgrid1
            // 
            this.dtgrid1.BackgroundColor = System.Drawing.Color.White;
            this.dtgrid1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrid1.Location = new System.Drawing.Point(95, 208);
            this.dtgrid1.Name = "dtgrid1";
            this.dtgrid1.Size = new System.Drawing.Size(563, 350);
            this.dtgrid1.TabIndex = 6;
            this.dtgrid1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrid1_CellDoubleClick);
            // 
            // LBLconsclientnome
            // 
            this.LBLconsclientnome.AutoSize = true;
            this.LBLconsclientnome.BackColor = System.Drawing.Color.Transparent;
            this.LBLconsclientnome.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLconsclientnome.Location = new System.Drawing.Point(91, 53);
            this.LBLconsclientnome.Name = "LBLconsclientnome";
            this.LBLconsclientnome.Size = new System.Drawing.Size(197, 23);
            this.LBLconsclientnome.TabIndex = 7;
            this.LBLconsclientnome.Text = "Consultar por nome";
            // 
            // FRMconsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = global::SoftwarePIC.Properties.Resources.WhatsApp_Image_2020_06_03_at_23_56_30;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(737, 617);
            this.Controls.Add(this.LBLconsclientnome);
            this.Controls.Add(this.dtgrid1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnconsulta);
            this.Controls.Add(this.LBLNOMEconsulta);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FRMconsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TREG.CONTROL. - CONSULTAR CLIENTE";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLNOMEconsulta;
        private System.Windows.Forms.Button btnconsulta;
        private System.Windows.Forms.MaskedTextBox txtNome;
        private System.Windows.Forms.DataGridView dtgrid1;
        private System.Windows.Forms.Label LBLconsclientnome;
    }
}


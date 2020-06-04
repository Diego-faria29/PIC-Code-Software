namespace SoftwarePIC
{
    partial class FRMBuscarvenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMBuscarvenda));
            this.BTNbuscarvenda = new System.Windows.Forms.Button();
            this.dataGridViewBscVnd = new System.Windows.Forms.DataGridView();
            this.TXTnull = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBscVnd)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNbuscarvenda
            // 
            this.BTNbuscarvenda.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTNbuscarvenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNbuscarvenda.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNbuscarvenda.ForeColor = System.Drawing.SystemColors.Window;
            this.BTNbuscarvenda.Location = new System.Drawing.Point(259, 23);
            this.BTNbuscarvenda.Margin = new System.Windows.Forms.Padding(2);
            this.BTNbuscarvenda.Name = "BTNbuscarvenda";
            this.BTNbuscarvenda.Size = new System.Drawing.Size(238, 42);
            this.BTNbuscarvenda.TabIndex = 0;
            this.BTNbuscarvenda.Text = "Buscar vendas";
            this.BTNbuscarvenda.UseVisualStyleBackColor = false;
            this.BTNbuscarvenda.Click += new System.EventHandler(this.BTNbuscarvenda_Click);
            // 
            // dataGridViewBscVnd
            // 
            this.dataGridViewBscVnd.AllowUserToAddRows = false;
            this.dataGridViewBscVnd.AllowUserToDeleteRows = false;
            this.dataGridViewBscVnd.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewBscVnd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBscVnd.Location = new System.Drawing.Point(25, 80);
            this.dataGridViewBscVnd.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewBscVnd.Name = "dataGridViewBscVnd";
            this.dataGridViewBscVnd.ReadOnly = true;
            this.dataGridViewBscVnd.Size = new System.Drawing.Size(689, 472);
            this.dataGridViewBscVnd.TabIndex = 1;
            this.dataGridViewBscVnd.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBscVnd_CellContentDoubleClick);
            // 
            // TXTnull
            // 
            this.TXTnull.BackColor = System.Drawing.Color.White;
            this.TXTnull.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXTnull.Location = new System.Drawing.Point(527, 385);
            this.TXTnull.Margin = new System.Windows.Forms.Padding(2);
            this.TXTnull.Name = "TXTnull";
            this.TXTnull.Size = new System.Drawing.Size(8, 18);
            this.TXTnull.TabIndex = 2;
            // 
            // FRMBuscarvenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SoftwarePIC.Properties.Resources.color_2174049_1280;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(737, 617);
            this.Controls.Add(this.TXTnull);
            this.Controls.Add(this.dataGridViewBscVnd);
            this.Controls.Add(this.BTNbuscarvenda);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "FRMBuscarvenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMBuscarvenda";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBscVnd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNbuscarvenda;
        private System.Windows.Forms.DataGridView dataGridViewBscVnd;
        private System.Windows.Forms.TextBox TXTnull;
    }
}
namespace SoftwarePIC
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.BTNCONScliente = new System.Windows.Forms.Button();
            this.BTNCADcliente = new System.Windows.Forms.Button();
            this.BTN_Venda = new System.Windows.Forms.Button();
            this.BTN_Deletarcliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTNCONScliente
            // 
            this.BTNCONScliente.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTNCONScliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNCONScliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BTNCONScliente.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCONScliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTNCONScliente.Location = new System.Drawing.Point(12, 95);
            this.BTNCONScliente.Name = "BTNCONScliente";
            this.BTNCONScliente.Size = new System.Drawing.Size(173, 58);
            this.BTNCONScliente.TabIndex = 0;
            this.BTNCONScliente.Text = "Consultar cliente";
            this.BTNCONScliente.UseVisualStyleBackColor = false;
            this.BTNCONScliente.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTNCADcliente
            // 
            this.BTNCADcliente.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTNCADcliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTNCADcliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNCADcliente.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCADcliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTNCADcliente.Location = new System.Drawing.Point(12, 31);
            this.BTNCADcliente.Name = "BTNCADcliente";
            this.BTNCADcliente.Size = new System.Drawing.Size(173, 58);
            this.BTNCADcliente.TabIndex = 1;
            this.BTNCADcliente.Text = "Cadastrar cliente";
            this.BTNCADcliente.UseVisualStyleBackColor = false;
            this.BTNCADcliente.Click += new System.EventHandler(this.button2_Click);
            // 
            // BTN_Venda
            // 
            this.BTN_Venda.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_Venda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Venda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BTN_Venda.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Venda.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTN_Venda.Location = new System.Drawing.Point(12, 159);
            this.BTN_Venda.Name = "BTN_Venda";
            this.BTN_Venda.Size = new System.Drawing.Size(173, 58);
            this.BTN_Venda.TabIndex = 2;
            this.BTN_Venda.Text = "Venda";
            this.BTN_Venda.UseVisualStyleBackColor = false;
            this.BTN_Venda.Click += new System.EventHandler(this.BTN_Venda_Click);
            // 
            // BTN_Deletarcliente
            // 
            this.BTN_Deletarcliente.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_Deletarcliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Deletarcliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BTN_Deletarcliente.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Deletarcliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTN_Deletarcliente.Location = new System.Drawing.Point(12, 223);
            this.BTN_Deletarcliente.Name = "BTN_Deletarcliente";
            this.BTN_Deletarcliente.Size = new System.Drawing.Size(173, 58);
            this.BTN_Deletarcliente.TabIndex = 3;
            this.BTN_Deletarcliente.Text = "Deletar cliente";
            this.BTN_Deletarcliente.UseVisualStyleBackColor = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(737, 617);
            this.Controls.Add(this.BTN_Deletarcliente);
            this.Controls.Add(this.BTN_Venda);
            this.Controls.Add(this.BTNCADcliente);
            this.Controls.Add(this.BTNCONScliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TREG.CONTROL. - Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTNCONScliente;
        private System.Windows.Forms.Button BTNCADcliente;
        private System.Windows.Forms.Button BTN_Venda;
        private System.Windows.Forms.Button BTN_Deletarcliente;
    }
}
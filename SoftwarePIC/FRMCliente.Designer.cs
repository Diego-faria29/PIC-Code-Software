namespace SoftwarePIC
{
    partial class FRMCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMCliente));
            this.LBLNome = new System.Windows.Forms.Label();
            this.CADCLIENTE = new System.Windows.Forms.Label();
            this.LBLemail = new System.Windows.Forms.Label();
            this.LBLCPF = new System.Windows.Forms.Label();
            this.LBLtelefone = new System.Windows.Forms.Label();
            this.LBLEndereco = new System.Windows.Forms.Label();
            this.textBox1nome = new System.Windows.Forms.TextBox();
            this.textBox2email = new System.Windows.Forms.TextBox();
            this.textBox3CPF = new System.Windows.Forms.TextBox();
            this.textBox4Telefone = new System.Windows.Forms.TextBox();
            this.textBox5Endereco = new System.Windows.Forms.TextBox();
            this.BTNCad = new System.Windows.Forms.Button();
            this.BTNbuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBLNome
            // 
            this.LBLNome.AutoSize = true;
            this.LBLNome.BackColor = System.Drawing.Color.Transparent;
            this.LBLNome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LBLNome.Location = new System.Drawing.Point(40, 84);
            this.LBLNome.Name = "LBLNome";
            this.LBLNome.Size = new System.Drawing.Size(72, 23);
            this.LBLNome.TabIndex = 0;
            this.LBLNome.Text = "Nome:";
            // 
            // CADCLIENTE
            // 
            this.CADCLIENTE.AutoSize = true;
            this.CADCLIENTE.BackColor = System.Drawing.Color.Transparent;
            this.CADCLIENTE.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CADCLIENTE.Location = new System.Drawing.Point(211, 25);
            this.CADCLIENTE.Name = "CADCLIENTE";
            this.CADCLIENTE.Size = new System.Drawing.Size(274, 30);
            this.CADCLIENTE.TabIndex = 1;
            this.CADCLIENTE.Text = "Cadastro de Clientes";
            // 
            // LBLemail
            // 
            this.LBLemail.AutoSize = true;
            this.LBLemail.BackColor = System.Drawing.Color.Transparent;
            this.LBLemail.Location = new System.Drawing.Point(32, 124);
            this.LBLemail.Name = "LBLemail";
            this.LBLemail.Size = new System.Drawing.Size(80, 23);
            this.LBLemail.TabIndex = 2;
            this.LBLemail.Text = "E-mail:";
            // 
            // LBLCPF
            // 
            this.LBLCPF.AutoSize = true;
            this.LBLCPF.BackColor = System.Drawing.Color.Transparent;
            this.LBLCPF.Location = new System.Drawing.Point(54, 162);
            this.LBLCPF.Name = "LBLCPF";
            this.LBLCPF.Size = new System.Drawing.Size(58, 23);
            this.LBLCPF.TabIndex = 3;
            this.LBLCPF.Text = "CPF:";
            // 
            // LBLtelefone
            // 
            this.LBLtelefone.AutoSize = true;
            this.LBLtelefone.BackColor = System.Drawing.Color.Transparent;
            this.LBLtelefone.Location = new System.Drawing.Point(12, 202);
            this.LBLtelefone.Name = "LBLtelefone";
            this.LBLtelefone.Size = new System.Drawing.Size(100, 23);
            this.LBLtelefone.TabIndex = 4;
            this.LBLtelefone.Text = "Telefone:";
            // 
            // LBLEndereco
            // 
            this.LBLEndereco.AutoSize = true;
            this.LBLEndereco.BackColor = System.Drawing.Color.Transparent;
            this.LBLEndereco.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLEndereco.Location = new System.Drawing.Point(12, 239);
            this.LBLEndereco.Name = "LBLEndereco";
            this.LBLEndereco.Size = new System.Drawing.Size(105, 23);
            this.LBLEndereco.TabIndex = 5;
            this.LBLEndereco.Text = "Endereço:";
            // 
            // textBox1nome
            // 
            this.textBox1nome.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox1nome.Location = new System.Drawing.Point(123, 86);
            this.textBox1nome.Name = "textBox1nome";
            this.textBox1nome.Size = new System.Drawing.Size(549, 32);
            this.textBox1nome.TabIndex = 6;
            this.textBox1nome.Text = "Insira o nome";
            // 
            // textBox2email
            // 
            this.textBox2email.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox2email.Location = new System.Drawing.Point(123, 124);
            this.textBox2email.Name = "textBox2email";
            this.textBox2email.Size = new System.Drawing.Size(549, 32);
            this.textBox2email.TabIndex = 7;
            this.textBox2email.Text = "email@exemplo.com";
            // 
            // textBox3CPF
            // 
            this.textBox3CPF.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox3CPF.Location = new System.Drawing.Point(123, 162);
            this.textBox3CPF.Name = "textBox3CPF";
            this.textBox3CPF.Size = new System.Drawing.Size(549, 32);
            this.textBox3CPF.TabIndex = 8;
            this.textBox3CPF.Text = "123.456.789-01";
            // 
            // textBox4Telefone
            // 
            this.textBox4Telefone.BackColor = System.Drawing.SystemColors.Window;
            this.textBox4Telefone.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox4Telefone.Location = new System.Drawing.Point(123, 202);
            this.textBox4Telefone.Name = "textBox4Telefone";
            this.textBox4Telefone.Size = new System.Drawing.Size(549, 32);
            this.textBox4Telefone.TabIndex = 9;
            this.textBox4Telefone.Text = "35 4002-8922";
            // 
            // textBox5Endereco
            // 
            this.textBox5Endereco.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox5Endereco.Location = new System.Drawing.Point(123, 240);
            this.textBox5Endereco.Name = "textBox5Endereco";
            this.textBox5Endereco.Size = new System.Drawing.Size(549, 32);
            this.textBox5Endereco.TabIndex = 10;
            this.textBox5Endereco.Text = "Rua, número, bairro";
            // 
            // BTNCad
            // 
            this.BTNCad.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTNCad.ForeColor = System.Drawing.SystemColors.Window;
            this.BTNCad.Location = new System.Drawing.Point(540, 301);
            this.BTNCad.Name = "BTNCad";
            this.BTNCad.Size = new System.Drawing.Size(132, 37);
            this.BTNCad.TabIndex = 11;
            this.BTNCad.Text = "Cadastrar";
            this.BTNCad.UseVisualStyleBackColor = false;
            this.BTNCad.Click += new System.EventHandler(this.BTNCad_Click);
            // 
            // BTNbuscar
            // 
            this.BTNbuscar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTNbuscar.ForeColor = System.Drawing.SystemColors.Window;
            this.BTNbuscar.Location = new System.Drawing.Point(387, 301);
            this.BTNbuscar.Name = "BTNbuscar";
            this.BTNbuscar.Size = new System.Drawing.Size(132, 37);
            this.BTNbuscar.TabIndex = 12;
            this.BTNbuscar.Text = "Buscar";
            this.BTNbuscar.UseVisualStyleBackColor = false;
            this.BTNbuscar.Click += new System.EventHandler(this.BTNbuscar_Click);
            // 
            // FRMCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.BTNbuscar);
            this.Controls.Add(this.BTNCad);
            this.Controls.Add(this.textBox5Endereco);
            this.Controls.Add(this.textBox4Telefone);
            this.Controls.Add(this.textBox3CPF);
            this.Controls.Add(this.textBox2email);
            this.Controls.Add(this.textBox1nome);
            this.Controls.Add(this.LBLEndereco);
            this.Controls.Add(this.LBLtelefone);
            this.Controls.Add(this.LBLCPF);
            this.Controls.Add(this.LBLemail);
            this.Controls.Add(this.CADCLIENTE);
            this.Controls.Add(this.LBLNome);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 1000);
            this.Name = "FRMCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TREG.CONTROL. - Cadastro ";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLNome;
        private System.Windows.Forms.Label CADCLIENTE;
        private System.Windows.Forms.Label LBLemail;
        private System.Windows.Forms.Label LBLCPF;
        private System.Windows.Forms.Label LBLtelefone;
        private System.Windows.Forms.Label LBLEndereco;
        private System.Windows.Forms.TextBox textBox1nome;
        private System.Windows.Forms.TextBox textBox2email;
        private System.Windows.Forms.TextBox textBox3CPF;
        private System.Windows.Forms.TextBox textBox4Telefone;
        private System.Windows.Forms.TextBox textBox5Endereco;
        private System.Windows.Forms.Button BTNCad;
        private System.Windows.Forms.Button BTNbuscar;
    }
}


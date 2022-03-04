
namespace TesteEmail
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxHost = new System.Windows.Forms.TextBox();
            this.textboxPorta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkboxSSL = new System.Windows.Forms.CheckBox();
            this.checkboxCredentials = new System.Windows.Forms.CheckBox();
            this.textboxEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textboxSenha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textboxEmailReceber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textboxAssunto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textboxDescricao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonEnviar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.textboxSenha);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textboxEmail);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.checkboxCredentials);
            this.groupBox1.Controls.Add(this.checkboxSSL);
            this.groupBox1.Controls.Add(this.textboxPorta);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textboxHost);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(536, 286);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados de envio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host:";
            // 
            // textboxHost
            // 
            this.textboxHost.Location = new System.Drawing.Point(19, 61);
            this.textboxHost.Name = "textboxHost";
            this.textboxHost.Size = new System.Drawing.Size(215, 22);
            this.textboxHost.TabIndex = 1;
            this.textboxHost.Text = "smtp.office365.com";
            // 
            // textboxPorta
            // 
            this.textboxPorta.Location = new System.Drawing.Point(271, 61);
            this.textboxPorta.Name = "textboxPorta";
            this.textboxPorta.Size = new System.Drawing.Size(215, 22);
            this.textboxPorta.TabIndex = 3;
            this.textboxPorta.Text = "587";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Porta:";
            // 
            // checkboxSSL
            // 
            this.checkboxSSL.AutoSize = true;
            this.checkboxSSL.Location = new System.Drawing.Point(19, 105);
            this.checkboxSSL.Name = "checkboxSSL";
            this.checkboxSSL.Size = new System.Drawing.Size(98, 20);
            this.checkboxSSL.TabIndex = 4;
            this.checkboxSSL.Text = "Enable SSL";
            this.checkboxSSL.UseVisualStyleBackColor = true;
            // 
            // checkboxCredentials
            // 
            this.checkboxCredentials.AutoSize = true;
            this.checkboxCredentials.Location = new System.Drawing.Point(19, 128);
            this.checkboxCredentials.Name = "checkboxCredentials";
            this.checkboxCredentials.Size = new System.Drawing.Size(168, 20);
            this.checkboxCredentials.TabIndex = 5;
            this.checkboxCredentials.Text = "Use Default Credentials";
            this.checkboxCredentials.UseVisualStyleBackColor = true;
            // 
            // textboxEmail
            // 
            this.textboxEmail.Location = new System.Drawing.Point(19, 175);
            this.textboxEmail.Name = "textboxEmail";
            this.textboxEmail.Size = new System.Drawing.Size(328, 22);
            this.textboxEmail.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email:";
            // 
            // textboxSenha
            // 
            this.textboxSenha.Location = new System.Drawing.Point(19, 230);
            this.textboxSenha.Name = "textboxSenha";
            this.textboxSenha.PasswordChar = '*';
            this.textboxSenha.Size = new System.Drawing.Size(328, 22);
            this.textboxSenha.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Senha:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.textboxDescricao);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textboxAssunto);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textboxEmailReceber);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(14, 316);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(536, 247);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados do recebedor";
            // 
            // textboxEmailReceber
            // 
            this.textboxEmailReceber.Location = new System.Drawing.Point(17, 51);
            this.textboxEmailReceber.Multiline = true;
            this.textboxEmailReceber.Name = "textboxEmailReceber";
            this.textboxEmailReceber.Size = new System.Drawing.Size(513, 56);
            this.textboxEmailReceber.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(355, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Email(Separar por vírgula, se for enviar mais de um email):";
            // 
            // textboxAssunto
            // 
            this.textboxAssunto.Location = new System.Drawing.Point(17, 133);
            this.textboxAssunto.Name = "textboxAssunto";
            this.textboxAssunto.Size = new System.Drawing.Size(513, 22);
            this.textboxAssunto.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Assunto:";
            // 
            // textboxDescricao
            // 
            this.textboxDescricao.Location = new System.Drawing.Point(17, 185);
            this.textboxDescricao.Multiline = true;
            this.textboxDescricao.Name = "textboxDescricao";
            this.textboxDescricao.Size = new System.Drawing.Size(513, 56);
            this.textboxDescricao.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Descrição:";
            // 
            // buttonEnviar
            // 
            this.buttonEnviar.Location = new System.Drawing.Point(430, 581);
            this.buttonEnviar.Name = "buttonEnviar";
            this.buttonEnviar.Size = new System.Drawing.Size(114, 39);
            this.buttonEnviar.TabIndex = 11;
            this.buttonEnviar.Text = "Enviar";
            this.buttonEnviar.UseVisualStyleBackColor = true;
            this.buttonEnviar.Click += new System.EventHandler(this.buttonEnviar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(562, 632);
            this.Controls.Add(this.buttonEnviar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Email Teste";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textboxSenha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textboxEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkboxCredentials;
        private System.Windows.Forms.CheckBox checkboxSSL;
        private System.Windows.Forms.TextBox textboxPorta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textboxHost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textboxEmailReceber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textboxDescricao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textboxAssunto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonEnviar;
    }
}


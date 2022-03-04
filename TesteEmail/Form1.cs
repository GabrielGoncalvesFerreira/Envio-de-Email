using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteEmail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void enviarEmail(string host, int porta, bool ssl, bool credentials, string emailsEnvio, string assunto, string descricao, string email, string senha)
        {
            int emailsEnviados = 0;
            System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient();
            client.Host = host;
            client.Port = porta;
            client.EnableSsl = ssl;
            client.UseDefaultCredentials = credentials;
            client.Credentials = new System.Net.NetworkCredential(emailsEnvio, senha);
            MailMessage mail = new MailMessage();
            mail.Sender = new System.Net.Mail.MailAddress(emailsEnvio, "Teste");
            mail.From = new MailAddress(emailsEnvio, "Teste");

            string[] emails = email.Split(',');
            foreach (var endereco in emails)
            {
                mail.To.Add(new MailAddress(endereco));
                emailsEnviados++;
            }

            mail.Subject = assunto;
            mail.Body = descricao;
            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.High;

            try
            {
                client.Send(mail);
                MessageBox.Show("Foram enviados: " + emailsEnviados.ToString());
            }
            catch (System.Exception erro)
            {
                MessageBox.Show("Erro\n" + erro.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                mail = null;
            }
        }

        private void buttonEnviar_Click(object sender, EventArgs e)
        {
            enviarEmail(textboxHost.Text, Convert.ToInt32(textboxPorta.Text), checkboxSSL.Checked, checkboxCredentials.Checked, textboxEmail.Text, textboxAssunto.Text, textboxDescricao.Text, textboxEmailReceber.Text, textboxSenha.Text);
        }
    }
}

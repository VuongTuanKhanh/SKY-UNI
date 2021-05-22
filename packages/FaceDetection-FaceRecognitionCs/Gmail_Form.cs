using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Net.Mail;

namespace MultiFaceRec
{
	public partial class Gmail_Form : Form
	{
        private string pathFile;

		public Gmail_Form()
		{
			InitializeComponent();
		}

		private void btn_Attach_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
                pathFile = dialog.FileName;
			}
		}


		Attachment attach = null;
		private void btn_Send_Click(object sender, EventArgs e)
		{
			attach = null;
			try
			{
				FileInfo file = new FileInfo(pathFile);
				attach = new Attachment(pathFile);
			}
			catch { }
			GuiMail(txtTenDangNhap.Text, txtTo.Text, txtSubject.Text, txtMessage.Text);
		}


		void GuiMail(string from, string to, string subject, string message, Attachment file = null)
		{
			MailMessage mess = new MailMessage(from, to, subject, message);
			if (attach != null)
			{
				mess.Attachments.Add(attach);
			}

			SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
			client.EnableSsl = true;
			client.Credentials = new NetworkCredential(txtTenDangNhap.Text, txtMatKhau.Text);
            try
            {
                client.Send(mess);
            }
            catch
            {
                MessageBox.Show("Wrong Email or Password !");
                return;
            }

			MessageBox.Show("Finished !");
		}

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

using Hackathon.BSLayer;
using System;
using System.Net.Mail;
using System.Threading;
using System.Windows.Forms;

namespace Hackathon
{
    public partial class frmForgetPassword : MyForm
    {
        private Thread threadEmail;

        public frmForgetPassword()
        {
            InitializeComponent();
        }

        string Gmail;
        int New_Password;

        private void button1_Click(object sender, EventArgs e)
        {
            // Take out the Username
            string Username = txtUsername.Text;

            // Take out the Gmail from the Username
            ForgetPasswordBS forgetPasswordBS = new ForgetPasswordBS();
            Gmail = forgetPasswordBS.Send_Mail_To(Username);

            // Generate a new Password
            Random rd = new Random();
            New_Password = rd.Next(1000000, 99999999);
            forgetPasswordBS.Change_Password(Username, New_Password.ToString());

            // Send Email
            try
            {
                threadEmail = new Thread(send_Email);
                threadEmail.SetApartmentState(ApartmentState.STA);
                threadEmail.Start();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to connect");
            }
        }
        private void send_Email()
        {            
            CommonFunction.Send_Email("17110313@student.hcmute.edu.vn", Gmail, "Reset Password", "Mật khẩu mới của bạn là: " + New_Password);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmForgetPassword_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownForm(e, this);
        }

        private void frmForgetPassword_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMoveForm(e, this);
        }

        private void frmForgetPassword_MouseUp(object sender, MouseEventArgs e)
        {
            mouseUpForm(this);
        }
    }
}

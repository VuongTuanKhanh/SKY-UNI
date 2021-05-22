using System;
using System.Drawing;
using Hackathon.BSLayer;
using System.Windows.Forms;
using ZXing;

namespace Hackathon
{
    public partial class Lost_Card : Form
    {
        public Lost_Card()
        {
            InitializeComponent();
        }

        private void ReadBarcode(Bitmap bitmap)
        {
            try
            {
                BarcodeReader reader = new BarcodeReader();
                Result result = reader.Decode((Bitmap)pictureBox.Image);
                string decoded = "";
                if (result != null)
                {
                    txtResult.ResetText();
                    decoded = decoded + result.ToString();
                    if (decoded != "")
                    {
                        txtResult.Text = decoded;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                //dlg.Filter = "bmp files (*.bmp)|*.bmp";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    Bitmap bitmap = null;
                    try
                    {
                        bitmap = new Bitmap(dlg.FileName);
                    }
                    catch
                    {
                        MessageBox.Show("File not supported.");
                        return;
                    }
                    pictureBox.Image = bitmap;
                    ReadBarcode((Bitmap)pictureBox.Image);
                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string Username = txtResult.Text;
            LoginBS loginBS = new LoginBS();
            CommonFunction.Send_Email_1("17110313@student.hcmute.edu.vn", loginBS.Get_Gmail(Username), "Warning", "Bạn đã đánh mất thẻ sinh viên, xin vui lòng liên hệ " + txtContact.Text + " để nhận lại. Trân trọng");
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

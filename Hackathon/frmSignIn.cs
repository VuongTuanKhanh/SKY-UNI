using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Hackathon.BSLayer;
using ZXing;
using ZXing.Common;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing;

namespace Hackathon
{
    public partial class frmSignin : MyForm
    {
        private bool isShow = false;
        private int widthForm;
        private int heightForm;

        public frmSignin()
        {
            InitializeComponent();
        }

        // Sign In
        private void btnSingin_Click(object sender, EventArgs e)
        {
            // Check for INT format
            try
            {
                int temp = int.Parse(txtUsername.Text);
            }
            catch
            {
                MessageBox.Show("Invalid ID", "Warning");
                return;
            }

            // Variables
            string Username = txtUsername.Text;
            string Password = txtPassword.Text;
            string Gmail = txtGmail.Text;

            //// Check for valid Gmail
            //if (!CommonFunction.Check_Gmail(Gmail))
            //{
            //    MessageBox.Show("Invalid Gmail", "Warning");
            //    return;
            //}

            // New Instance
            RegisterBS registerBS = new RegisterBS();

            // Check for new ID
            if (registerBS.Check_Username(Username) == "True")
            {
                MessageBox.Show("This ID has already registed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Add new data to SQL
            try
            {
                registerBS.Regist(Username, Password, Gmail);
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }

            // Generate QR Code
            var barcodeWriter = new BarcodeWriter
            {
                Format = BarcodeFormat.QR_CODE,
                Options = new EncodingOptions
                {
                    Height = 150,
                    Width = 150,
                    Margin = 0
                }
            };

            using (var bitmap = barcodeWriter.Write(Username))
            {
                using (var stream = new MemoryStream())
                {
                    bitmap.Save(stream, ImageFormat.Png);
                    var image = Image.FromStream(stream);
                    QR_Picturebox.Image = image;
                }
            }

            // Generate Barcode
            BarcodeLib.Barcode b = new BarcodeLib.Barcode();
            BarcodeLib.AlignmentPositions alignment = BarcodeLib.AlignmentPositions.CENTER;
            BarcodeLib.TYPE type = BarcodeLib.TYPE.CODE39;
            try
            {
                if (type != BarcodeLib.TYPE.UNSPECIFIED)
                {
                    RotateFlipType rotateFlipType = (RotateFlipType)Enum.Parse(typeof(RotateFlipType), "RotateNoneFlipNone", true);
                    BarcodeLib.LabelPositions labelPosition = (BarcodeLib.LabelPositions)Enum.Parse(typeof(BarcodeLib.LabelPositions), "BottomCenter", true);
                    Barcode_Picturebox.Image = b.Encode(type, Username, b.ForeColor, b.BackColor, 300, 150, alignment, rotateFlipType, true, labelPosition);
                }
                Barcode_Picturebox.Width = Barcode_Picturebox.Image.Width;
                Barcode_Picturebox.Height = Barcode_Picturebox.Image.Height;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("Thank you for your request! Please save these image for your next Login!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (!isShow)
            {
                resizeShow();
                pnlShow.Show();
                isShow = true;
            }
            else
            {
                resizeClose();
                pnlShow.Hide();
                isShow = false;
            }
        }

        private void resizeShow()
        {
            this.Size = new Size(widthForm, heightForm + pnlShow.Size.Height);
        }

        private void resizeClose()
        {
            this.Size = new Size(widthForm,heightForm);
        }

        // Save Image
        

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmSignin_Load(object sender, EventArgs e)
        {
            pnlShow.Hide();
            widthForm = this.Size.Width;
            heightForm = this.Size.Height;
        }

        private void frmSignin_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownForm(e, this);
        }

        private void frmSignin_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMoveForm(e, this);
        }

        private void frmSignin_MouseUp(object sender, MouseEventArgs e)
        {
            mouseUpForm(this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "BMP (*.bmp)|*.bmp|GIF (*.gif)|*.gif|JPG (*.jpg)|*.jpg|PNG (*.png)|*.png|TIFF (*.tif)|*.tif";
            sfd.FilterIndex = 3;
            sfd.AddExtension = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //BarcodeLib.SaveTypes savetype = BarcodeLib.SaveTypes.UNSPECIFIED;
                ImageFormat savetype = ImageFormat.Jpeg;
                switch (sfd.FilterIndex)
                {
                    case 1: /* BMP */  savetype = ImageFormat.Bmp; break;
                    case 2: /* GIF */  savetype = ImageFormat.Gif; break;
                    case 3: /* JPG */  savetype = ImageFormat.Jpeg; break;
                    case 4: /* PNG */  savetype = ImageFormat.Png; break;
                    case 5: /* TIFF */ savetype = ImageFormat.Tiff; break;
                    default: break;
                }
                Barcode_Picturebox.Image.Save(sfd.FileName + "_Barcode", savetype);
                QR_Picturebox.Image.Save(sfd.FileName + "_QR", savetype);
            }
        }
    }
}

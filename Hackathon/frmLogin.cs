using Hackathon.BSLayer;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using TouchlessLib;
using ZXing;
using MultiFaceRec;
namespace Hackathon
{
    public partial class frmLogin : MyForm
    {

        #region Constructor
        public TouchlessMgr _touch;
        private Thread threadForm;

        public frmLogin()
        {
            InitializeComponent();
        }
        #endregion

        #region Code Scanner
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
        #endregion

        #region Webcame Activities
        public void StartCamera()
        {
            if (_touch.Cameras.Count == 0)
            {
                MessageBox.Show("No USB webcam connected");
                return;
            }
            _touch.CurrentCamera = _touch.Cameras[0];
            _touch.CurrentCamera.CaptureWidth = Constant._previewWidth;
            _touch.CurrentCamera.CaptureWidth = Constant._previewHeight;
            _touch.CurrentCamera.OnImageCaptured += new EventHandler<CameraEventArgs>(OnImageCaptured);
        }

        public void StopCamera()
        {
            try
            {
                if (_touch.CurrentCamera != null)
                {
                    _touch.CurrentCamera.OnImageCaptured -= new EventHandler<CameraEventArgs>(OnImageCaptured);
                    _touch.CurrentCamera.Dispose();
                    //_touch.RefreshCameraList();
                }
            }
            catch
            {
                return;
            }
        }

        private void OnImageCaptured(object sender, CameraEventArgs args)
        {
            Bitmap bitmap = args.Image;
            try
            {
                this.Invoke((MethodInvoker)delegate
                {
                    pictureBox.Image = bitmap;
                    ReadBarcode(bitmap);
                });
            }
            catch
            {
                return;
            }
        }
        #endregion

        #region Button Event

        // Login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Check ID format
            try
            {
                int.Parse(txtUsername.Text);
            }
            catch
            {
                MessageBox.Show("Invalid ID format !", "Warning");
                return;
            }

            // Arguments
            string Username = txtUsername.Text;
            string Password = txtPassword.Text;
            LoginBS loginBS = new LoginBS();
            if (bool.Parse(loginBS.Login(Username, Password)))
            {
                StopCamera();
                this.Hide();

                Thread thread = new Thread(new ThreadStart(WorkThreadFunction));
                thread.Start();

                FrmPrincipal frmPrincipal = new FrmPrincipal();
                frmPrincipal.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("Username or Password incorrect. Please try again.");
        }
        public void WorkThreadFunction()
        {
            _touch.Dispose();
        }

        // Load Form
        private void btnSignup_Load(object sender, EventArgs e)
        {
            _touch = new TouchlessMgr();
            StartCamera();
        }

        // Close Form
        private void btnSignup_FormClosed(object sender, FormClosedEventArgs e)
        {
            StopCamera();
        }

        // Load File Button
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
                    StopCamera();
                    pictureBox.Image = bitmap;
                    ReadBarcode((Bitmap)pictureBox.Image);
                }
            }
        }

        // Forget Password
        private void lbForgetPassword_Click(object sender, EventArgs e)
        {
            threadForm = new Thread(openFormForgetPassword);
            threadForm.SetApartmentState(ApartmentState.STA);
            threadForm.Start();
        }

        // Sign In
        private void lbSignin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSignin frmSignin = new frmSignin();
            this.Hide();
            frmSignin.ShowDialog();
            this.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion

        #region Mouse Activities
        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownForm(e, this);
        }

        private void frmLogin_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMoveForm(e, this);
        }

        private void frmLogin_MouseUp(object sender, MouseEventArgs e)
        {
            mouseUpForm(this);
        }
        #endregion

        #region Other Function
        private void openFormForgetPassword()
        {
            Application.Run(new frmForgetPassword());
        }

        // Login with Scanner
        private void txtResult_TextChanged(object sender, EventArgs e)
        {
            string Username = txtResult.Text;
            LoginBS loginBS = new LoginBS();
            try
            {
                if (loginBS.Login(Username) == "True")
                {
                    this.Hide();
                    StopCamera();
                    FrmPrincipal frmPrincipal = new FrmPrincipal();
                    frmPrincipal.ShowDialog();
                    this.Close();
                }
            }
            catch
            {
                return;
            }

        }
        #endregion

        private void btnLost_Click(object sender, EventArgs e)
        {
            Lost_Card lost_Card = new Lost_Card();
            lost_Card.ShowDialog();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
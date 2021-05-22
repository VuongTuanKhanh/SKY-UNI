namespace Hackathon
{
    partial class frmSignin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSignin));
            this.txtPassword = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGmail = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.pnlShow = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.Barcode_Picturebox = new System.Windows.Forms.PictureBox();
            this.QR_Picturebox = new System.Windows.Forms.PictureBox();
            this.btnSignin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMini = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Barcode_Picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QR_Picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.BorderColorFocused = System.Drawing.Color.BlueViolet;
            this.txtPassword.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(61)))), ((int)(((byte)(124)))));
            this.txtPassword.BorderColorMouseHover = System.Drawing.Color.BlueViolet;
            this.txtPassword.BorderThickness = 3;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.isPassword = false;
            this.txtPassword.Location = new System.Drawing.Point(173, 123);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(280, 44);
            this.txtPassword.TabIndex = 14;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(73, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "PASSWORD:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(73, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID STUDENT:";
            // 
            // txtUsername
            // 
            this.txtUsername.BorderColorFocused = System.Drawing.Color.BlueViolet;
            this.txtUsername.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(61)))), ((int)(((byte)(124)))));
            this.txtUsername.BorderColorMouseHover = System.Drawing.Color.BlueViolet;
            this.txtUsername.BorderThickness = 3;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.isPassword = false;
            this.txtUsername.Location = new System.Drawing.Point(173, 71);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(280, 44);
            this.txtUsername.TabIndex = 12;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(73, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "EMAIL:";
            // 
            // txtGmail
            // 
            this.txtGmail.BorderColorFocused = System.Drawing.Color.BlueViolet;
            this.txtGmail.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(61)))), ((int)(((byte)(124)))));
            this.txtGmail.BorderColorMouseHover = System.Drawing.Color.BlueViolet;
            this.txtGmail.BorderThickness = 3;
            this.txtGmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtGmail.ForeColor = System.Drawing.Color.White;
            this.txtGmail.isPassword = false;
            this.txtGmail.Location = new System.Drawing.Point(173, 178);
            this.txtGmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtGmail.Name = "txtGmail";
            this.txtGmail.Size = new System.Drawing.Size(280, 44);
            this.txtGmail.TabIndex = 16;
            this.txtGmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pnlShow
            // 
            this.pnlShow.Controls.Add(this.btnSave);
            this.pnlShow.Controls.Add(this.Barcode_Picturebox);
            this.pnlShow.Controls.Add(this.QR_Picturebox);
            this.pnlShow.Location = new System.Drawing.Point(40, 316);
            this.pnlShow.Name = "pnlShow";
            this.pnlShow.Size = new System.Drawing.Size(467, 218);
            this.pnlShow.TabIndex = 20;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(189, 171);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 44);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // Barcode_Picturebox
            // 
            this.Barcode_Picturebox.InitialImage = ((System.Drawing.Image)(resources.GetObject("Barcode_Picturebox.InitialImage")));
            this.Barcode_Picturebox.Location = new System.Drawing.Point(189, 3);
            this.Barcode_Picturebox.Name = "Barcode_Picturebox";
            this.Barcode_Picturebox.Size = new System.Drawing.Size(275, 154);
            this.Barcode_Picturebox.TabIndex = 6;
            this.Barcode_Picturebox.TabStop = false;
            // 
            // QR_Picturebox
            // 
            this.QR_Picturebox.InitialImage = global::Hackathon.Properties.Resources.Google_Station_free_wifi_1280x720;
            this.QR_Picturebox.Location = new System.Drawing.Point(3, 3);
            this.QR_Picturebox.Name = "QR_Picturebox";
            this.QR_Picturebox.Size = new System.Drawing.Size(161, 154);
            this.QR_Picturebox.TabIndex = 4;
            this.QR_Picturebox.TabStop = false;
            // 
            // btnSignin
            // 
            this.btnSignin.Activecolor = System.Drawing.Color.BlueViolet;
            this.btnSignin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(134)))), ((int)(((byte)(252)))));
            this.btnSignin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSignin.BorderRadius = 7;
            this.btnSignin.ButtonText = "Register";
            this.btnSignin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignin.DisabledColor = System.Drawing.Color.Gray;
            this.btnSignin.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSignin.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSignin.Iconimage")));
            this.btnSignin.Iconimage_right = null;
            this.btnSignin.Iconimage_right_Selected = null;
            this.btnSignin.Iconimage_Selected = null;
            this.btnSignin.IconMarginLeft = 0;
            this.btnSignin.IconMarginRight = 0;
            this.btnSignin.IconRightVisible = true;
            this.btnSignin.IconRightZoom = 0D;
            this.btnSignin.IconVisible = true;
            this.btnSignin.IconZoom = 90D;
            this.btnSignin.IsTab = false;
            this.btnSignin.Location = new System.Drawing.Point(144, 246);
            this.btnSignin.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnSignin.Name = "btnSignin";
            this.btnSignin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(134)))), ((int)(((byte)(252)))));
            this.btnSignin.OnHovercolor = System.Drawing.Color.BlueViolet;
            this.btnSignin.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSignin.selected = false;
            this.btnSignin.Size = new System.Drawing.Size(255, 56);
            this.btnSignin.TabIndex = 19;
            this.btnSignin.Text = "Register";
            this.btnSignin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSignin.Textcolor = System.Drawing.Color.White;
            this.btnSignin.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignin.Click += new System.EventHandler(this.btnSingin_Click);
            // 
            // btnMini
            // 
            this.btnMini.BackColor = System.Drawing.Color.Transparent;
            this.btnMini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMini.Image = ((System.Drawing.Image)(resources.GetObject("btnMini.Image")));
            this.btnMini.ImageActive = null;
            this.btnMini.Location = new System.Drawing.Point(463, 12);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(34, 30);
            this.btnMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMini.TabIndex = 11;
            this.btnMini.TabStop = false;
            this.btnMini.Zoom = 10;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(503, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(34, 30);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 10;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmSignin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(549, 316);
            this.Controls.Add(this.pnlShow);
            this.Controls.Add(this.btnSignin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMini);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSignin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSignIn";
            this.Load += new System.EventHandler(this.frmSignin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmSignin_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmSignin_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmSignin_MouseUp);
            this.pnlShow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Barcode_Picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QR_Picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox QR_Picturebox;
        private System.Windows.Forms.PictureBox Barcode_Picturebox;
        private Bunifu.Framework.UI.BunifuImageButton btnMini;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtUsername;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtGmail;
        private Bunifu.Framework.UI.BunifuFlatButton btnSignin;
        private System.Windows.Forms.Panel pnlShow;
        private System.Windows.Forms.Button btnSave;
    }
}
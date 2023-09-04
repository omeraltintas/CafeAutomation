namespace Cafeautomation.WinForms.Users
{
    partial class frmUserLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserLogin));
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnForgotPass = new DevExpress.XtraEditors.SimpleButton();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.kayitol = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(0, 0);
            this.pictureEdit1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(172, 313);
            this.pictureEdit1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnClose);
            this.groupControl1.Controls.Add(this.btnForgotPass);
            this.groupControl1.Controls.Add(this.btnLogin);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(172, 167);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(431, 146);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "İşlemler";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(292, 51);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(123, 71);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Kapat";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnForgotPass
            // 
            this.btnForgotPass.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnForgotPass.ImageOptions.Image")));
            this.btnForgotPass.Location = new System.Drawing.Point(146, 51);
            this.btnForgotPass.Margin = new System.Windows.Forms.Padding(4);
            this.btnForgotPass.Name = "btnForgotPass";
            this.btnForgotPass.Size = new System.Drawing.Size(138, 71);
            this.btnForgotPass.TabIndex = 0;
            this.btnForgotPass.Text = "Şifremi Unuttum";
            this.btnForgotPass.Click += new System.EventHandler(this.btnForgotPass_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.ImageOptions.Image")));
            this.btnLogin.Location = new System.Drawing.Point(8, 51);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(131, 71);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Giriş Yap";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(215, 18);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txtUserName.Properties.ContextImageOptions.Image")));
            this.txtUserName.Properties.NullText = "Kullanıcı adı girin";
            this.txtUserName.Size = new System.Drawing.Size(227, 20);
            this.txtUserName.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(216, 89);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txtPassword.Properties.ContextImageOptions.Image")));
            this.txtPassword.Properties.NullValuePrompt = "Şifre girin";
            this.txtPassword.Properties.UseSystemPasswordChar = true;
            this.txtPassword.Size = new System.Drawing.Size(227, 20);
            this.txtPassword.TabIndex = 5;
            // 
            // kayitol
            // 
            this.kayitol.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.kayitol.Appearance.Options.UseFont = true;
            this.kayitol.Location = new System.Drawing.Point(392, 131);
            this.kayitol.Margin = new System.Windows.Forms.Padding(4);
            this.kayitol.Name = "kayitol";
            this.kayitol.Size = new System.Drawing.Size(50, 18);
            this.kayitol.TabIndex = 6;
            this.kayitol.Text = "Kayıt Ol";
            this.kayitol.Click += new System.EventHandler(this.hyperlinkLabelControl1_Click);
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(217, 129);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.checkEdit1.Properties.Appearance.Options.UseFont = true;
            this.checkEdit1.Properties.Caption = "Beni Hatırla";
            this.checkEdit1.Size = new System.Drawing.Size(95, 20);
            this.checkEdit1.TabIndex = 7;
            // 
            // frmUserLogin
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 313);
            this.Controls.Add(this.checkEdit1);
            this.Controls.Add(this.kayitol);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.pictureEdit1);
            this.Font = new System.Drawing.Font("Tahoma", 11F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUserLogin";
            this.Text = "Kullanıcı Girişi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUserLogin_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnForgotPass;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.HyperlinkLabelControl kayitol;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
    }
}
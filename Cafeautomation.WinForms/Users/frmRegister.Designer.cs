namespace Cafeautomation.WinForms.Users
{
    partial class frmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtNameSurname = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.toggleActive = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtPhone = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtAdress = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtRole = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtUsername = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtRepass = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtQuestion = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtAnswer = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txtDesc = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameSurname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRole.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRepass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuestion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnswer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesc.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl2.Location = new System.Drawing.Point(27, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(91, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Durumu";
            // 
            // txtNameSurname
            // 
            this.txtNameSurname.Location = new System.Drawing.Point(147, 43);
            this.txtNameSurname.Name = "txtNameSurname";
            this.txtNameSurname.Size = new System.Drawing.Size(146, 20);
            this.txtNameSurname.TabIndex = 6;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnClose);
            this.groupControl1.Controls.Add(this.btnSave);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 468);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(606, 100);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "İşlemler";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(495, 26);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 62);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Kapat";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(5, 26);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 62);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Kaydet";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl1.Location = new System.Drawing.Point(27, 51);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(91, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Ad Soyad";
            // 
            // toggleActive
            // 
            this.toggleActive.Location = new System.Drawing.Point(147, 13);
            this.toggleActive.Name = "toggleActive";
            this.toggleActive.Properties.OffText = "Aktif Değil";
            this.toggleActive.Properties.OnText = "Aktif";
            this.toggleActive.Size = new System.Drawing.Size(132, 18);
            this.toggleActive.TabIndex = 8;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl3.Location = new System.Drawing.Point(27, 90);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(91, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Telefon";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(147, 83);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(146, 20);
            this.txtPhone.TabIndex = 6;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseTextOptions = true;
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl4.Location = new System.Drawing.Point(27, 137);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(91, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Adres";
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(147, 130);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(146, 20);
            this.txtAdress.TabIndex = 6;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseTextOptions = true;
            this.labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl5.Location = new System.Drawing.Point(27, 181);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(91, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Email";
            this.labelControl5.Click += new System.EventHandler(this.labelControl5_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(147, 174);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(146, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseTextOptions = true;
            this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl6.Location = new System.Drawing.Point(27, 226);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(91, 13);
            this.labelControl6.TabIndex = 4;
            this.labelControl6.Text = "Görevi";
            this.labelControl6.Click += new System.EventHandler(this.labelControl5_Click);
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(147, 219);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(146, 20);
            this.txtRole.TabIndex = 6;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseTextOptions = true;
            this.labelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl7.Location = new System.Drawing.Point(27, 271);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(91, 13);
            this.labelControl7.TabIndex = 4;
            this.labelControl7.Text = "Kullanıcı Adı";
            this.labelControl7.Click += new System.EventHandler(this.labelControl5_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(147, 264);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(146, 20);
            this.txtUsername.TabIndex = 6;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Appearance.Options.UseTextOptions = true;
            this.labelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl8.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl8.Location = new System.Drawing.Point(27, 312);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(91, 13);
            this.labelControl8.TabIndex = 4;
            this.labelControl8.Text = "Parola";
            this.labelControl8.Click += new System.EventHandler(this.labelControl5_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(147, 305);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.UseSystemPasswordChar = true;
            this.txtPassword.Size = new System.Drawing.Size(146, 20);
            this.txtPassword.TabIndex = 6;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Appearance.Options.UseTextOptions = true;
            this.labelControl9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl9.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl9.Location = new System.Drawing.Point(27, 364);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(91, 13);
            this.labelControl9.TabIndex = 4;
            this.labelControl9.Text = "Parola Tekrar";
            this.labelControl9.Click += new System.EventHandler(this.labelControl5_Click);
            // 
            // txtRepass
            // 
            this.txtRepass.Location = new System.Drawing.Point(147, 357);
            this.txtRepass.Name = "txtRepass";
            this.txtRepass.Properties.UseSystemPasswordChar = true;
            this.txtRepass.Size = new System.Drawing.Size(146, 20);
            this.txtRepass.TabIndex = 6;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Appearance.Options.UseTextOptions = true;
            this.labelControl10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl10.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl10.Location = new System.Drawing.Point(27, 400);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(91, 13);
            this.labelControl10.TabIndex = 4;
            this.labelControl10.Text = "Soru";
            this.labelControl10.Click += new System.EventHandler(this.labelControl5_Click);
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(147, 393);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(146, 20);
            this.txtQuestion.TabIndex = 6;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Appearance.Options.UseTextOptions = true;
            this.labelControl11.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl11.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl11.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl11.Location = new System.Drawing.Point(314, 50);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(91, 13);
            this.labelControl11.TabIndex = 4;
            this.labelControl11.Text = "Cevap";
            this.labelControl11.Click += new System.EventHandler(this.labelControl5_Click);
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(434, 43);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(146, 20);
            this.txtAnswer.TabIndex = 6;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Appearance.Options.UseTextOptions = true;
            this.labelControl12.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl12.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl12.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl12.Location = new System.Drawing.Point(314, 90);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(91, 13);
            this.labelControl12.TabIndex = 4;
            this.labelControl12.Text = "Açıklama";
            this.labelControl12.Click += new System.EventHandler(this.labelControl5_Click);
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(434, 90);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(146, 96);
            this.txtDesc.TabIndex = 9;
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 568);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.toggleActive);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.txtRepass);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtNameSurname);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl2);
            this.Name = "frmRegister";
            this.Text = "Kaydol";
            this.Load += new System.EventHandler(this.frmRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNameSurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toggleActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRole.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRepass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuestion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnswer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesc.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtNameSurname;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ToggleSwitch toggleActive;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtPhone;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtAdress;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtRole;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtUsername;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtRepass;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit txtQuestion;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txtAnswer;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.MemoEdit txtDesc;
    }
}
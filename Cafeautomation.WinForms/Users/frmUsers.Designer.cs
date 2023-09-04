namespace Cafeautomation.WinForms.Users
{
    partial class frmUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsers));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnRoles = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNameSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRole = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRegisterDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReminderQuestion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAnswer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsAdmin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserActions = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTables = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnClose);
            this.groupControl1.Controls.Add(this.btnSave);
            this.groupControl1.Controls.Add(this.btnRoles);
            this.groupControl1.Controls.Add(this.btnUpdate);
            this.groupControl1.Controls.Add(this.btnNew);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 419);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(802, 100);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "İşlemler";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(691, 26);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 62);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Kapat";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(331, 26);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 62);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Kaydet";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRoles
            // 
            this.btnRoles.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRoles.ImageOptions.Image")));
            this.btnRoles.Location = new System.Drawing.Point(226, 26);
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.Size = new System.Drawing.Size(99, 62);
            this.btnRoles.TabIndex = 0;
            this.btnRoles.Text = "Roller";
            this.btnRoles.Click += new System.EventHandler(this.btnRoles_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(121, 26);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(99, 62);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNew
            // 
            this.btnNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.ImageOptions.Image")));
            this.btnNew.Location = new System.Drawing.Point(5, 26);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(99, 62);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "Yeni";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(802, 419);
            this.gridControl1.TabIndex = 9;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colNameSurname,
            this.colPhone,
            this.colAdress,
            this.colEmail,
            this.colRole,
            this.colUserName,
            this.colPassword,
            this.colDescription,
            this.colRegisterDate,
            this.colIsActive,
            this.colReminderQuestion,
            this.colAnswer,
            this.colIsAdmin,
            this.colUserActions,
            this.colTables});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colNameSurname
            // 
            this.colNameSurname.FieldName = "NameSurname";
            this.colNameSurname.Name = "colNameSurname";
            this.colNameSurname.OptionsColumn.AllowEdit = false;
            this.colNameSurname.Visible = true;
            this.colNameSurname.VisibleIndex = 1;
            // 
            // colPhone
            // 
            this.colPhone.FieldName = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.OptionsColumn.AllowEdit = false;
            this.colPhone.Visible = true;
            this.colPhone.VisibleIndex = 2;
            // 
            // colAdress
            // 
            this.colAdress.FieldName = "Adress";
            this.colAdress.Name = "colAdress";
            this.colAdress.OptionsColumn.AllowEdit = false;
            this.colAdress.Visible = true;
            this.colAdress.VisibleIndex = 3;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.OptionsColumn.AllowEdit = false;
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 4;
            // 
            // colRole
            // 
            this.colRole.FieldName = "Role";
            this.colRole.Name = "colRole";
            this.colRole.OptionsColumn.AllowEdit = false;
            this.colRole.Visible = true;
            this.colRole.VisibleIndex = 5;
            // 
            // colUserName
            // 
            this.colUserName.FieldName = "UserName";
            this.colUserName.Name = "colUserName";
            this.colUserName.OptionsColumn.AllowEdit = false;
            this.colUserName.Visible = true;
            this.colUserName.VisibleIndex = 6;
            // 
            // colPassword
            // 
            this.colPassword.FieldName = "Password";
            this.colPassword.Name = "colPassword";
            this.colPassword.OptionsColumn.AllowEdit = false;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.OptionsColumn.AllowEdit = false;
            // 
            // colRegisterDate
            // 
            this.colRegisterDate.FieldName = "RegisterDate";
            this.colRegisterDate.Name = "colRegisterDate";
            this.colRegisterDate.OptionsColumn.AllowEdit = false;
            this.colRegisterDate.Visible = true;
            this.colRegisterDate.VisibleIndex = 7;
            // 
            // colIsActive
            // 
            this.colIsActive.FieldName = "IsActive";
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.Visible = true;
            this.colIsActive.VisibleIndex = 10;
            // 
            // colReminderQuestion
            // 
            this.colReminderQuestion.FieldName = "ReminderQuestion";
            this.colReminderQuestion.Name = "colReminderQuestion";
            this.colReminderQuestion.OptionsColumn.AllowEdit = false;
            this.colReminderQuestion.Visible = true;
            this.colReminderQuestion.VisibleIndex = 8;
            // 
            // colAnswer
            // 
            this.colAnswer.FieldName = "Answer";
            this.colAnswer.Name = "colAnswer";
            this.colAnswer.OptionsColumn.AllowEdit = false;
            this.colAnswer.Visible = true;
            this.colAnswer.VisibleIndex = 9;
            // 
            // colIsAdmin
            // 
            this.colIsAdmin.FieldName = "IsAdmin";
            this.colIsAdmin.Name = "colIsAdmin";
            this.colIsAdmin.Visible = true;
            this.colIsAdmin.VisibleIndex = 11;
            // 
            // colUserActions
            // 
            this.colUserActions.FieldName = "UserActions";
            this.colUserActions.Name = "colUserActions";
            // 
            // colTables
            // 
            this.colTables.FieldName = "Tables";
            this.colTables.Name = "colTables";
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 519);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcılar";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnRoles;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colNameSurname;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colAdress;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colRole;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colPassword;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colRegisterDate;
        private DevExpress.XtraGrid.Columns.GridColumn colIsActive;
        private DevExpress.XtraGrid.Columns.GridColumn colReminderQuestion;
        private DevExpress.XtraGrid.Columns.GridColumn colAnswer;
        private DevExpress.XtraGrid.Columns.GridColumn colIsAdmin;
        private DevExpress.XtraGrid.Columns.GridColumn colUserActions;
        private DevExpress.XtraGrid.Columns.GridColumn colTables;
    }
}
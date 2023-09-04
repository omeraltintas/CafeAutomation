namespace Cafeautomation.WinForms.Users
{
    partial class frmUserRoles
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserRoles));
            this.lblTitle = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFormName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colControlName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colControlCaption = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsVisible = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Appearance.Options.UseFont = true;
            this.lblTitle.Location = new System.Drawing.Point(276, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(133, 21);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Kullanıcı Rolleri";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnClose);
            this.groupControl1.Controls.Add(this.btnSave);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 375);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(725, 100);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "İşlemler";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(614, 26);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 62);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Kapat";
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
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(725, 475);
            this.gridControl1.TabIndex = 9;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colUserId,
            this.colFormName,
            this.colControlName,
            this.colControlCaption,
            this.colIsVisible});
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
            // colUserId
            // 
            this.colUserId.FieldName = "UserId";
            this.colUserId.Name = "colUserId";
            this.colUserId.OptionsColumn.AllowEdit = false;
            // 
            // colFormName
            // 
            this.colFormName.FieldName = "FormName";
            this.colFormName.Name = "colFormName";
            this.colFormName.OptionsColumn.AllowEdit = false;
            this.colFormName.Visible = true;
            this.colFormName.VisibleIndex = 1;
            // 
            // colControlName
            // 
            this.colControlName.FieldName = "ControlName";
            this.colControlName.Name = "colControlName";
            this.colControlName.OptionsColumn.AllowEdit = false;
            this.colControlName.Visible = true;
            this.colControlName.VisibleIndex = 2;
            // 
            // colControlCaption
            // 
            this.colControlCaption.FieldName = "ControlCaption";
            this.colControlCaption.Name = "colControlCaption";
            this.colControlCaption.OptionsColumn.AllowEdit = false;
            this.colControlCaption.Visible = true;
            this.colControlCaption.VisibleIndex = 3;
            // 
            // colIsVisible
            // 
            this.colIsVisible.FieldName = "IsVisible";
            this.colIsVisible.Name = "colIsVisible";
            this.colIsVisible.Visible = true;
            this.colIsVisible.VisibleIndex = 4;
            // 
            // frmUserRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 475);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmUserRoles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Rolleri";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblTitle;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colUserId;
        private DevExpress.XtraGrid.Columns.GridColumn colFormName;
        private DevExpress.XtraGrid.Columns.GridColumn colControlName;
        private DevExpress.XtraGrid.Columns.GridColumn colControlCaption;
        private DevExpress.XtraGrid.Columns.GridColumn colIsVisible;
    }
}
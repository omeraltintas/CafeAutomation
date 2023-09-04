namespace Cafeautomation.WinForms.Tables
{
    partial class frmTables
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTables));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnReserved = new DevExpress.XtraEditors.SimpleButton();
            this.btnChangeStatus = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTableName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTableStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsReserved = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastProcessDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProcess = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTableActions = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnTableActions = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnTableActions);
            this.groupControl1.Controls.Add(this.btnReserved);
            this.groupControl1.Controls.Add(this.btnChangeStatus);
            this.groupControl1.Controls.Add(this.btnDelete);
            this.groupControl1.Controls.Add(this.btnRefresh);
            this.groupControl1.Controls.Add(this.btnClose);
            this.groupControl1.Controls.Add(this.btnEdit);
            this.groupControl1.Controls.Add(this.btnNew);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 453);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(945, 100);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "İşlemler";
            // 
            // btnReserved
            // 
            this.btnReserved.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReserved.ImageOptions.Image")));
            this.btnReserved.Location = new System.Drawing.Point(555, 26);
            this.btnReserved.Name = "btnReserved";
            this.btnReserved.Size = new System.Drawing.Size(121, 62);
            this.btnReserved.TabIndex = 0;
            this.btnReserved.Text = "Rezerve Değiştir";
            this.btnReserved.Click += new System.EventHandler(this.btnReserved_Click);
            // 
            // btnChangeStatus
            // 
            this.btnChangeStatus.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeStatus.ImageOptions.Image")));
            this.btnChangeStatus.Location = new System.Drawing.Point(435, 27);
            this.btnChangeStatus.Name = "btnChangeStatus";
            this.btnChangeStatus.Size = new System.Drawing.Size(114, 62);
            this.btnChangeStatus.TabIndex = 0;
            this.btnChangeStatus.Text = "Durum Değiştir";
            this.btnChangeStatus.Click += new System.EventHandler(this.btnChangeStatus_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(330, 26);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 62);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Sil";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(225, 26);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(99, 62);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Yenile";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(834, 26);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 62);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Kapat";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.Image")));
            this.btnEdit.Location = new System.Drawing.Point(116, 26);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(99, 62);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Düzenle";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            this.gridControl1.Size = new System.Drawing.Size(945, 453);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colTableName,
            this.colTableStatus,
            this.colIsReserved,
            this.colDescription,
            this.colAddedDate,
            this.colLastProcessDate,
            this.colProcess,
            this.colUserId,
            this.colTableActions});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colTableName
            // 
            this.colTableName.FieldName = "TableName";
            this.colTableName.Name = "colTableName";
            this.colTableName.Visible = true;
            this.colTableName.VisibleIndex = 1;
            // 
            // colTableStatus
            // 
            this.colTableStatus.FieldName = "TableStatus";
            this.colTableStatus.Name = "colTableStatus";
            this.colTableStatus.Visible = true;
            this.colTableStatus.VisibleIndex = 2;
            // 
            // colIsReserved
            // 
            this.colIsReserved.FieldName = "IsReserved";
            this.colIsReserved.Name = "colIsReserved";
            this.colIsReserved.Visible = true;
            this.colIsReserved.VisibleIndex = 3;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 4;
            // 
            // colAddedDate
            // 
            this.colAddedDate.FieldName = "AddedDate";
            this.colAddedDate.Name = "colAddedDate";
            this.colAddedDate.Visible = true;
            this.colAddedDate.VisibleIndex = 5;
            // 
            // colLastProcessDate
            // 
            this.colLastProcessDate.FieldName = "LastProcessDate";
            this.colLastProcessDate.Name = "colLastProcessDate";
            this.colLastProcessDate.Visible = true;
            this.colLastProcessDate.VisibleIndex = 6;
            // 
            // colProcess
            // 
            this.colProcess.FieldName = "Process";
            this.colProcess.Name = "colProcess";
            this.colProcess.Visible = true;
            this.colProcess.VisibleIndex = 7;
            // 
            // colUserId
            // 
            this.colUserId.Caption = "Kullanıcı";
            this.colUserId.FieldName = "User";
            this.colUserId.Name = "colUserId";
            this.colUserId.Visible = true;
            this.colUserId.VisibleIndex = 8;
            // 
            // colTableActions
            // 
            this.colTableActions.FieldName = "TableActions";
            this.colTableActions.Name = "colTableActions";
            // 
            // btnTableActions
            // 
            this.btnTableActions.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnTableActions.Location = new System.Drawing.Point(682, 27);
            this.btnTableActions.Name = "btnTableActions";
            this.btnTableActions.Size = new System.Drawing.Size(121, 62);
            this.btnTableActions.TabIndex = 0;
            this.btnTableActions.Text = "Masa Hareketleri";
            this.btnTableActions.Click += new System.EventHandler(this.btnTableActionsClick);
            // 
            // frmTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 553);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmTables";
            this.Text = "Masalar";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colTableName;
        private DevExpress.XtraGrid.Columns.GridColumn colTableStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colIsReserved;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colAddedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colLastProcessDate;
        private DevExpress.XtraGrid.Columns.GridColumn colProcess;
        private DevExpress.XtraGrid.Columns.GridColumn colUserId;
        private DevExpress.XtraGrid.Columns.GridColumn colTableActions;
        private DevExpress.XtraEditors.SimpleButton btnReserved;
        private DevExpress.XtraEditors.SimpleButton btnChangeStatus;
        private DevExpress.XtraEditors.SimpleButton btnTableActions;
    }
}
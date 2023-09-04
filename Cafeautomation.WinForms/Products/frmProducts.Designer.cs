namespace Cafeautomation.WinForms.Products
{
    partial class frmProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducts));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnTableActions = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMenuId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitPrice2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMenu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMenuName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuickSale = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(251, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Ürünler";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnKaydet);
            this.groupControl1.Controls.Add(this.btnTableActions);
            this.groupControl1.Controls.Add(this.btnDelete);
            this.groupControl1.Controls.Add(this.btnRefresh);
            this.groupControl1.Controls.Add(this.btnClose);
            this.groupControl1.Controls.Add(this.btnEdit);
            this.groupControl1.Controls.Add(this.btnNew);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 382);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(818, 100);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "İşlemler";
            // 
            // btnTableActions
            // 
            this.btnTableActions.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTableActions.ImageOptions.Image")));
            this.btnTableActions.Location = new System.Drawing.Point(435, 26);
            this.btnTableActions.Name = "btnTableActions";
            this.btnTableActions.Size = new System.Drawing.Size(127, 62);
            this.btnTableActions.TabIndex = 4;
            this.btnTableActions.Text = "Masa Hareketleri";
            this.btnTableActions.Click += new System.EventHandler(this.btnTableActions_Click);
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
            this.btnClose.Location = new System.Drawing.Point(707, 26);
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
            this.gridControl1.Size = new System.Drawing.Size(818, 382);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colMenuId,
            this.colProductCode,
            this.colProductName,
            this.colUnitPrice,
            this.colUnitPrice2,
            this.colDescription,
            this.colDate,
            this.colImage,
            this.colMenu,
            this.colMenuName,
            this.colQuickSale});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 68;
            // 
            // colMenuId
            // 
            this.colMenuId.FieldName = "MenuId";
            this.colMenuId.Name = "colMenuId";
            // 
            // colProductCode
            // 
            this.colProductCode.FieldName = "ProductCode";
            this.colProductCode.Name = "colProductCode";
            this.colProductCode.Visible = true;
            this.colProductCode.VisibleIndex = 1;
            this.colProductCode.Width = 73;
            // 
            // colProductName
            // 
            this.colProductName.FieldName = "ProductName";
            this.colProductName.Name = "colProductName";
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 3;
            this.colProductName.Width = 102;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.FieldName = "UnitPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.Visible = true;
            this.colUnitPrice.VisibleIndex = 4;
            this.colUnitPrice.Width = 102;
            // 
            // colUnitPrice2
            // 
            this.colUnitPrice2.FieldName = "UnitPrice2";
            this.colUnitPrice2.Name = "colUnitPrice2";
            this.colUnitPrice2.Visible = true;
            this.colUnitPrice2.VisibleIndex = 5;
            this.colUnitPrice2.Width = 102;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 6;
            this.colDescription.Width = 102;
            // 
            // colDate
            // 
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 7;
            this.colDate.Width = 110;
            // 
            // colImage
            // 
            this.colImage.FieldName = "Image";
            this.colImage.Name = "colImage";
            // 
            // colMenu
            // 
            this.colMenu.FieldName = "Menu";
            this.colMenu.Name = "colMenu";
            // 
            // colMenuName
            // 
            this.colMenuName.Caption = "Menü Adı";
            this.colMenuName.FieldName = "Menu.MenuName";
            this.colMenuName.Name = "colMenuName";
            this.colMenuName.Visible = true;
            this.colMenuName.VisibleIndex = 2;
            // 
            // colQuickSale
            // 
            this.colQuickSale.Caption = "Hızlı Satış";
            this.colQuickSale.FieldName = "QuickSale";
            this.colQuickSale.Name = "colQuickSale";
            this.colQuickSale.Visible = true;
            this.colQuickSale.VisibleIndex = 8;
            // 
            // btnKaydet
            // 
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(568, 26);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(127, 62);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 482);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmProducts";
            this.Text = "Ürünler";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colMenuId;
        private DevExpress.XtraGrid.Columns.GridColumn colProductCode;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice2;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colImage;
        private DevExpress.XtraGrid.Columns.GridColumn colMenu;
        private DevExpress.XtraGrid.Columns.GridColumn colMenuName;
        private DevExpress.XtraEditors.SimpleButton btnTableActions;
        private DevExpress.XtraGrid.Columns.GridColumn colQuickSale;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
    }
}
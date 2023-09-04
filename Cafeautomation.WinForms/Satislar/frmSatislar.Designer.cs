namespace Cafeautomation.WinForms.Sales
{
    partial class frmSatislar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSatislar));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnPaymentActions = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnOrderDetails = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaleCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscountTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemainder = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastProcessDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPackageDelivery = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnExport = new DevExpress.XtraEditors.DropDownButton();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnExcelExport = new DevExpress.XtraBars.BarButtonItem();
            this.btnWord = new DevExpress.XtraBars.BarButtonItem();
            this.btnPdf = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(241, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 23);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Satışlar";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnExport);
            this.groupControl1.Controls.Add(this.btnClose);
            this.groupControl1.Controls.Add(this.btnPaymentActions);
            this.groupControl1.Controls.Add(this.btnRefresh);
            this.groupControl1.Controls.Add(this.btnOrderDetails);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 293);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(659, 100);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "İşlemler";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(548, 26);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 62);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Kapat";
            // 
            // btnPaymentActions
            // 
            this.btnPaymentActions.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPaymentActions.ImageOptions.SvgImage")));
            this.btnPaymentActions.Location = new System.Drawing.Point(241, 26);
            this.btnPaymentActions.Name = "btnPaymentActions";
            this.btnPaymentActions.Size = new System.Drawing.Size(134, 62);
            this.btnPaymentActions.TabIndex = 0;
            this.btnPaymentActions.Text = "Ödeme Hareketleri";
            this.btnPaymentActions.Click += new System.EventHandler(this.btnPaymentActions_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(127, 26);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(99, 62);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Yenile";
            // 
            // btnOrderDetails
            // 
            this.btnOrderDetails.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOrderDetails.ImageOptions.Image")));
            this.btnOrderDetails.Location = new System.Drawing.Point(5, 26);
            this.btnOrderDetails.Name = "btnOrderDetails";
            this.btnOrderDetails.Size = new System.Drawing.Size(116, 62);
            this.btnOrderDetails.TabIndex = 0;
            this.btnOrderDetails.Text = "Sipariş Detayları";
            this.btnOrderDetails.Click += new System.EventHandler(this.btnOrderDetails_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(659, 393);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colCustomerName,
            this.colSaleCode,
            this.colCustomerId,
            this.colPrice,
            this.colDiscountTotal,
            this.colPaid,
            this.colRemainder,
            this.colDescription,
            this.colLastProcessDate,
            this.colPackageDelivery});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 56;
            // 
            // colCustomerName
            // 
            this.colCustomerName.Caption = "Ad Soyad";
            this.colCustomerName.FieldName = "Customers.NameSurname";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 1;
            this.colCustomerName.Width = 71;
            // 
            // colSaleCode
            // 
            this.colSaleCode.FieldName = "SaleCode";
            this.colSaleCode.Name = "colSaleCode";
            this.colSaleCode.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "SaleCode", "Kayıt:{0}")});
            this.colSaleCode.Visible = true;
            this.colSaleCode.VisibleIndex = 2;
            this.colSaleCode.Width = 71;
            // 
            // colCustomerId
            // 
            this.colCustomerId.FieldName = "CustomerId";
            this.colCustomerId.Name = "colCustomerId";
            // 
            // colPrice
            // 
            this.colPrice.DisplayFormat.FormatString = "C2";
            this.colPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Price", "Tutar={0:C2}")});
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 3;
            this.colPrice.Width = 71;
            // 
            // colDiscountTotal
            // 
            this.colDiscountTotal.DisplayFormat.FormatString = "C2";
            this.colDiscountTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDiscountTotal.FieldName = "DiscountTotal";
            this.colDiscountTotal.Name = "colDiscountTotal";
            this.colDiscountTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DiscountTotal", "İ.Toplam={0:C2}")});
            this.colDiscountTotal.Visible = true;
            this.colDiscountTotal.VisibleIndex = 4;
            this.colDiscountTotal.Width = 71;
            // 
            // colPaid
            // 
            this.colPaid.DisplayFormat.FormatString = "C2";
            this.colPaid.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPaid.FieldName = "Paid";
            this.colPaid.Name = "colPaid";
            this.colPaid.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Paid", "{0:C2}")});
            this.colPaid.Visible = true;
            this.colPaid.VisibleIndex = 5;
            this.colPaid.Width = 71;
            // 
            // colRemainder
            // 
            this.colRemainder.DisplayFormat.FormatString = "C2";
            this.colRemainder.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRemainder.FieldName = "Remainder";
            this.colRemainder.Name = "colRemainder";
            this.colRemainder.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Remainder", "{0:C2}")});
            this.colRemainder.Visible = true;
            this.colRemainder.VisibleIndex = 6;
            this.colRemainder.Width = 71;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 7;
            this.colDescription.Width = 71;
            // 
            // colLastProcessDate
            // 
            this.colLastProcessDate.FieldName = "LastProcessDate";
            this.colLastProcessDate.Name = "colLastProcessDate";
            this.colLastProcessDate.Visible = true;
            this.colLastProcessDate.VisibleIndex = 8;
            this.colLastProcessDate.Width = 81;
            // 
            // colPackageDelivery
            // 
            this.colPackageDelivery.Caption = "Paket Sipariş Mi";
            this.colPackageDelivery.FieldName = "IsPackageDelivery";
            this.colPackageDelivery.Name = "colPackageDelivery";
            this.colPackageDelivery.Visible = true;
            this.colPackageDelivery.VisibleIndex = 9;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.DropDownControl = this.popupMenu1;
            this.btnExport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.ImageOptions.Image")));
            this.btnExport.Location = new System.Drawing.Point(393, 26);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(135, 62);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "Export";
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExcelExport),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnWord),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPdf)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnExcelExport,
            this.btnWord,
            this.btnPdf});
            this.barManager1.MaxItemId = 3;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(659, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 393);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(659, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 393);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(659, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 393);
            // 
            // btnExcelExport
            // 
            this.btnExcelExport.Caption = "Excel Dosyaları";
            this.btnExcelExport.Id = 0;
            this.btnExcelExport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExcelExport.ImageOptions.Image")));
            this.btnExcelExport.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnExcelExport.ImageOptions.LargeImage")));
            this.btnExcelExport.Name = "btnExcelExport";
            this.btnExcelExport.Tag = "Excel Dosyaları|*.xlsx";
            this.btnExcelExport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Export_ItemClick);
            // 
            // btnWord
            // 
            this.btnWord.Caption = "Word Dosyaları";
            this.btnWord.Id = 1;
            this.btnWord.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnWord.ImageOptions.Image")));
            this.btnWord.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnWord.ImageOptions.LargeImage")));
            this.btnWord.Name = "btnWord";
            this.btnWord.Tag = "Word Dosyaları|*.docx";
            this.btnWord.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Export_ItemClick);
            // 
            // btnPdf
            // 
            this.btnPdf.Caption = "Pdf Dosyaları";
            this.btnPdf.Id = 2;
            this.btnPdf.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPdf.ImageOptions.Image")));
            this.btnPdf.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPdf.ImageOptions.LargeImage")));
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Tag = "Pdf Dosyaları|*.pdf";
            this.btnPdf.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Export_ItemClick);
            // 
            // frmSatislar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 393);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmSatislar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satışlar";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnPaymentActions;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnOrderDetails;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colSaleCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerId;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscountTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colPaid;
        private DevExpress.XtraGrid.Columns.GridColumn colRemainder;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colLastProcessDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPackageDelivery;
        private DevExpress.XtraEditors.DropDownButton btnExport;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem btnExcelExport;
        private DevExpress.XtraBars.BarButtonItem btnWord;
        private DevExpress.XtraBars.BarButtonItem btnPdf;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}
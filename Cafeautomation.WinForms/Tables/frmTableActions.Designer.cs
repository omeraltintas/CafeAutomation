namespace Cafeautomation.WinForms.Tables
{
    partial class frmTableActions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTableActions));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnOrderDetails = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTableId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMenuName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTableName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaleCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscountPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnClose);
            this.groupControl1.Controls.Add(this.btnOrderDetails);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 441);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(905, 100);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "İşlemler";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(794, 26);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 62);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Kapat";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOrderDetails
            // 
            this.btnOrderDetails.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOrderDetails.ImageOptions.Image")));
            this.btnOrderDetails.Location = new System.Drawing.Point(5, 26);
            this.btnOrderDetails.Name = "btnOrderDetails";
            this.btnOrderDetails.Size = new System.Drawing.Size(116, 62);
            this.btnOrderDetails.TabIndex = 0;
            this.btnOrderDetails.Text = "Sipariş Detayları";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(905, 441);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colTableId,
            this.colProductId,
            this.colProductName,
            this.colMenuName,
            this.colTableName,
            this.colSaleCode,
            this.colAmount,
            this.colUnitPrice,
            this.colDiscountPrice,
            this.colDescription,
            this.colDate,
            this.colTable,
            this.colProduct});
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
            this.colId.Width = 61;
            // 
            // colTableId
            // 
            this.colTableId.FieldName = "TableId";
            this.colTableId.Name = "colTableId";
            // 
            // colProductId
            // 
            this.colProductId.FieldName = "ProductId";
            this.colProductId.Name = "colProductId";
            // 
            // colProductName
            // 
            this.colProductName.Caption = "Ürün Adı";
            this.colProductName.FieldName = "Product.ProductName";
            this.colProductName.Name = "colProductName";
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 3;
            // 
            // colMenuName
            // 
            this.colMenuName.Caption = "Menü Adı";
            this.colMenuName.FieldName = "Product.Menu.MenuName";
            this.colMenuName.Name = "colMenuName";
            this.colMenuName.Visible = true;
            this.colMenuName.VisibleIndex = 4;
            this.colMenuName.Width = 74;
            // 
            // colTableName
            // 
            this.colTableName.Caption = "Masa Adı";
            this.colTableName.FieldName = "Table.TableName";
            this.colTableName.Name = "colTableName";
            this.colTableName.Visible = true;
            this.colTableName.VisibleIndex = 5;
            // 
            // colSaleCode
            // 
            this.colSaleCode.FieldName = "SaleCode";
            this.colSaleCode.Name = "colSaleCode";
            this.colSaleCode.Visible = true;
            this.colSaleCode.VisibleIndex = 1;
            // 
            // colAmount
            // 
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Amount", "SUM={0:0.##}")});
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 2;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.DisplayFormat.FormatString = "C2";
            this.colUnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colUnitPrice.FieldName = "UnitPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.Visible = true;
            this.colUnitPrice.VisibleIndex = 6;
            // 
            // colDiscountPrice
            // 
            this.colDiscountPrice.DisplayFormat.FormatString = "C2";
            this.colDiscountPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDiscountPrice.FieldName = "DiscountPrice";
            this.colDiscountPrice.Name = "colDiscountPrice";
            this.colDiscountPrice.Visible = true;
            this.colDiscountPrice.VisibleIndex = 7;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 8;
            // 
            // colDate
            // 
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 9;
            // 
            // colTable
            // 
            this.colTable.FieldName = "Table";
            this.colTable.Name = "colTable";
            this.colTable.Visible = true;
            this.colTable.VisibleIndex = 10;
            // 
            // colProduct
            // 
            this.colProduct.FieldName = "Product";
            this.colProduct.Name = "colProduct";
            this.colProduct.Visible = true;
            this.colProduct.VisibleIndex = 11;
            // 
            // frmTableActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 541);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmTableActions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Masa Hareketleri";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnOrderDetails;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colTableId;
        private DevExpress.XtraGrid.Columns.GridColumn colProductId;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colMenuName;
        private DevExpress.XtraGrid.Columns.GridColumn colTableName;
        private DevExpress.XtraGrid.Columns.GridColumn colSaleCode;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscountPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colTable;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct;
    }
}
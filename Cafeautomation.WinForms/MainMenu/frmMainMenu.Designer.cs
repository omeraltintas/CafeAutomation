namespace Cafeautomation.WinForms.MainMenu
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnTables = new DevExpress.XtraBars.BarButtonItem();
            this.btnTableActions = new DevExpress.XtraBars.BarButtonItem();
            this.btnMenus = new DevExpress.XtraBars.BarButtonItem();
            this.btnMenuActions = new DevExpress.XtraBars.BarButtonItem();
            this.btnProducts = new DevExpress.XtraBars.BarButtonItem();
            this.btnProductActions = new DevExpress.XtraBars.BarButtonItem();
            this.btnUsers = new DevExpress.XtraBars.BarButtonItem();
            this.btnUserActions = new DevExpress.XtraBars.BarButtonItem();
            this.btnMyInfo = new DevExpress.XtraBars.BarButtonItem();
            this.btnCurrency = new DevExpress.XtraBars.BarButtonItem();
            this.btnHelp = new DevExpress.XtraBars.BarButtonItem();
            this.btnAboutUs = new DevExpress.XtraBars.BarButtonItem();
            this.btnOrder = new DevExpress.XtraBars.BarButtonItem();
            this.btnCustomers = new DevExpress.XtraBars.BarButtonItem();
            this.btnSales = new DevExpress.XtraBars.BarButtonItem();
            this.btnPayActions = new DevExpress.XtraBars.BarButtonItem();
            this.btnPackageOrder = new DevExpress.XtraBars.BarButtonItem();
            this.btnTableActionsReport = new DevExpress.XtraBars.BarButtonItem();
            this.btnSpecialReport = new DevExpress.XtraBars.BarButtonItem();
            this.btnDashboard = new DevExpress.XtraBars.BarButtonItem();
            this.btnSettings = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.btnGraphic = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnTables,
            this.btnTableActions,
            this.btnMenus,
            this.btnMenuActions,
            this.btnProducts,
            this.btnProductActions,
            this.btnUsers,
            this.btnUserActions,
            this.btnMyInfo,
            this.btnCurrency,
            this.btnHelp,
            this.btnAboutUs,
            this.btnOrder,
            this.btnCustomers,
            this.btnSales,
            this.btnPayActions,
            this.btnPackageOrder,
            this.btnTableActionsReport,
            this.btnSpecialReport,
            this.btnDashboard,
            this.btnSettings,
            this.btnGraphic});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 23;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage2,
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1275, 158);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnTables
            // 
            this.btnTables.Caption = "Masalar";
            this.btnTables.Id = 1;
            this.btnTables.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTables.ImageOptions.Image")));
            this.btnTables.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTables.ImageOptions.LargeImage")));
            this.btnTables.Name = "btnTables";
            this.btnTables.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTables_ItemClick);
            // 
            // btnTableActions
            // 
            this.btnTableActions.Caption = "Masa Hareketleri";
            this.btnTableActions.Id = 2;
            this.btnTableActions.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTableActions.ImageOptions.Image")));
            this.btnTableActions.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTableActions.ImageOptions.LargeImage")));
            this.btnTableActions.Name = "btnTableActions";
            this.btnTableActions.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTableActions_ItemClick);
            // 
            // btnMenus
            // 
            this.btnMenus.Caption = "Menüler";
            this.btnMenus.Id = 3;
            this.btnMenus.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMenus.ImageOptions.Image")));
            this.btnMenus.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMenus.ImageOptions.LargeImage")));
            this.btnMenus.Name = "btnMenus";
            this.btnMenus.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMenus_ItemClick);
            // 
            // btnMenuActions
            // 
            this.btnMenuActions.Caption = "Menü Hareketleri";
            this.btnMenuActions.Id = 4;
            this.btnMenuActions.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuActions.ImageOptions.Image")));
            this.btnMenuActions.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMenuActions.ImageOptions.LargeImage")));
            this.btnMenuActions.Name = "btnMenuActions";
            // 
            // btnProducts
            // 
            this.btnProducts.Caption = "Ürünler";
            this.btnProducts.Id = 5;
            this.btnProducts.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnProducts.ImageOptions.Image")));
            this.btnProducts.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnProducts.ImageOptions.LargeImage")));
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProducts_ItemClick);
            // 
            // btnProductActions
            // 
            this.btnProductActions.Caption = "Ürün Hareketleri";
            this.btnProductActions.Id = 6;
            this.btnProductActions.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnProductActions.ImageOptions.Image")));
            this.btnProductActions.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnProductActions.ImageOptions.LargeImage")));
            this.btnProductActions.Name = "btnProductActions";
            // 
            // btnUsers
            // 
            this.btnUsers.Caption = "Kullanıcılar";
            this.btnUsers.Id = 7;
            this.btnUsers.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUsers.ImageOptions.Image")));
            this.btnUsers.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUsers.ImageOptions.LargeImage")));
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUsers_ItemClick);
            // 
            // btnUserActions
            // 
            this.btnUserActions.Caption = "Kullanıcı Hareketleri";
            this.btnUserActions.Id = 8;
            this.btnUserActions.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUserActions.ImageOptions.Image")));
            this.btnUserActions.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUserActions.ImageOptions.LargeImage")));
            this.btnUserActions.Name = "btnUserActions";
            // 
            // btnMyInfo
            // 
            this.btnMyInfo.Caption = "Bilgilerim";
            this.btnMyInfo.Id = 9;
            this.btnMyInfo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMyInfo.ImageOptions.Image")));
            this.btnMyInfo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMyInfo.ImageOptions.LargeImage")));
            this.btnMyInfo.Name = "btnMyInfo";
            this.btnMyInfo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMyInfo_ItemClick);
            // 
            // btnCurrency
            // 
            this.btnCurrency.Caption = "Döviz";
            this.btnCurrency.Id = 10;
            this.btnCurrency.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCurrency.ImageOptions.Image")));
            this.btnCurrency.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCurrency.ImageOptions.LargeImage")));
            this.btnCurrency.Name = "btnCurrency";
            // 
            // btnHelp
            // 
            this.btnHelp.Caption = "Yardım";
            this.btnHelp.Id = 11;
            this.btnHelp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.ImageOptions.Image")));
            this.btnHelp.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHelp.ImageOptions.LargeImage")));
            this.btnHelp.Name = "btnHelp";
            // 
            // btnAboutUs
            // 
            this.btnAboutUs.Caption = "Hakkımızda";
            this.btnAboutUs.Id = 12;
            this.btnAboutUs.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAboutUs.ImageOptions.Image")));
            this.btnAboutUs.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAboutUs.ImageOptions.LargeImage")));
            this.btnAboutUs.Name = "btnAboutUs";
            // 
            // btnOrder
            // 
            this.btnOrder.Caption = "Masa Sipariş";
            this.btnOrder.Id = 13;
            this.btnOrder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOrder.ImageOptions.Image")));
            this.btnOrder.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnOrder.ImageOptions.LargeImage")));
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnOrder_ItemClick);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Caption = "Müşteriler";
            this.btnCustomers.Id = 14;
            this.btnCustomers.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomers.ImageOptions.Image")));
            this.btnCustomers.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCustomers.ImageOptions.LargeImage")));
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCustomers_ItemClick);
            // 
            // btnSales
            // 
            this.btnSales.Caption = "Satışlar";
            this.btnSales.Id = 15;
            this.btnSales.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSales.ImageOptions.Image")));
            this.btnSales.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSales.ImageOptions.LargeImage")));
            this.btnSales.Name = "btnSales";
            this.btnSales.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSales_ItemClick);
            // 
            // btnPayActions
            // 
            this.btnPayActions.Caption = "Ödeme Hareketleri";
            this.btnPayActions.Id = 16;
            this.btnPayActions.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPayActions.ImageOptions.Image")));
            this.btnPayActions.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPayActions.ImageOptions.LargeImage")));
            this.btnPayActions.Name = "btnPayActions";
            this.btnPayActions.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPayActions_ItemClick);
            // 
            // btnPackageOrder
            // 
            this.btnPackageOrder.Caption = "Paket Sipariş";
            this.btnPackageOrder.Id = 17;
            this.btnPackageOrder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPackageOrder.ImageOptions.Image")));
            this.btnPackageOrder.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPackageOrder.ImageOptions.LargeImage")));
            this.btnPackageOrder.Name = "btnPackageOrder";
            this.btnPackageOrder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPackageOrder_ItemClick);
            // 
            // btnTableActionsReport
            // 
            this.btnTableActionsReport.Caption = "Masa Hareketleri Raporu";
            this.btnTableActionsReport.Id = 18;
            this.btnTableActionsReport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTableActionsReport.ImageOptions.Image")));
            this.btnTableActionsReport.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTableActionsReport.ImageOptions.LargeImage")));
            this.btnTableActionsReport.Name = "btnTableActionsReport";
            this.btnTableActionsReport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTableActionsReport_ItemClick);
            // 
            // btnSpecialReport
            // 
            this.btnSpecialReport.Caption = "Özel Rapor";
            this.btnSpecialReport.Id = 19;
            this.btnSpecialReport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSpecialReport.ImageOptions.Image")));
            this.btnSpecialReport.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSpecialReport.ImageOptions.LargeImage")));
            this.btnSpecialReport.Name = "btnSpecialReport";
            this.btnSpecialReport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSpecialReport_ItemClick);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Caption = "Dashboard";
            this.btnDashboard.Id = 20;
            this.btnDashboard.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.ImageOptions.Image")));
            this.btnDashboard.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDashboard.ImageOptions.LargeImage")));
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDashboard_ItemClick);
            // 
            // btnSettings
            // 
            this.btnSettings.Caption = "Ayarlar";
            this.btnSettings.Id = 21;
            this.btnSettings.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.ImageOptions.Image")));
            this.btnSettings.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSettings.ImageOptions.LargeImage")));
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSettings_ItemClick);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5,
            this.ribbonPageGroup6,
            this.ribbonPageGroup7,
            this.ribbonPageGroup8,
            this.ribbonPageGroup9});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Cafe İşlemleri";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageGroup2.ImageOptions.Image")));
            this.ribbonPageGroup2.ItemLinks.Add(this.btnTables);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnTableActions);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnOrder);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Masalar";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnMenus);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnMenuActions);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Menuler";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnProducts);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnProductActions);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Ürünler";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnUsers);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnUserActions);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnMyInfo);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Kullanıcılar";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnCustomers);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Müşteriler";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.btnSales);
            this.ribbonPageGroup7.ItemLinks.Add(this.btnPayActions);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "Satışlar";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.btnPackageOrder);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            this.ribbonPageGroup8.Text = "Paket Sipariş";
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.ItemLinks.Add(this.btnTableActionsReport);
            this.ribbonPageGroup9.ItemLinks.Add(this.btnSpecialReport);
            this.ribbonPageGroup9.ItemLinks.Add(this.btnDashboard);
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            this.ribbonPageGroup9.Text = "Raporlar";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Ayarlar";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCurrency);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnHelp);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAboutUs);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSettings);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnGraphic);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Ayarlar";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 571);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1275, 24);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // btnGraphic
            // 
            this.btnGraphic.Caption = "Grafik";
            this.btnGraphic.Id = 22;
            this.btnGraphic.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.btnGraphic.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.btnGraphic.Name = "btnGraphic";
            this.btnGraphic.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGraphic_ItemClick);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 595);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "frmMainMenu";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Cafe Otomasyonu";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnTables;
        private DevExpress.XtraBars.BarButtonItem btnTableActions;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnMenus;
        private DevExpress.XtraBars.BarButtonItem btnMenuActions;
        private DevExpress.XtraBars.BarButtonItem btnProducts;
        private DevExpress.XtraBars.BarButtonItem btnProductActions;
        private DevExpress.XtraBars.BarButtonItem btnUsers;
        private DevExpress.XtraBars.BarButtonItem btnUserActions;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btnMyInfo;
        private DevExpress.XtraBars.BarButtonItem btnCurrency;
        private DevExpress.XtraBars.BarButtonItem btnHelp;
        private DevExpress.XtraBars.BarButtonItem btnAboutUs;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnOrder;
        private DevExpress.XtraBars.BarButtonItem btnCustomers;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem btnSales;
        private DevExpress.XtraBars.BarButtonItem btnPayActions;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.BarButtonItem btnPackageOrder;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.BarButtonItem btnTableActionsReport;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.BarButtonItem btnSpecialReport;
        private DevExpress.XtraBars.BarButtonItem btnDashboard;
        public DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.BarButtonItem btnSettings;
        private DevExpress.XtraBars.BarButtonItem btnGraphic;
    }
}
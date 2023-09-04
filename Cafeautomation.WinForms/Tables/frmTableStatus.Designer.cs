namespace Cafeautomation.WinForms.Tables
{
    partial class frmTableStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTableStatus));
            this.groupProcesses = new DevExpress.XtraEditors.GroupControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.btnReserved = new DevExpress.XtraEditors.SimpleButton();
            this.btnOpenTable = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddOrder = new DevExpress.XtraEditors.SimpleButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.groupProcesses)).BeginInit();
            this.groupProcesses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupProcesses
            // 
            this.groupProcesses.Controls.Add(this.groupControl1);
            this.groupProcesses.Controls.Add(this.btnClose);
            this.groupProcesses.Controls.Add(this.btnSave);
            this.groupProcesses.Controls.Add(this.simpleButton1);
            this.groupProcesses.Controls.Add(this.btnAddOrder);
            this.groupProcesses.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupProcesses.Location = new System.Drawing.Point(0, 378);
            this.groupProcesses.Name = "groupProcesses";
            this.groupProcesses.Size = new System.Drawing.Size(812, 100);
            this.groupProcesses.TabIndex = 8;
            this.groupProcesses.Text = "İşlemler";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButton5);
            this.groupControl1.Controls.Add(this.btnReserved);
            this.groupControl1.Controls.Add(this.btnOpenTable);
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Controls.Add(this.btnRefresh);
            this.groupControl1.Controls.Add(this.simpleButton4);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(2, -2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(808, 100);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "İşlemler";
            // 
            // simpleButton5
            // 
            this.simpleButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton5.ImageOptions.Image")));
            this.simpleButton5.Location = new System.Drawing.Point(697, 26);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(99, 62);
            this.simpleButton5.TabIndex = 0;
            this.simpleButton5.Text = "Kapat";
            // 
            // btnReserved
            // 
            this.btnReserved.Enabled = false;
            this.btnReserved.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReserved.ImageOptions.Image")));
            this.btnReserved.Location = new System.Drawing.Point(228, 28);
            this.btnReserved.Name = "btnReserved";
            this.btnReserved.Size = new System.Drawing.Size(99, 62);
            this.btnReserved.TabIndex = 0;
            this.btnReserved.Text = "Rezerve";
            this.btnReserved.Click += new System.EventHandler(this.btnReserved_Click);
            // 
            // btnOpenTable
            // 
            this.btnOpenTable.Enabled = false;
            this.btnOpenTable.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenTable.ImageOptions.Image")));
            this.btnOpenTable.Location = new System.Drawing.Point(110, 26);
            this.btnOpenTable.Name = "btnOpenTable";
            this.btnOpenTable.Size = new System.Drawing.Size(99, 62);
            this.btnOpenTable.TabIndex = 0;
            this.btnOpenTable.Text = "Masa Aç";
            this.btnOpenTable.Click += new System.EventHandler(this.btnOpenTable_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(697, 26);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(99, 62);
            this.simpleButton2.TabIndex = 0;
            this.simpleButton2.Text = "Kapat";
            // 
            // btnRefresh
            // 
            this.btnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(348, 28);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(99, 62);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Yenile";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Enabled = false;
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(0, 26);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(99, 62);
            this.simpleButton4.TabIndex = 0;
            this.simpleButton4.Text = "Sipariş Ekle";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(701, 26);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 62);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Kapat";
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(523, 26);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 62);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Kaydet";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(110, 26);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(99, 62);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Sipariş Ekle";
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddOrder.ImageOptions.Image")));
            this.btnAddOrder.Location = new System.Drawing.Point(5, 26);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(99, 62);
            this.btnAddOrder.TabIndex = 0;
            this.btnAddOrder.Text = "Sipariş Ekle";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(812, 378);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // frmTableStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 478);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupProcesses);
            this.Name = "frmTableStatus";
            this.Text = "Masa Durumları";
            this.Load += new System.EventHandler(this.frmTableStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupProcesses)).EndInit();
            this.groupProcesses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupProcesses;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnAddOrder;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton btnReserved;
        private DevExpress.XtraEditors.SimpleButton btnOpenTable;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
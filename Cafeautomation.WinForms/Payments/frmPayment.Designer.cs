namespace Cafeautomation.WinForms.Payments
{
    partial class frmPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayment));
            this.lblCaption = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnAccept = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.calcTotal = new DevExpress.XtraEditors.CalcEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calcTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCaption
            // 
            this.lblCaption.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lblCaption.Appearance.Options.UseFont = true;
            this.lblCaption.Location = new System.Drawing.Point(191, 12);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(64, 24);
            this.lblCaption.TabIndex = 0;
            this.lblCaption.Text = "Ödeme";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnClose);
            this.groupControl1.Controls.Add(this.btnAccept);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 245);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(479, 100);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "İşlemler";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(368, 26);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 62);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Kapat";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAccept.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAccept.ImageOptions.Image")));
            this.btnAccept.Location = new System.Drawing.Point(248, 26);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(99, 62);
            this.btnAccept.TabIndex = 0;
            this.btnAccept.Text = "Onay";
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Options.UseTextOptions = true;
            this.labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl5.Location = new System.Drawing.Point(12, 62);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(82, 13);
            this.labelControl5.TabIndex = 2;
            this.labelControl5.Text = "Tutar";
            // 
            // calcTotal
            // 
            this.calcTotal.Location = new System.Drawing.Point(100, 58);
            this.calcTotal.Name = "calcTotal";
            this.calcTotal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.calcTotal.Properties.Appearance.Options.UseFont = true;
            this.calcTotal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcTotal.Properties.MaskSettings.Set("mask", "c");
            this.calcTotal.Properties.NullText = "0,00";
            this.calcTotal.Properties.UseMaskAsDisplayFormat = true;
            this.calcTotal.Size = new System.Drawing.Size(114, 22);
            this.calcTotal.TabIndex = 3;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(53, 114);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(41, 13);
            this.labelControl9.TabIndex = 4;
            this.labelControl9.Text = "Açıklama";
            // 
            // memoEdit1
            // 
            this.memoEdit1.Location = new System.Drawing.Point(100, 86);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Size = new System.Drawing.Size(114, 70);
            this.memoEdit1.TabIndex = 5;
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(100, 192);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(106, 20);
            this.dateEdit1.TabIndex = 7;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(70, 195);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(24, 13);
            this.labelControl8.TabIndex = 6;
            this.labelControl8.Text = "Tarih";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(249, 58);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(49, 23);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 345);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.dateEdit1);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.memoEdit1);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.calcTotal);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.lblCaption);
            this.Name = "frmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödeme";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.calcTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblCaption;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnAccept;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.CalcEdit calcTotal;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}
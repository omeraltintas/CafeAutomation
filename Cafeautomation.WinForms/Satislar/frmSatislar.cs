using Cafeautomation.WinForms.Payments;
using Cafeautomation.WinForms.Tables;
using CafeAutomation.Entities.DAL;
using CafeAutomation.Entities.Models;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafeautomation.WinForms.Sales
{
    public partial class frmSatislar : DevExpress.XtraEditors.XtraForm
    {
        CafeContext context=new CafeContext();
        SalesDal salesDal= new SalesDal();

        public frmSatislar()
        {
            InitializeComponent();
            gridControl1.DataSource = salesDal.GetAll(context);
        }

        private void btnOrderDetails_Click(object sender, EventArgs e)
        {
            string saleCode = gridView1.GetFocusedRowCellValue(colSaleCode).ToString();
            bool packageOrder = Convert.ToBoolean(gridView1.GetFocusedRowCellValue(colPackageDelivery));
            frmTableOrders frm = new frmTableOrders(saleCode:saleCode, packageOrder: packageOrder);
            frm.ShowDialog();
        }

        private void btnPaymentActions_Click(object sender, EventArgs e)
        {
            string saleCode = gridView1.GetFocusedRowCellValue(colSaleCode).ToString();

            frmPayActions frm = new frmPayActions(saleCode: saleCode);
            frm.ShowDialog();
        }

        private void Export_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog dialog=new SaveFileDialog();
            dialog.Filter = e.Item.Tag.ToString();
            if (dialog.ShowDialog()==DialogResult.OK)
            {
                if (e.Item==btnExcelExport)
                {
                    gridView1.ExportToXlsx(dialog.FileName);
                }
               else if (e.Item == btnWord)
                {
                    gridView1.ExportToDocx(dialog.FileName);
                }
                else if (e.Item == btnPdf)
                {
                    gridView1.ExportToPdf(dialog.FileName);
                }
            }
        }
    }
}